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
        private int i = 0;
        private int yPad = 0;
        private int xPad = 0;
        private int count = 0;
        internal float sum = 0;
        private CultureInfo ci = new("pl-PL");
        private MaterialForm form = null;
        private MaterialListView listView = null;
        private List<TabPage> tabControls = null;
        private MaterialLabel label = null;

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
                listView.Items.Add(new ListViewItem(new string[] { "1", name, cost.ToString() }));
                sum += cost;
                label.Text = $"Suma: {sum.ToString("c2", ci)}";
            };
            return materialButton;
        }

        public void CreateDish((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) dish)
        {
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
                    tabControls[1].Controls.Add(CreateButton(dish.name, dish.cost));
                    count++;
                    break;
                case Kebus.MENU_ITEM_CATEGORY.KEBABS:
                    tabControls[0].Controls.Add(CreateButton(dish.name, dish.cost));
                    break;
                case Kebus.MENU_ITEM_CATEGORY.DESSERTS_AND_DRINKS:
                    tabControls[2].Controls.Add(CreateButton(dish.name, dish.cost));
                    break;
                default:
                    throw new Exception("Unexpected category");
            }
        }
    }
}
