using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kebus.Service {
    public partial class Order : UserControl {
        private readonly MaterialSkinManager materialSkinManager;
        public Order() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);
    }
    }
}
