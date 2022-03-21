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

namespace Kebus {
    public partial class ManagerStatistics : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;

        public ManagerStatistics() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance; // redundand af; todo: create wrapper or smth
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);
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
    }
}
