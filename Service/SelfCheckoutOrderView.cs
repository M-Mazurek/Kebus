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
using System.Globalization;
using Kebus.Service;

namespace Kebus {
    public partial class SelfCheckoutOrderView : MaterialForm {

        private readonly MaterialSkinManager materialSkinManager;
        public MaterialListView getOrderList() 
        {
            return OrderList;
        }

        public SelfCheckoutOrderView()
        { 
            //List<ListViewItem> orderedItems
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(37, 46, 56), Color.FromArgb(37, 46, 56),
                Color.FromArgb(143, 46, 56), Color.FromArgb(29, 41, 53), TextShade.WHITE);

            /* OrderList.Items.Clear();

             foreach (var item in orderedItems) // to fix: after closing this form and reopening it, Adding items throws Exception; idk why
                 OrderList.Items.Add(item);*/
            ButtonManager.addedIds.Clear();
            OrderList.Items.Clear();
            ButtonManager.sum = 0;
            TotalPriceLabel.Text = $"Suma: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}";
            ButtonManager.addedIds.Clear();
            OrderList.MouseDoubleClick += OrderList_MouseDoubleClick;
        }

        private void OrderList_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            MaterialListView item = sender as MaterialListView;
            ButtonManager.sum -= float.Parse(item.SelectedItems[0].SubItems[2].Text);
            TotalPriceLabel.Text = $"Suma: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}";

            item.SelectedItems[0].Remove();
        }

        private void ConfirmOrderButton_Click(object sender, EventArgs e) {

            if (ButtonManager.addedIds.Count() != 0)
            {
                MessageBox.Show($"Złożono zamówienie nr. {Kebus.NextOrderId()}.\nDo zapłaty: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}.");
                Kebus.CreateOrder(ButtonManager.addedIds.ToArray());
                ButtonManager.addedIds.Clear();
                ButtonManager.sum = 0;
                OrderList.Items.Clear();
                TotalPriceLabel.Text = $"Suma: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}";
                /*Hide();
                new PositionSelector().ShowDialog();
                Show();*/
            }
            else
                MessageBox.Show("Nie wybrano żadnego produktu.\nSkładanie zamówienia nie powiodło się.");
        }

        private void CloseOrderButton_Click(object sender, EventArgs e) 
        {
            Hide();
            SelfCheckout selfCheckout = new();
            selfCheckout.ShowDialog();
            Show();
        }

        private void SelfCheckoutOrderView_Load(object sender, EventArgs e)
        {
            TotalPriceLabel.Text = $"Suma: {ButtonManager.sum.ToString("c2", ButtonManager.ci)}";
        }
    }
}
