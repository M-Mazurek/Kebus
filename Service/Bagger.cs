using Kebus.Service;
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

// todo: panels loader

namespace Kebus {
    public partial class Bagger : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;
        private DataSyncer<(string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[]> syncer;
        private int POS_X = 15;
        private int POS_Y = 60;
        private int count = 0;

        public Bagger() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance; // redundand af; todo: create wrapper or smth
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            syncer = new(Kebus.GetOrders, Draw, this);
            syncer.RunWorkerAsync();
        }

        private void Draw()
        {
            Panel.Controls.Clear();
            (string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[] es = syncer.CurrentData!;
            //for (int i = 0; i < es.Count(); i++)
            int i = 0;
            foreach (var (id, created, items) in es.Where(x => x.items.All(x => x.state == true)))
            {
                Order order = new()
                {
                    Location = new(POS_X + (new Order().Width + POS_X) * i, POS_Y),
                };
                var p = order.materialButton1.Location;
                p.X -= 40;
                order.materialButton1.Location = p;
                order.materialButton1.Text = "Potwierdź odbiór";
                for (int j = 0; j < items.Length; j++)
                {
                    order.materialLabel1.Text = $"Zamówienie: {id.Split("|")[0].PadLeft(3, '0')}";
                    //order.Location = new(POS_X + (new Order().Width + POS_X) * i, POS_Y);
                    order.materialListView1.Items.Add(new ListViewItem(new string[] { "1", items[j].item.name }));
                    Panel.Controls.Add(order);
                    count++;
                    uint x = (uint)j;
                }
                order.materialButton1.Click += (sender, e) => Kebus.ArchiviseOrder(uint.Parse(id.Split("|")[0]));
                i++;
            }
            Order bugFix = new()
            {
                Location = new(POS_X + (new Order().Width + POS_X) * count, POS_Y),
            };
        }
    }
}
