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
    public partial class SelfCheckoutOrderView : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;

        public SelfCheckoutOrderView(List<ListViewItem> orderedItems) {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);
            OrderList.Items.Clear();
            foreach (var item in orderedItems) // to fix: after closing this form and reopening it, Adding items throws Exception; idk why
                OrderList.Items.Add(item);
            
        }

        private void ConfirmOrderButton_Click(object sender, EventArgs e) {

        }

        private void CloseOrderButton_Click(object sender, EventArgs e) =>
            Close();

    }
}
