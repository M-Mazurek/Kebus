using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebus.Service
{

    internal class ButtonManager
    {
        private int f = 0;
        private int k = 0;
        private int d = 0;
        private int yPadF = 0;
        private int xPadF = 0;
        private int yPadK = 0;
        private int xPadK = 0;
        private int yPadD = 0;
        private int xPadD = 0;
        private int friesCount = 0;
        private int kebabsCount = 0;
        private int drinksCount = 0;
        internal static float sum = 0;
        internal static CultureInfo ci = new("pl-PL");
        private MaterialForm form = null;
        private MaterialListView listView = null;
        private List<TabPage> tabControls = null;
        private MaterialLabel label = null;
        internal static List<uint> addedIds = new();

        public ButtonManager() 
        {
            
        }
        public ButtonManager(MaterialForm materialForm, MaterialListView lv, List<TabPage> tabControls, MaterialLabel lb) 
        {
            form = materialForm;
            listView = lv;
            this.tabControls = tabControls;
            label = lb;
        }

        private MaterialButton CreateButton(uint id, string name, float cost, int x, int y)
        {
            MaterialButton materialButton = new()
            {
                Text = name,
                AutoSize = false,
                Location = new(25 + (200 + 25) * x, 40 + (80 + 40) * y),
                Size = new(200, 80),
            };
            materialButton.Click += (sender, e) =>
            {
                listView.Items.Add(new ListViewItem(new string[] { "1", name, cost.ToString() }));
                sum += cost;
                label.Text = $"Suma: {sum.ToString("c2", ci)}";
                addedIds.Add(id);
            };
            return materialButton;
        }

        public void CreateDish((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) dish)
        {
            switch (dish.category)
            {
                case Kebus.MENU_ITEM_CATEGORY.FRIES:
                    if (friesCount % 3 == 0 && friesCount != 0)
                    {
                        f++;
                        yPadF = f;
                        xPadF = 0;
                    }
                    else if (friesCount != 0)
                    {
                        xPadF++;
                    }
                    tabControls[1].Controls.Add(CreateButton(dish.id, dish.name, dish.cost, xPadF, yPadF));
                    friesCount++;
                    break;
                case Kebus.MENU_ITEM_CATEGORY.KEBABS:
                    if (kebabsCount % 3 == 0 && kebabsCount != 0)
                    {
                        k++;
                        yPadK = k;
                        xPadK = 0;
                    }
                    else if (kebabsCount != 0)
                    {
                        xPadK++;
                    }
                    tabControls[0].Controls.Add(CreateButton(dish.id, dish.name, dish.cost, xPadK, yPadK));
                    kebabsCount++;
                    break;
                case Kebus.MENU_ITEM_CATEGORY.DESSERTS_AND_DRINKS:
                    if (drinksCount % 3 == 0 && drinksCount != 0)
                    {
                        d++;
                        yPadD = d;
                        xPadD = 0;
                    }
                    else if (drinksCount != 0)
                    {
                        xPadD++;
                    }
                    tabControls[2].Controls.Add(CreateButton(dish.id, dish.name, dish.cost, xPadD, yPadD));
                    drinksCount++;
                    break;
                default:
                    throw new Exception("Unexpected category");
            }
        }
    }
}
