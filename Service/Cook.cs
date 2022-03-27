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
            syncer = new(Kebus.GetOrders, Draw);
            syncer.RunWorkerAsync();
        }

        private void Draw() 
        {
            (string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[] es = syncer.CurrentData!;
            for (int i = 0; i < es.Count(); i++) 
            {
                Order order = new()
                {
                    //Location = new(POS_X + (new Order().Width + POS_X) * count, POS_Y),
                };
                for (int j = 0; j < es[i].items.Count(); j++)
                {
                    
                    if (es[i].items[j].item.category == category) 
                    {
                        order.materialLabel1.Text = $"Zamówienie: {es[i].id.Split("|")[0].PadLeft(3, '0')}";
                        order.Location = new(POS_X + (new Order().Width + POS_X) * count, POS_Y);
                        order.materialListView1.Items.Add(new ListViewItem(new string[] { "1", es[i].items[j].item.name }));
                        Panel.Controls.Add(order);
                        count++;
                    }
                }            
            }
            Order bugFix = new()
            {
                Location = new(POS_X + (new Order().Width + POS_X) * count, POS_Y),
            };
        }
    }
}
