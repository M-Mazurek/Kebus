using MaterialSkin.Controls;
using MaterialSkin;
using System.Globalization;

// todo: add dynamic dish-buttons

namespace Kebus
{
    public partial class Cashier : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        int i = 0;
        int yPad = 0;
        int xPad = 0;
        int count = 0;
        float sum = 0;
        /*public void createDishes((string name, float cost)dishes)
        {
            int j = 0;
            int k = 0;
            for (int i = 0; i < BUTTON_COUNT; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    j++;
                    k = 0;
                }
                else if (i != 0)
                {
                    k++;
                }
                MaterialButton materialButton = new()
                {
                    Text = dishes.name,
                    AutoSize = false,
                    Location = new(25 + (200 + 25) * k, 40 + (80 + 40) * j),
                    Size = new(200, 80),
                };
                //SetsPage.Controls.Add(materialButton);
            }
        }*/

        private MaterialButton CreateButton(string name, float cost) 
        {
            MaterialButton materialButton = new()
            {
                Text = name,
                AutoSize = false,
                Location = new(25 + (200 + 25) * xPad, 40 + (80 + 40) * yPad),
                Size = new(200, 80),
            };
            materialButton.Click += (sender, e) => 
            {
                OrderList.Items.Add(new ListViewItem(new string[] { "1", name, cost.ToString() }));
                CalculateCost(cost);
            };
            return materialButton;
        }

        public void CreateDish((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) dish)
        {
            /*if (i % 3 == 0 && i != 0)
            {
                j++;
                k = 0;
            }
            else if (i != 0)
            {
                k++;
            }*/
            switch (dish.category) 
            {
                case Kebus.MENU_ITEM_CATEGORY.FRIES:
                    if (count % 3 == 0 && count != 0)
                    {
                        i++;
                        yPad = i;
                        xPad = 0;
                    }
                    else if (count != 0)
                    {
                        xPad++;
                    }
                    FriesPage.Controls.Add(CreateButton(dish.name, dish.cost));
                    count++;
                    break;
                case Kebus.MENU_ITEM_CATEGORY.KEBABS:
                    KebabsPage.Controls.Add(CreateButton(dish.name, dish.cost));
                    break;
                case Kebus.MENU_ITEM_CATEGORY.DESSERTS_AND_DRINKS:
                    DrinksPage.Controls.Add(CreateButton(dish.name, dish.cost));
                    break;
                default:
                    throw new Exception("Unexpected category");
            }
            
            //i++;
        }

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

            Kebus.GetMenuItems().ToList().ForEach(menuItem => 
            {
                CreateDish((menuItem.id, menuItem.name, menuItem.cost, menuItem.category));
            });
        }

        private void ConfirmOrder_Click(object sender, EventArgs e) =>
            MessageBox.Show($"Złożono zamówienie {Math.Cos(Math.Cos(Math.Cos(0.768)))}!", "Potwierdzenie", MessageBoxButtons.OK);
        

        private void CancelOrder_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Proces ten jest nieodwracalny!", "Potwierdzenie anulowania", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                OrderList.Items.Clear();
                TotalPriceLabel.Text = "Suma: ";
                sum = 0;
            }
        }

        private void OrdersButton_Click(object sender, EventArgs e) {
            Hide();
            CashierOrdersView cashierOrdersView = new();
            cashierOrdersView.ShowDialog();
            Show();
        }

        private void CalculateCost(float cost) 
        {
            CultureInfo ci = new("pl-PL");
            sum += cost;
            TotalPriceLabel.Text = $"Suma: {sum.ToString("c2", ci)}";
        }
    }
}