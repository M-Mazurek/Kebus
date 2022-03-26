using Kebus.Service;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Kebus {
    public partial class ManagerMenu : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;
        private readonly DataSyncer<(uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category)[]> _menuItemsSyncer;
        CultureInfo pl = new("pl-PL");

        public ManagerMenu() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance; // redundand af; todo: create wrapper or smth
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            _menuItemsSyncer = new(Kebus.GetMenuItems, UpdateMenuList);
            _menuItemsSyncer.RunWorkerAsync();
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
            Manager manager = new();
            manager.ShowDialog();
            Close();
        }

        private void CreateRaportButton_Click(object sender, EventArgs e) {
            Hide();
            ManagerRaport managerRaport = new();
            managerRaport.ShowDialog();
            Close();
        }

        private void UpdateMenuList()
        {
            MenuItemList.Items.Clear();
            foreach (var (id, name, cost, category) in _menuItemsSyncer.CurrentData!)
            {
                MenuItemList.Items.Add(new ListViewItem(new string[]
                {
                    id.ToString().PadLeft(3, '0'),
                    name,
                    category switch
                    {
                        Kebus.MENU_ITEM_CATEGORY.KEBABS => "Kebaby",
                        Kebus.MENU_ITEM_CATEGORY.FRIES => "Frytki",
                        _ => "Desery i napoje"
                    },
                    cost.ToString("c2", pl)
                }));
            }
        }

        private void AddDish_Click(object sender, EventArgs e)
        {
            try
            {
                var name = Interaction.InputBox("Podaj nazwę:", "Nowa pozycja w menu", "Nowe danie");
                var cost = float.Parse(Interaction.InputBox("Podaj cenę (np. 3,99):", "Nowa pozycja w menu", "0,00"));
                var category = (Kebus.MENU_ITEM_CATEGORY)int.Parse(Interaction.InputBox("Podaj kategorię (0 - kebab, 1 - frytki, 2 - napoje/desery): ", "Nowa pozycja w menu", "0"));
            
                Kebus.AddMenuItem(name, cost, category);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podano dane w złym formacie.\n\n" + ex.Message, "Błąd przy dodwaniu");
            }
        }
    }
}
