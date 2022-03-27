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

namespace Kebus {
    public partial class CashierOrdersView : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;

        public CashierOrdersView() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            /*ContentScroll.Hide();*/
            /*MaterialScrollBar scrollBar = new()
            {
                Size = new(Width, 10),
                Dock = DockStyle.Bottom,
            };
            scrollBar.Scroll += ContentScroll_Scroll;
            Controls.Add(scrollBar);*/
        }

        private void materialButton1_Click(object sender, EventArgs e) =>
            Close();

        private void CashierOrdersView_Load(object sender, EventArgs e)
        {
            (string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[] es = Kebus.GetOrders();
            //MessageBox.Show(es[0].items[0].item.name);
            //MessageBox.Show(es.Count().ToString());
            for (int i = 0; i < es.Count(); i++)
            {
                MaterialListView listView = new()
                {
                    Size = new(500, 520),
                    Location = new(25 + (500 + 25) * i, 10),
                };
                foreach (string x in new string[] { "Numer", "Utworzony", "Nazwa", "Koszt", "Kategoria", "Gotowe" })
                {
                    listView.Columns.Add(x, 200);
                }
                for (int j = 0; j < es[i].items.Count(); j++) 
                {
                    listView.Items.Add(new ListViewItem(new string[] { es[i].id.Split("|")[0].PadLeft(3,'0'), es[i].created.ToString(), es[i].items[j].item.name, es[i].items[j].item.cost.ToString(), es[i].items[j].item.category.ToString(), es[i].items[j].state ? "Tak" : "Nie" }));
                }
                Panel.Controls.Add(listView);
            }
            //ContentScroll.MaximumSize = new(25 + (500 + 25) * es.Count(), 10);
            //ContentScroll.Maximum = 100 * es.Count(); //25 + (500 + 25) * es.Count()
        }

        private void ContentScroll_Scroll(object sender, ScrollEventArgs e)
        {
            //ten scroll nie dziala wizualnie tylko
            //mouse scroll dziala
            HorizontalScroll.Value = e.NewValue;
            //MessageBox.Show(HorizontalScroll.Value.ToString());
        }
    }
}
