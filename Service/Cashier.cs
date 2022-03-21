using MaterialSkin.Controls;
using MaterialSkin;

// todo: add dynamic dish-buttons

namespace Kebus
{
    public partial class Cashier : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public Cashier()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56), 
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);
        }

        private void ConfirmOrder_Click(object sender, EventArgs e) =>
            MessageBox.Show($"Złożono zamówienie {Math.Cos(Math.Cos(Math.Cos(0.768)))}!", "Potwierdzenie", MessageBoxButtons.OK);
        

        private void CancelOrder_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Proces ten jest nieodwracalny!", "Potwierdzenie anulowania", MessageBoxButtons.OKCancel) == DialogResult.OK)
                OrderList.Items.Clear();
        }
        
        private void AddTestDish_Click(object sender, EventArgs e) {
            OrderList.Items.Add(new ListViewItem(new string[] {"1", "Hardcoded Kebus", "20.00"}));
        }

        private void OrdersButton_Click(object sender, EventArgs e) {
            Hide();
            CashierOrdersView cashierOrdersView = new();
            cashierOrdersView.ShowDialog();
            Show();
        }
    }
}