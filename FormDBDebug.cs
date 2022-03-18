using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kebus
{
    public partial class FormDBDebug : Form
    {
        DataSyncer<dynamic> _menuItemsSyncer;
        public FormDBDebug()
        {
            InitializeComponent();
            _menuItemsSyncer = new(Kebus.GetMenuItems, RefreshMenuDisplay);
            _menuItemsSyncer.RunWorkerAsync();
        }
        private void AddMenuItem(object sender, EventArgs e)
        {
            Kebus.AddMenuItem(txtMenuName.Text, 
                              float.Parse(txtMenuCost.Text), 
                              (Kebus.MENU_ITEM_CATEGORY)int.Parse(txtMenuCategory.Text));
        }

        private void RefreshMenuDisplay()
        {
            (uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category)[]? arr = _menuItemsSyncer.CurrentData;
            lbMenu.Items.AddRange(arr?.ToList().Select(x => $"{x.name} - {x.cost}zł").ToArray() ?? Array.Empty<string>());
        }
    }
}
