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
    public partial class Orderboard : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;
        private const int POS_X = 9;
        private const int SIZE_X_BOX = 558;
        private const int SIZE_X_LABEL = 548;
        private const int SIZE_Y_BOX = 60;
        private const int SIZE_Y_LABEL = 50;
        private int readyOrders = 0;
        private int pendingOrders = 0;
        private DataSyncer<(string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[]> syncer;
        private MaterialLabel readyName = new()
        {
            Size = new(SIZE_X_BOX, SIZE_Y_BOX),
            Location = new(POS_X, 5),
            TextAlign = ContentAlignment.MiddleCenter,
            Text = "Gotowe Zamówienia",
    };
        private MaterialLabel pendingName = new()
        {
            Size = new(SIZE_X_BOX, SIZE_Y_BOX),
            Location = new(POS_X, 5),
            TextAlign = ContentAlignment.MiddleCenter,
            Text = "Przygotowywane Zamówienia",
    };
        public Orderboard() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            syncer = new(Kebus.GetOrders, Orderboard_Load, this);
            syncer.RunWorkerAsync();

            if(syncer.CurrentData != null)
                Orderboard_Load();
        }

        private void Orderboard_Load()
        {
            SplitContainer.Panel1.Controls.Clear();
            SplitContainer.Panel2.Controls.Clear();

            SplitContainer.Panel1.Controls.Add(pendingName);
            SplitContainer.Panel2.Controls.Add(readyName);

            readyOrders = 0;
            pendingOrders = 0;
            (string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[] es = syncer.CurrentData!;
            for (int i = 0; i < es.Count(); i++) 
            {
                MaterialCard card = new()
                {
                    /*Location = new(POS_X, 64 + (60 + 10) * pendingOrders),*/
                    Size = new(SIZE_X_BOX, SIZE_Y_BOX),
                };
                MaterialLabel label = new()
                {
                    /*Location = new(POS_X + 5, 69 + (50 + 20) * pendingOrders),*/
                    Size = new(SIZE_X_LABEL, SIZE_Y_LABEL),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                //MessageBox.Show(label.SkinManager.BackgroundColor.ToString());
                label.Text = es[i].id.Split("|")[0].PadLeft(3, '0');
                if(es[i].items.All(item => item.state))
                {
                    card.Location = new(POS_X, 64 + (60 + 10) * readyOrders);
                    label.Location = new(POS_X + 5, 69 + (50 + 20) * readyOrders);
                    SplitContainer.Panel2.Controls.Add(label);
                    SplitContainer.Panel2.Controls.Add(card);
                    readyOrders++;
                }
                else
                {
                    card.Location = new(POS_X, 64 + (60 + 10) * pendingOrders);
                    label.Location = new(POS_X + 5, 69 + (50 + 20) * pendingOrders);
                    SplitContainer.Panel1.Controls.Add(label);
                    SplitContainer.Panel1.Controls.Add(card);
                    pendingOrders++;
                }
            }
        }
    }
}
