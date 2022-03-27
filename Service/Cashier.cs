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

            //for (int a = 0; a < 5; a++) {
            //    Kebus.AddMenuItem("kebab", 15, Kebus.MENU_ITEM_CATEGORY.KEBABS);
            //    Kebus.AddMenuItem("Fryta", 15, Kebus.MENU_ITEM_CATEGORY.FRIES);
            //    Kebus.AddMenuItem("Drin", 15, Kebus.MENU_ITEM_CATEGORY.DESSERTS_AND_DRINKS);
            //}
            btnManager = new(this, OrderList, new() { KebabsPage, FriesPage, DrinksPage }, TotalPriceLabel);
            Kebus.GetMenuItems().ToList().ForEach(menuItem =>
            {
                btnManager.CreateDish((menuItem.id, menuItem.name, menuItem.cost, menuItem.category));
            });

            OrderList.MouseDoubleClick += OrderList_MouseDoubleClick;

            // : - )
            //drinksScroll.Value = DrinksPage.VerticalScroll.Value;
            //drinksScroll.Minimum = DrinksPage.VerticalScroll.Minimum;
            //drinksScroll.Maximum = DrinksPage.VerticalScroll.Maximum;
            
        }

        private void OrderList_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            MaterialListView item = sender as MaterialListView;
            ButtonManager.sum -= float.Parse(item.SelectedItems[0].SubItems[2].Text);
            TotalPriceLabel.Text = $"Suma: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}";

            item.SelectedItems[0].Remove();
        }

        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            if (ButtonManager.addedIds.Count != 0)
            {
                MessageBox.Show($"Złożono zamówienie nr. {Kebus.NextOrderId()}!", "Potwierdzenie", MessageBoxButtons.OK);
                Kebus.CreateOrder(ButtonManager.addedIds.ToArray());
                OrderList.Items.Clear();
                ButtonManager.sum = 0;
                TotalPriceLabel.Text = $"Suma: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}";
                ButtonManager.addedIds = null;
            }
            else
                MessageBox.Show("Puste zamówienie?");
        }
        
        private void CancelOrder_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Proces ten jest nieodwracalny!", "Potwierdzenie anulowania", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                OrderList.Items.Clear();
                TotalPriceLabel.Text = "Suma: 0.00 zł";
                ButtonManager.sum = 0;
                ButtonManager.addedIds = null;
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