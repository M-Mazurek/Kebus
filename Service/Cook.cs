using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kebus.Service;

namespace Kebus {
    public partial class Cook : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;
        private DataSyncer<(string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[]> syncer;
        private int POS_X = 15;
        private int POS_Y = 60;
        private Kebus.MENU_ITEM_CATEGORY category;
        private int count = 0;
        public Cook(Kebus.MENU_ITEM_CATEGORY category) {
            InitializeComponent();
            Text = $"Kebus System : Stanowisko {category switch { Kebus.MENU_ITEM_CATEGORY.FRIES => "Frytkarza", Kebus.MENU_ITEM_CATEGORY.KEBABS => "Kebusiarza", Kebus.MENU_ITEM_CATEGORY.DESSERTS_AND_DRINKS => "Drinarza",_ => throw(new("Unexpected category")),}}"; // polish is ..., so u have to use genetive : D
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            this.category = category;
            syncer = new(Kebus.GetOrders, Draw, this);
            syncer.RunWorkerAsync();
        }

        private void Draw() 
        {
            Panel.Controls.Clear();
            (string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[] es = syncer.CurrentData!;
            //for (int i = 0; i < es.Count(); i++)
            int i = 0;
            foreach(var _es in es) 
            {
                if (!_es.items.Any(x => x.item.category == category) || _es.items.Where(x => x.item.category == category).All(x => x.state == true))
                    continue;
                Order order = new()
                {
                    Location = new(POS_X + (new Order().Width + POS_X) * i, POS_Y),
                };
                for (int j = 0; j < _es.items.Count(); j++)
                {
                    
                    if (_es.items[j].item.category == category) 
                    {
                        order.materialLabel1.Text = $"Zamówienie: {_es.id.Split("|")[0].PadLeft(3, '0')}";
                        //order.Location = new(POS_X + (new Order().Width + POS_X) * i, POS_Y);
                        order.materialListView1.Items.Add(new ListViewItem(new string[] { "1", _es.items[j].item.name}));
                        Panel.Controls.Add(order);
                        count++;
                        uint x = (uint)j;
                        order.materialButton1.Click += (sender, e) => Kebus.UpdateOrderItemState(uint.Parse(_es.id.Split("|")[0]), x);
                    }
                }
                i++;
            }
            Order bugFix = new()
            {
                Location = new(POS_X + (new Order().Width + POS_X) * count, POS_Y),
            };
        }
    }
}
