using MaterialSkin.Controls;
using MaterialSkin;
using Kebus.Service;

// todo: add dynamic dish-buttons

namespace Kebus
{
    public partial class Cashier : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private ButtonManager btnManager;

        public Cashier()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56), 
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            /*for (int a = 0; a < 5; a++)
            {
                Kebus.AddMenuItem("kebab", 15, Kebus.MENU_ITEM_CATEGORY.KEBABS);
                Kebus.AddMenuItem("Fryta", 15, Kebus.MENU_ITEM_CATEGORY.FRIES);
                Kebus.AddMenuItem("Drin", 15, Kebus.MENU_ITEM_CATEGORY.DESSERTS_AND_DRINKS);
            }*/
            btnManager = new(this, OrderList, new() { KebabsPage, FriesPage, DrinksPage }, TotalPriceLabel);
            Kebus.GetMenuItems().ToList().ForEach(menuItem => 
            {
                btnManager.CreateDish((menuItem.id, menuItem.name, menuItem.cost, menuItem.category));
            });
        }

        private void ConfirmOrder_Click(object sender, EventArgs e) =>
            MessageBox.Show($"Złożono zamówienie {Math.Cos(Math.Cos(Math.Cos(0.768)))}!", "Potwierdzenie", MessageBoxButtons.OK);
        

        private void CancelOrder_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Proces ten jest nieodwracalny!", "Potwierdzenie anulowania", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                OrderList.Items.Clear();
                TotalPriceLabel.Text = "Suma: 0.00 zł";
                btnManager.sum = 0;
            }
        }

        private void OrdersButton_Click(object sender, EventArgs e) {
            Hide();
            CashierOrdersView cashierOrdersView = new();
            cashierOrdersView.ShowDialog();
            Show();
        }
    }
}