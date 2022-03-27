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
        private int POS_X = 0;
        private int POS_Y = 0;

        public Cook(string positionName) {
            InitializeComponent();
            Text = $"Kebus System : Stanowisko {positionName}"; // polish is ..., so u have to use genetive : D
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

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
                    Location = new(15 + (new Order().Width + 15) * i, 15),
                };
                order.materialListView1.Items.Add(new ListViewItem(new string[] { "Fryta", "15" }));
                Panel.Controls.Add(order);
            }
        }
    }
}
