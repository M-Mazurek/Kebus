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
    public partial class SelfCheckout : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;
        //private List<ListViewItem> orderedItems = new List<ListViewItem>();
        private ButtonManager btnManager;
        private SelfCheckoutOrderView orderView = new();
        public SelfCheckout() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            btnManager = new(this, orderView.getOrderList(), new() { KebabsPage, FriesPage, DrinksPage }, TotalPriceLabel);
            Kebus.GetMenuItems().ToList().ForEach(menuItem =>
            {
                btnManager.CreateDish((menuItem.id, menuItem.name, menuItem.cost, menuItem.category));
            });
            ButtonManager.addedIds.Clear();
            orderView.getOrderList().Items.Clear();
            ButtonManager.sum = 0;
            TotalPriceLabel.Text = $"Suma: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}";
            ButtonManager.addedIds.Clear();
        }
        
        private void ConfirmOrderButton_Click(object sender, EventArgs e) {
            //MessageBox.Show(btnManager.addedIds.Count().ToString());
            if (ButtonManager.addedIds.Count() != 0)
            {
                MessageBox.Show($"Złożono zamówienie nr. {Kebus.NextOrderId()}.\nDo zapłaty: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}.");
                Kebus.CreateOrder(ButtonManager.addedIds.ToArray());
                ButtonManager.addedIds.Clear();
                ButtonManager.sum = 0;
                orderView.getOrderList().Items.Clear();
                TotalPriceLabel.Text = $"Suma: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}";
                //Close();
            }
            else
                MessageBox.Show("Nie wybrano żadnego produktu.\nSkładanie zamówienia nie powiodło się.");
        }

        private void ShowOrderButton_Click(object sender, EventArgs e) {
            Hide();
            orderView.ShowDialog();
            Show();
        }

        private void SelfCheckout_Load(object sender, EventArgs e)
        {
            TotalPriceLabel.Text = $"Suma: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}";
        }
    }
}
