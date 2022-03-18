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
        private (uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category)[]? _currentMenu;
        public FormDBDebug()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void AddMenuItem(object sender, EventArgs e)
        {
            Kebus.AddMenuItem(txtMenuName.Text, 
                              float.Parse(txtMenuCost.Text), 
                              (Kebus.MENU_ITEM_CATEGORY)int.Parse(txtMenuCategory.Text));
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(1000);
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var currentMenu = Kebus.GetMenuItems();
            if (_currentMenu != currentMenu)
            {
                _currentMenu = currentMenu;
                RefreshMenuDisplay();
            }
        }

        private void RefreshMenuDisplay() =>
            txtMenu.Text = string.Join(Environment.NewLine, Kebus.GetMenuItems());
    }
}
