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
using MaterialSkin;
using System.Globalization;

namespace Kebus {
    public partial class ManagerStatistics : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;
        CultureInfo pl = new("pl-PL");

        public ManagerStatistics() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance; // redundand af; todo: create wrapper or smth
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            UpdateStats();
        }

        private void ShowOrdersButton_Click(object sender, EventArgs e) {
            Hide();
            ManagerOrdersView managerOrdersView = new();
            managerOrdersView.ShowDialog();
            Close();
        }

        private void ShowStatisticsButton_Click(object sender, EventArgs e) {
            Hide();
            Manager manager = new();
            manager.ShowDialog();
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

        private void UpdateStats()
        {
            var orders = Kebus.GetArchivizedOrders();

            // powodzenia
            YesterdayScore.Text = orders.Where(x => x.id.Split('|')[1] == DateOnly.FromDateTime(DateTime.Now).AddDays(-1).ToString())
                                        .Select(x => x.items.Select(x => x.item.cost)).Sum(x => x.Sum()).ToString("c2", pl);
            TodayScore.Text = orders.Where(x => x.id.Split('|')[1] == DateOnly.FromDateTime(DateTime.Now).ToString())
                                        .Select(x => x.items.Select(x => x.item.cost)).Sum(x => x.Sum()).ToString("c2", pl);
            DailyAvg.Text = (orders.Select(x => x.items.Select(x => x.item.cost).Sum()).Sum() /
                            orders.Select(x => x.id.Split('|')[1]).Distinct().Count()).ToString("c2", pl);
            LastMonthScore.Text = orders.Where(x => DateOnly.Parse(x.id.Split('|')[1]).Month + 1 == DateTime.Now.Month)
                                        .Select(x => x.items.Select(x => x.item.cost)).Sum(x => x.Sum()).ToString("c2", pl);
            ThisMonthScore.Text = orders.Where(x => DateOnly.Parse(x.id.Split('|')[1]).Month == DateTime.Now.Month)
                                        .Select(x => x.items.Select(x => x.item.cost)).Sum(x => x.Sum()).ToString("c2", pl);
            MonthAvg.Text = (orders.Select(x => x.items.Select(x => x.item.cost).Sum()).Sum() /
                            orders.Select(x => DateOnly.Parse(x.id.Split('|')[1]).Month).Distinct().Count()).ToString("c2", pl);
        }
    }
}
