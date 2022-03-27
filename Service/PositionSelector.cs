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
    public partial class PositionSelector : MaterialForm {

        readonly MaterialSkinManager materialSkinManager;

        public PositionSelector() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance; // redundand af; todo: create wrapper or smth
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);
        }

        private void Confirm_Click(object sender, EventArgs e) { // todo (or rather to learn): how to make it prettier(?)/faster? 
            switch (PositionComboBox.Text) 
            {
                case "Ekspedient": 
                {
                    Hide();
                    Cashier cashierView = new();
                    cashierView.ShowDialog();
                    Show();
                    break;
                }
                case "Stanowisko Pakowacza": 
                {
                    Hide();
                    Bagger baggerView = new();
                    baggerView.ShowDialog();
                    Show();
                    break;
                }
                case "Stanowisko Frytkarza": 
                {
                    Hide();
                    Cook cookView = new(Kebus.MENU_ITEM_CATEGORY.FRIES);
                    cookView.ShowDialog();
                    Show();
                    break;
                }
                case "Stanowisko Kebusiarza": 
                {
                    Hide();
                    Cook cookView = new(Kebus.MENU_ITEM_CATEGORY.KEBABS);
                    cookView.ShowDialog();
                    Show();
                    break;
                }
                case "Stanowisko Napojów i Deserów": 
                {
                    Hide();
                    Cook cookView = new(Kebus.MENU_ITEM_CATEGORY.DESSERTS_AND_DRINKS);
                    cookView.ShowDialog();
                    Show();
                    break;
                }
                case "Monitor Zamówień": 
                {
                    Hide();
                    Orderboard orderboardView = new();
                    orderboardView.ShowDialog();
                    Show();
                    break;
                }
                case "Kasa Samoobsługowa": 
                {
                    Hide();
                    SelfCheckout selfCheckoutView = new();
                    selfCheckoutView.ShowDialog();
                    Show();
                    break;
                }
                case "Kierownik": 
                {
                    Hide();
                    Manager managerView = new();
                    managerView.ShowDialog();
                    Show();
                    break;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e) => 
            Close();
    }
}
