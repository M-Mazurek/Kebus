﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Dynamic;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Kebus
{
    public static class Kebus
    {
        private readonly static IMongoCollection<BsonDocument> _menuItems;
        private readonly static IMongoCollection<BsonDocument> _orders;
        private readonly static IMongoCollection<BsonDocument> _orderLogs;

        private const string CONNECTION_STRING = "mongodb+srv://formususer001:hardpassword@formuscluster.7jukc.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
        private const string DB_NAME = "KebusDB";
        private const string MENU_ITEMS_COLLECTION_NAME = "menu_items";
        private const string ORDERS_COLLECTION_NAME = "orders";
        private const string ORDER_LOGS_COLLECTION_NAME = "order_logs";

        public enum MENU_ITEM_CATEGORY
        {
            KEBABS,
            FRIES,
            DESSERTS_AND_DRINKS
        }
        private static readonly FilterDefinition<BsonDocument> EMPTY_FILTER = Builders<BsonDocument>.Filter.Empty;
        
        private static FilterDefinition<BsonDocument> MatchField<T>(string fieldName, T value) => 
            Builders<BsonDocument>.Filter.Eq(fieldName, value);
        private static FilterDefinition<BsonDocument> MatchId<T>(T id) =>
            MatchField("_id", id);
        private static BsonDocument ExpandoToBson(dynamic eo) =>
            BsonSerializer.Deserialize<BsonDocument>(JsonConvert.SerializeObject(eo));

        private static (uint id, string name, float cost, MENU_ITEM_CATEGORY category) ExplodeMenuItem(BsonValue doc) =>
            ((uint)doc["_id"].AsInt32,
             doc["name"].AsString,
             (float)doc["cost"].AsDouble,
             (MENU_ITEM_CATEGORY)doc["category"].AsInt32);

        private static (string id, DateTime created, ((uint id, string name, float cost, MENU_ITEM_CATEGORY category) item, bool state)[] items) ExplodeOrder(BsonDocument doc) =>
            (doc["_id"].AsString,
             DateTime.Parse(doc["order_time"].AsString),
             doc["menu_items"].AsBsonArray.ToList().Select(index => (GetMenuItemById((uint)index["Item1"].AsInt32), index[1].AsBoolean)).ToArray());

        static Kebus()
        {
            MongoClient client = new(CONNECTION_STRING);
            var db = client.GetDatabase(DB_NAME);
            _menuItems = db.GetCollection<BsonDocument>(MENU_ITEMS_COLLECTION_NAME);
            _orders = db.GetCollection<BsonDocument>(ORDERS_COLLECTION_NAME);
            _orderLogs = db.GetCollection<BsonDocument>(ORDER_LOGS_COLLECTION_NAME);
        }

        public static void Connect() { }

        public static void AddMenuItem(string name, float cost, MENU_ITEM_CATEGORY category)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Nazwa nowej pozycji w menu nie może być pusta.");
            
            cost = Math.Abs(cost);
            uint id;
            try
            {
                id = (uint)_menuItems.Find(EMPTY_FILTER).SortBy(x => x["_id"]).ToList()[^1]["_id"].AsInt32 + 1;
            }
            catch
            {
                id = 0;
            }
            dynamic menuItem = new ExpandoObject();
            menuItem._id = id;
            menuItem.name = name;
            menuItem.cost = cost;
            menuItem.category = category;

            _menuItems.InsertOne(ExpandoToBson(menuItem));
        }

        public static (uint id, string name, float cost, MENU_ITEM_CATEGORY category) GetMenuItemById(uint id) =>        
            ExplodeMenuItem(_menuItems.Find(MatchId(id)).First());

        public static (uint id, string name, float cost, MENU_ITEM_CATEGORY category)[] GetMenuItems() =>
            _menuItems.Find(EMPTY_FILTER).ToList().Select(doc => ExplodeMenuItem(doc)).ToArray();

        public static uint NextOrderId()
        {
            var orders = _orders.Find(EMPTY_FILTER).ToList();
            var aorders = _orderLogs.Find(EMPTY_FILTER).ToList(); 
            return (uint)(orders.Count + aorders.Count) + 1;
        }

        public static void CreateOrder(uint[] menuItemIds)
        {
            if (menuItemIds.Length == 0)
                throw new Exception("Zamówienie nie może być puste.");

            var itemsWithState = menuItemIds.Select(item => (item, false));

            dynamic order = new ExpandoObject();
            order._id = $"{NextOrderId()}|{DateOnly.FromDateTime(DateTime.Now).ToShortDateString().Replace('/', '.')}";
            order.order_time = DateTime.Now.ToUniversalTime();
            order.menu_items = itemsWithState;

            _orders.InsertOne(ExpandoToBson(order));
        }

        public static (string id, DateTime created, ((uint id, string name, float cost, MENU_ITEM_CATEGORY category) item, bool state)[] items) GetOrder(uint id) =>
            ExplodeOrder(_orders.Find(MatchId(string.Join('|', id, DateOnly.FromDateTime(DateTime.Now).ToString().Replace('/', '.')))).First());
        public static (string id, DateTime created, ((uint id, string name, float cost, MENU_ITEM_CATEGORY category) item, bool state)[] items)[] GetOrders() =>
            _orders.Find(EMPTY_FILTER).ToList().Select(doc => ExplodeOrder(doc)).ToArray();
        public static void UpdateOrderItemState(uint orderId, uint index)
        {
            _orders.UpdateOne(MatchId($"{orderId}|{DateOnly.FromDateTime(DateTime.Now).ToString().Replace('/', '.')}"), 
                Builders<BsonDocument>.Update.Set(order => order["menu_items"][(int)index]["Item2"], true));
        }

        public static void ArchiviseOrder(uint orderId)
        {
            _orderLogs.InsertOne(_orders.Find(MatchId($"{orderId}|{DateOnly.FromDateTime(DateTime.Now).ToString().Replace('/', '.')}")).First());
            _orders.DeleteOne(MatchId($"{orderId}|{DateOnly.FromDateTime(DateTime.Now).ToString().Replace('/', '.')}"));
        }

        public static (string id, DateTime created, ((uint id, string name, float cost, MENU_ITEM_CATEGORY category) item, bool state)[] items)[] GetArchivizedOrders() =>
            _orderLogs.Find(EMPTY_FILTER).ToList().Select(doc => ExplodeOrder(doc)).ToArray();

    }
}
