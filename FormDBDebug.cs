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
        private readonly DataSyncer<(uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category)[]> _menuItemsSyncer;
        private readonly DataSyncer<(string id, DateTime created, ((uint id, string name, float cost, Kebus.MENU_ITEM_CATEGORY category) item, bool state)[] items)[]> _orderListSyncer;

        private readonly List<uint> _kIndices = new();
        private readonly List<uint> _fIndices = new();
        private readonly List<uint> _dIndices = new();

        public FormDBDebug()
        {
            InitializeComponent();
            _menuItemsSyncer = new(Kebus.GetMenuItems, RefreshMenuDisplay);
            _orderListSyncer = new(Kebus.GetOrders, RefreshOrderListDisplay);

            _menuItemsSyncer.RunWorkerAsync();
            _orderListSyncer.RunWorkerAsync();
        }
        private void AddMenuItem(object sender, EventArgs e) =>
            Kebus.AddMenuItem(txtMenuName.Text, 
                              float.Parse(txtMenuCost.Text), 
                              (Kebus.MENU_ITEM_CATEGORY)int.Parse(txtMenuCategory.Text));

        private void RefreshMenuDisplay() =>
            lbMenu.Items.AddRange(_menuItemsSyncer.CurrentData?.ToList().Select(x => $"{x.name} - {x.cost}zł").ToArray() ?? Array.Empty<string>());

        private void CreateOrder(object sender, EventArgs e)
        {
            List<uint> selectedIndices = new();
            foreach (int index in lbMenu.SelectedIndices)
            {
                selectedIndices.Add((uint)index);
            }
            Kebus.CreateOrder(selectedIndices.ToArray());
        }

        private void RefreshOrderListDisplay()
        {
            if (_orderListSyncer.CurrentData is null)
                return;

            txtOrders.ResetText();
            cbF.Items.Clear();
            cbK.Items.Clear();
            cbD.Items.Clear();
            cbRdy.Items.Clear();

            foreach (var (id, created, items) in _orderListSyncer.CurrentData.Reverse())
            {
                txtOrders.SelectionFont = new Font(txtOrders.Font, FontStyle.Bold);
                txtOrders.AppendText(id.Split('|')[0].PadLeft(3, '0').PadRight(60) + (items.All(item => item.state) ? "RDY" : "PREP") + Environment.NewLine);
                txtOrders.SelectionFont = new Font(txtOrders.Font, FontStyle.Regular);
                uint itemIndex = default;
                foreach (var item in items)
                {
                    txtOrders.AppendText("- " + item.item.name.PadRight(30) + (item.state ? "RDY" : "PREP") + Environment.NewLine);
                    if (!item.state)
                    {
                        var cb = item.item.category switch
                        {
                            Kebus.MENU_ITEM_CATEGORY.FRIES => (cbF, _fIndices),
                            Kebus.MENU_ITEM_CATEGORY.KEBABS => (cbK, _kIndices),
                            Kebus.MENU_ITEM_CATEGORY.DESSERTS_AND_DRINKS => (cbD, _dIndices),
                            _ => (null, null)
                        };

                        cb.Item1?.Items.Add($"{id.Split('|')[0].PadLeft(3, '0')}:{item.item.id}   {item.item.name}");
                        cb.Item2!.Add(itemIndex++);
                    }
                }
                txtOrders.SelectionFont = new Font(txtOrders.Font, FontStyle.Italic);
                txtOrders.AppendText("Do zapłaty: " + Math.Round(items.Select(i => i.item.cost).Sum(), 2).ToString() + "zł" + Environment.NewLine);

                if (items.All(item => item.state))
                {
                    cbRdy.Items.Add(id.Split('|')[0].PadLeft(3, '0'));
                }
            }
        }

        private void UpdateOrder(object sender, EventArgs e)
        {
            var cb = ((Control)sender).Name switch
            {
                "btnF" => (cbF, _fIndices),
                "btnK" => (cbK, _kIndices),
                "btnD" => (cbD, _dIndices),
                _ => (null, null)
            };

            if (cb.Item1 == null)
                return;

            Kebus.UpdateOrderItemState(uint.Parse(cb.Item1.SelectedItem?.ToString()?.Split(':')[0] ?? ""),
                                       cb.Item2![cb.Item1.SelectedIndex]);
        }

        private void ReadyOrder(object sender, EventArgs e)
        {
            Kebus.ArchiviseOrder(uint.Parse(cbRdy.SelectedItem.ToString()!));
        }
    }
}
