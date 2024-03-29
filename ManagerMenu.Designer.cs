﻿namespace Kebus {
    partial class ManagerMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.MenuItemList = new MaterialSkin.Controls.MaterialListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.ItemCategory = new System.Windows.Forms.ColumnHeader();
            this.ItemPrice = new System.Windows.Forms.ColumnHeader();
            this.TitleBar = new MaterialSkin.Controls.MaterialLabel();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.AddDish = new MaterialSkin.Controls.MaterialButton();
            this.ShowMenuButton = new MaterialSkin.Controls.MaterialButton();
            this.ShowStatisticsButton = new MaterialSkin.Controls.MaterialButton();
            this.ShowOrdersButton = new MaterialSkin.Controls.MaterialButton();
            this.ContentPanel.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.MenuItemList);
            this.ContentPanel.Controls.Add(this.TitleBar);
            this.ContentPanel.Location = new System.Drawing.Point(6, 67);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(933, 627);
            this.ContentPanel.TabIndex = 2;
            // 
            // MenuItemList
            // 
            this.MenuItemList.AutoSizeTable = false;
            this.MenuItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MenuItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.ItemName,
            this.ItemCategory,
            this.ItemPrice});
            this.MenuItemList.Depth = 0;
            this.MenuItemList.FullRowSelect = true;
            this.MenuItemList.Location = new System.Drawing.Point(19, 64);
            this.MenuItemList.MinimumSize = new System.Drawing.Size(200, 100);
            this.MenuItemList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MenuItemList.MouseState = MaterialSkin.MouseState.OUT;
            this.MenuItemList.Name = "MenuItemList";
            this.MenuItemList.OwnerDraw = true;
            this.MenuItemList.Size = new System.Drawing.Size(867, 518);
            this.MenuItemList.TabIndex = 4;
            this.MenuItemList.UseCompatibleStateImageBehavior = false;
            this.MenuItemList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID pozycji";
            this.Id.Width = 160;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Nazwa pozycji";
            this.ItemName.Width = 380;
            // 
            // ItemCategory
            // 
            this.ItemCategory.Text = "Kategoria";
            this.ItemCategory.Width = 160;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Text = "Kwota";
            this.ItemPrice.Width = 160;
            // 
            // TitleBar
            // 
            this.TitleBar.AutoSize = true;
            this.TitleBar.Depth = 0;
            this.TitleBar.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TitleBar.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.TitleBar.Location = new System.Drawing.Point(19, 20);
            this.TitleBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(194, 41);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Text = "Edycja menu";
            // 
            // Sidebar
            // 
            this.Sidebar.Controls.Add(this.AddDish);
            this.Sidebar.Controls.Add(this.ShowMenuButton);
            this.Sidebar.Controls.Add(this.ShowStatisticsButton);
            this.Sidebar.Controls.Add(this.ShowOrdersButton);
            this.Sidebar.Location = new System.Drawing.Point(945, 67);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(249, 627);
            this.Sidebar.TabIndex = 3;
            // 
            // AddDish
            // 
            this.AddDish.AutoSize = false;
            this.AddDish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddDish.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddDish.Depth = 0;
            this.AddDish.HighEmphasis = true;
            this.AddDish.Icon = null;
            this.AddDish.Location = new System.Drawing.Point(29, 316);
            this.AddDish.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddDish.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddDish.Name = "AddDish";
            this.AddDish.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddDish.Size = new System.Drawing.Size(190, 40);
            this.AddDish.TabIndex = 8;
            this.AddDish.Text = "Dodaj pozycję";
            this.AddDish.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddDish.UseAccentColor = false;
            this.AddDish.UseVisualStyleBackColor = true;
            this.AddDish.Click += new System.EventHandler(this.AddDish_Click);
            // 
            // ShowMenuButton
            // 
            this.ShowMenuButton.AutoSize = false;
            this.ShowMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowMenuButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ShowMenuButton.Depth = 0;
            this.ShowMenuButton.HighEmphasis = true;
            this.ShowMenuButton.Icon = null;
            this.ShowMenuButton.Location = new System.Drawing.Point(29, 168);
            this.ShowMenuButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowMenuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowMenuButton.Name = "ShowMenuButton";
            this.ShowMenuButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowMenuButton.Size = new System.Drawing.Size(190, 40);
            this.ShowMenuButton.TabIndex = 6;
            this.ShowMenuButton.Text = "Cofnij";
            this.ShowMenuButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ShowMenuButton.UseAccentColor = false;
            this.ShowMenuButton.UseVisualStyleBackColor = true;
            this.ShowMenuButton.Click += new System.EventHandler(this.ShowMenuButton_Click);
            // 
            // ShowStatisticsButton
            // 
            this.ShowStatisticsButton.AutoSize = false;
            this.ShowStatisticsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowStatisticsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ShowStatisticsButton.Depth = 0;
            this.ShowStatisticsButton.HighEmphasis = true;
            this.ShowStatisticsButton.Icon = null;
            this.ShowStatisticsButton.Location = new System.Drawing.Point(29, 97);
            this.ShowStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowStatisticsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowStatisticsButton.Name = "ShowStatisticsButton";
            this.ShowStatisticsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowStatisticsButton.Size = new System.Drawing.Size(190, 40);
            this.ShowStatisticsButton.TabIndex = 5;
            this.ShowStatisticsButton.Text = "Statystki Sprzedaży";
            this.ShowStatisticsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ShowStatisticsButton.UseAccentColor = false;
            this.ShowStatisticsButton.UseVisualStyleBackColor = true;
            this.ShowStatisticsButton.Click += new System.EventHandler(this.ShowStatisticsButton_Click);
            // 
            // ShowOrdersButton
            // 
            this.ShowOrdersButton.AutoSize = false;
            this.ShowOrdersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowOrdersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ShowOrdersButton.Depth = 0;
            this.ShowOrdersButton.HighEmphasis = true;
            this.ShowOrdersButton.Icon = null;
            this.ShowOrdersButton.Location = new System.Drawing.Point(29, 26);
            this.ShowOrdersButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowOrdersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowOrdersButton.Name = "ShowOrdersButton";
            this.ShowOrdersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowOrdersButton.Size = new System.Drawing.Size(190, 40);
            this.ShowOrdersButton.TabIndex = 4;
            this.ShowOrdersButton.Text = "Przejrzyj zamówienia";
            this.ShowOrdersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ShowOrdersButton.UseAccentColor = false;
            this.ShowOrdersButton.UseVisualStyleBackColor = true;
            this.ShowOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.ContentPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "ManagerMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kebus System : Kierownik";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ContentPanel;
        private MaterialSkin.Controls.MaterialLabel TitleBar;
        private Panel Sidebar;
        private MaterialSkin.Controls.MaterialButton AddDish;
        private MaterialSkin.Controls.MaterialButton ShowMenuButton;
        private MaterialSkin.Controls.MaterialButton ShowStatisticsButton;
        private MaterialSkin.Controls.MaterialButton ShowOrdersButton;
        private MaterialSkin.Controls.MaterialListView MenuItemList;
        private ColumnHeader Id;
        private ColumnHeader ItemName;
        private ColumnHeader ItemCategory;
        private ColumnHeader ItemPrice;
    }
}