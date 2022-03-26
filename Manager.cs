using MaterialSkin;
using MaterialSkin.Controls;
using Kebus.Service;
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
    public partial class Manager : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;
        (string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[] orders;

        public Manager() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance; // redundand af; todo: create wrapper or smth
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            orders = Kebus.GetArchivizedOrders();
            DisplayOrders();
        }

        private void ShowOrdersButton_Click(object sender, EventArgs e) {
            Hide();
            ManagerOrdersView managerOrdersView = new();
            managerOrdersView.ShowDialog();
            Close();
        }

        private void ShowStatisticsButton_Click(object sender, EventArgs e) {
            Hide();
            ManagerStatistics managerStatistics = new();
            managerStatistics.ShowDialog();
            Close();
        }

        private void ShowMenuButton_Click(object sender, EventArgs e) {
            Hide();
            ManagerMenu managerMenu = new();
            managerMenu.ShowDialog();
            Close();
        }

        private void CreateRaportButton_Click(object sender, EventArgs e) {
            Hide();
            ManagerRaport managerRaport = new();
            managerRaport.ShowDialog();
            Close();
        }

        private void DisplayOrders()
        {
            LastOrdersList.Items.Clear();

            foreach (var (id, created, items) in orders[..(orders.Length < 10 ? orders.Length : 9)].Reverse())
            {
                ListViewItem lvi = new(new string[]
                {
                    id.Split('|')[0].PadLeft(3, '0').ToString(),
                    string.Join(", ", items.Select(x => x.item.name)),
                    id.Split('|')[1],
                    items.Select(x => x.item.cost).Sum().ToString()
                });
                LastOrdersList.Items.Add(lvi);
            }
            LastOrdersList.Show();
        }
    }
}
