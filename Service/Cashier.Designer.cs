﻿namespace Kebus
{
    partial class Cashier
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.PanelsContainer = new System.Windows.Forms.SplitContainer();
            this.DishesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.SetsPage = new System.Windows.Forms.TabPage();
            this.TestDish = new MaterialSkin.Controls.MaterialButton();
            this.KebabsPage = new System.Windows.Forms.TabPage();
            this.FriesPage = new System.Windows.Forms.TabPage();
            this.DrinksPage = new System.Windows.Forms.TabPage();
            this.DessertsPage = new System.Windows.Forms.TabPage();
            this.DishesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.OrdersButton = new MaterialSkin.Controls.MaterialButton();
            this.TotalPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.OrderList = new MaterialSkin.Controls.MaterialListView();
            this.DishCount = new System.Windows.Forms.ColumnHeader();
            this.DishName = new System.Windows.Forms.ColumnHeader();
            this.DishPrice = new System.Windows.Forms.ColumnHeader();
            this.CancelOrderButton = new MaterialSkin.Controls.MaterialButton();
            this.ConfirmOrderButton = new MaterialSkin.Controls.MaterialButton();
            this.OrderTitle = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PanelsContainer)).BeginInit();
            this.PanelsContainer.Panel1.SuspendLayout();
            this.PanelsContainer.Panel2.SuspendLayout();
            this.PanelsContainer.SuspendLayout();
            this.DishesTabControl.SuspendLayout();
            this.SetsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelsContainer
            // 
            this.PanelsContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelsContainer.Location = new System.Drawing.Point(3, 64);
            this.PanelsContainer.Name = "PanelsContainer";
            // 
            // PanelsContainer.Panel1
            // 
            this.PanelsContainer.Panel1.Controls.Add(this.DishesTabControl);
            this.PanelsContainer.Panel1.Controls.Add(this.DishesTabSelector);
            // 
            // PanelsContainer.Panel2
            // 
            this.PanelsContainer.Panel2.Controls.Add(this.OrdersButton);
            this.PanelsContainer.Panel2.Controls.Add(this.TotalPriceLabel);
            this.PanelsContainer.Panel2.Controls.Add(this.OrderList);
            this.PanelsContainer.Panel2.Controls.Add(this.CancelOrderButton);
            this.PanelsContainer.Panel2.Controls.Add(this.ConfirmOrderButton);
            this.PanelsContainer.Panel2.Controls.Add(this.OrderTitle);
            this.PanelsContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelsContainer.Size = new System.Drawing.Size(1194, 633);
            this.PanelsContainer.SplitterDistance = 833;
            this.PanelsContainer.TabIndex = 0;
            // 
            // DishesTabControl
            // 
            this.DishesTabControl.Controls.Add(this.SetsPage);
            this.DishesTabControl.Controls.Add(this.KebabsPage);
            this.DishesTabControl.Controls.Add(this.FriesPage);
            this.DishesTabControl.Controls.Add(this.DrinksPage);
            this.DishesTabControl.Controls.Add(this.DessertsPage);
            this.DishesTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.DishesTabControl.Depth = 0;
            this.DishesTabControl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DishesTabControl.Location = new System.Drawing.Point(3, 54);
            this.DishesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.DishesTabControl.Multiline = true;
            this.DishesTabControl.Name = "DishesTabControl";
            this.DishesTabControl.SelectedIndex = 0;
            this.DishesTabControl.Size = new System.Drawing.Size(827, 576);
            this.DishesTabControl.TabIndex = 1;
            // 
            // SetsPage
            // 
            this.SetsPage.Controls.Add(this.TestDish);
            this.SetsPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.SetsPage.Location = new System.Drawing.Point(4, 30);
            this.SetsPage.Name = "SetsPage";
            this.SetsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SetsPage.Size = new System.Drawing.Size(819, 542);
            this.SetsPage.TabIndex = 0;
            this.SetsPage.Text = "ZESTAWY";
            this.SetsPage.UseVisualStyleBackColor = true;
            // 
            // TestDish
            // 
            this.TestDish.AutoSize = false;
            this.TestDish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TestDish.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.TestDish.Depth = 0;
            this.TestDish.HighEmphasis = true;
            this.TestDish.Icon = null;
            this.TestDish.Location = new System.Drawing.Point(25, 40);
            this.TestDish.Margin = new System.Windows.Forms.Padding(0);
            this.TestDish.MouseState = MaterialSkin.MouseState.HOVER;
            this.TestDish.Name = "TestDish";
            this.TestDish.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TestDish.Size = new System.Drawing.Size(200, 80);
            this.TestDish.TabIndex = 0;
            this.TestDish.Text = "hardcoded kebab";
            this.TestDish.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TestDish.UseAccentColor = false;
            this.TestDish.UseVisualStyleBackColor = true;
            this.TestDish.Click += new System.EventHandler(this.AddTestDish_Click);
            // 
            // KebabsPage
            // 
            this.KebabsPage.CausesValidation = false;
            this.KebabsPage.Location = new System.Drawing.Point(4, 30);
            this.KebabsPage.Name = "KebabsPage";
            this.KebabsPage.Padding = new System.Windows.Forms.Padding(3);
            this.KebabsPage.Size = new System.Drawing.Size(819, 542);
            this.KebabsPage.TabIndex = 1;
            this.KebabsPage.Text = "KEBABY";
            this.KebabsPage.UseVisualStyleBackColor = true;
            // 
            // FriesPage
            // 
            this.FriesPage.Location = new System.Drawing.Point(4, 30);
            this.FriesPage.Name = "FriesPage";
            this.FriesPage.Size = new System.Drawing.Size(819, 542);
            this.FriesPage.TabIndex = 2;
            this.FriesPage.Text = "FRYTKI";
            this.FriesPage.UseVisualStyleBackColor = true;
            // 
            // DrinksPage
            // 
            this.DrinksPage.Location = new System.Drawing.Point(4, 30);
            this.DrinksPage.Name = "DrinksPage";
            this.DrinksPage.Size = new System.Drawing.Size(819, 542);
            this.DrinksPage.TabIndex = 3;
            this.DrinksPage.Text = "NAPOJE";
            this.DrinksPage.UseVisualStyleBackColor = true;
            // 
            // DessertsPage
            // 
            this.DessertsPage.Location = new System.Drawing.Point(4, 30);
            this.DessertsPage.Name = "DessertsPage";
            this.DessertsPage.Size = new System.Drawing.Size(819, 542);
            this.DessertsPage.TabIndex = 4;
            this.DessertsPage.Text = "DESERY";
            this.DessertsPage.UseVisualStyleBackColor = true;
            // 
            // DishesTabSelector
            // 
            this.DishesTabSelector.BaseTabControl = this.DishesTabControl;
            this.DishesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.DishesTabSelector.Cursor = System.Windows.Forms.Cursors.Default;
            this.DishesTabSelector.Depth = 0;
            this.DishesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DishesTabSelector.Location = new System.Drawing.Point(-4, 0);
            this.DishesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.DishesTabSelector.Name = "DishesTabSelector";
            this.DishesTabSelector.Size = new System.Drawing.Size(834, 48);
            this.DishesTabSelector.TabIndex = 0;
            this.DishesTabSelector.Text = "dishesTabSelector";
            // 
            // OrdersButton
            // 
            this.OrdersButton.AutoSize = false;
            this.OrdersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OrdersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OrdersButton.Depth = 0;
            this.OrdersButton.HighEmphasis = true;
            this.OrdersButton.Icon = global::Kebus.Properties.Resources.clipboard;
            this.OrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdersButton.Image")));
            this.OrdersButton.Location = new System.Drawing.Point(8, 8);
            this.OrdersButton.Margin = new System.Windows.Forms.Padding(0);
            this.OrdersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OrdersButton.Size = new System.Drawing.Size(40, 40);
            this.OrdersButton.TabIndex = 5;
            this.OrdersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OrdersButton.UseAccentColor = false;
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Depth = 0;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TotalPriceLabel.Location = new System.Drawing.Point(208, 553);
            this.TotalPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(49, 19);
            this.TotalPriceLabel.TabIndex = 4;
            this.TotalPriceLabel.Text = "suma: ";
            // 
            // OrderList
            // 
            this.OrderList.AutoSizeTable = false;
            this.OrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DishCount,
            this.DishName,
            this.DishPrice});
            this.OrderList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OrderList.Depth = 0;
            this.OrderList.FullRowSelect = true;
            this.OrderList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrderList.LabelWrap = false;
            this.OrderList.Location = new System.Drawing.Point(8, 84);
            this.OrderList.Margin = new System.Windows.Forms.Padding(0);
            this.OrderList.MinimumSize = new System.Drawing.Size(200, 100);
            this.OrderList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OrderList.MouseState = MaterialSkin.MouseState.OUT;
            this.OrderList.MultiSelect = false;
            this.OrderList.Name = "OrderList";
            this.OrderList.OwnerDraw = true;
            this.OrderList.Size = new System.Drawing.Size(336, 452);
            this.OrderList.TabIndex = 3;
            this.OrderList.TabStop = false;
            this.OrderList.UseCompatibleStateImageBehavior = false;
            this.OrderList.View = System.Windows.Forms.View.Details;
            // 
            // DishCount
            // 
            this.DishCount.Text = "ilość";
            this.DishCount.Width = 56;
            // 
            // DishName
            // 
            this.DishName.Text = "nazwa";
            this.DishName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DishName.Width = 224;
            // 
            // DishPrice
            // 
            this.DishPrice.Text = "cena";
            this.DishPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DishPrice.Width = 56;
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.AutoSize = false;
            this.CancelOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelOrderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CancelOrderButton.Depth = 0;
            this.CancelOrderButton.HighEmphasis = true;
            this.CancelOrderButton.Icon = null;
            this.CancelOrderButton.Location = new System.Drawing.Point(8, 590);
            this.CancelOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CancelOrderButton.Size = new System.Drawing.Size(130, 36);
            this.CancelOrderButton.TabIndex = 2;
            this.CancelOrderButton.Text = "Anuluj";
            this.CancelOrderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelOrderButton.UseAccentColor = false;
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmOrderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ConfirmOrderButton.Depth = 0;
            this.ConfirmOrderButton.HighEmphasis = true;
            this.ConfirmOrderButton.Icon = null;
            this.ConfirmOrderButton.Location = new System.Drawing.Point(146, 590);
            this.ConfirmOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConfirmOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ConfirmOrderButton.Size = new System.Drawing.Size(198, 36);
            this.ConfirmOrderButton.TabIndex = 1;
            this.ConfirmOrderButton.Text = "Potwierdź zamówienie";
            this.ConfirmOrderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ConfirmOrderButton.UseAccentColor = false;
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.ConfirmOrder_Click);
            // 
            // OrderTitle
            // 
            this.OrderTitle.AutoSize = true;
            this.OrderTitle.Depth = 0;
            this.OrderTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrderTitle.Location = new System.Drawing.Point(119, 29);
            this.OrderTitle.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.OrderTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrderTitle.Name = "OrderTitle";
            this.OrderTitle.Size = new System.Drawing.Size(118, 19);
            this.OrderTitle.TabIndex = 0;
            this.OrderTitle.Text = "Zamówienie { x }";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.PanelsContainer);
            this.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kebus System : Ekspedient";
            this.PanelsContainer.Panel1.ResumeLayout(false);
            this.PanelsContainer.Panel2.ResumeLayout(false);
            this.PanelsContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelsContainer)).EndInit();
            this.PanelsContainer.ResumeLayout(false);
            this.DishesTabControl.ResumeLayout(false);
            this.SetsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer PanelsContainer;
        private MaterialSkin.Controls.MaterialTabSelector DishesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl DishesTabControl;
        private TabPage SetsPage;
        private TabPage KebabsPage;
        private TabPage FriesPage;
        private TabPage DrinksPage;
        private TabPage DessertsPage;
        private MaterialSkin.Controls.MaterialLabel OrderTitle;
        private MaterialSkin.Controls.MaterialButton CancelOrderButton;
        private MaterialSkin.Controls.MaterialButton ConfirmOrderButton;
        private MaterialSkin.Controls.MaterialListView OrderList;
        private ColumnHeader DishCount;
        private ColumnHeader DishName;
        private ColumnHeader DishPrice;
        private MaterialSkin.Controls.MaterialLabel TotalPriceLabel;
        private MaterialSkin.Controls.MaterialButton TestDish;
        private MaterialSkin.Controls.MaterialButton OrdersButton;
    }
}