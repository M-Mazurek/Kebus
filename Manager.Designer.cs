namespace Kebus {
    partial class Manager {
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
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.LastOrdersList = new MaterialSkin.Controls.MaterialListView();
            this.OrderId = new System.Windows.Forms.ColumnHeader();
            this.OrderedItems = new System.Windows.Forms.ColumnHeader();
            this.OrderDate = new System.Windows.Forms.ColumnHeader();
            this.OrderPrice = new System.Windows.Forms.ColumnHeader();
            this.OrdersHeadline = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ShowMenuButton = new MaterialSkin.Controls.MaterialButton();
            this.ShowStatisticsButton = new MaterialSkin.Controls.MaterialButton();
            this.ShowOrdersButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer.Location = new System.Drawing.Point(3, 64);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.ContentPanel);
            this.SplitContainer.Panel1MinSize = 950;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.ShowMenuButton);
            this.SplitContainer.Panel2.Controls.Add(this.ShowStatisticsButton);
            this.SplitContainer.Panel2.Controls.Add(this.ShowOrdersButton);
            this.SplitContainer.Size = new System.Drawing.Size(1194, 633);
            this.SplitContainer.SplitterDistance = 956;
            this.SplitContainer.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.LastOrdersList);
            this.ContentPanel.Controls.Add(this.OrdersHeadline);
            this.ContentPanel.Controls.Add(this.materialLabel1);
            this.ContentPanel.Location = new System.Drawing.Point(28, 30);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(900, 575);
            this.ContentPanel.TabIndex = 0;
            // 
            // LastOrdersList
            // 
            this.LastOrdersList.AutoSizeTable = false;
            this.LastOrdersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LastOrdersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastOrdersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderId,
            this.OrderedItems,
            this.OrderDate,
            this.OrderPrice});
            this.LastOrdersList.Depth = 0;
            this.LastOrdersList.FullRowSelect = true;
            this.LastOrdersList.Location = new System.Drawing.Point(18, 254);
            this.LastOrdersList.MinimumSize = new System.Drawing.Size(200, 100);
            this.LastOrdersList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LastOrdersList.MouseState = MaterialSkin.MouseState.OUT;
            this.LastOrdersList.Name = "LastOrdersList";
            this.LastOrdersList.OwnerDraw = true;
            this.LastOrdersList.Size = new System.Drawing.Size(860, 318);
            this.LastOrdersList.TabIndex = 2;
            this.LastOrdersList.UseCompatibleStateImageBehavior = false;
            this.LastOrdersList.View = System.Windows.Forms.View.Details;
            // 
            // OrderId
            // 
            this.OrderId.Text = "Numer zamówienia";
            this.OrderId.Width = 160;
            // 
            // OrderedItems
            // 
            this.OrderedItems.Text = "Zamówione pozycje";
            this.OrderedItems.Width = 380;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "Data zamówienia";
            this.OrderDate.Width = 160;
            // 
            // OrderPrice
            // 
            this.OrderPrice.Text = "Kwota Zamówienia";
            this.OrderPrice.Width = 160;
            // 
            // OrdersHeadline
            // 
            this.OrdersHeadline.Depth = 0;
            this.OrdersHeadline.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.OrdersHeadline.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.OrdersHeadline.Location = new System.Drawing.Point(18, 225);
            this.OrdersHeadline.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrdersHeadline.Name = "OrdersHeadline";
            this.OrdersHeadline.Size = new System.Drawing.Size(348, 26);
            this.OrdersHeadline.TabIndex = 1;
            this.OrdersHeadline.Text = "Ostatnio zrealizowane zamówienia";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(18, 123);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(588, 44);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Witaj, Kierowniku!";
            // 
            // ShowMenuButton
            // 
            this.ShowMenuButton.AutoSize = false;
            this.ShowMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowMenuButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ShowMenuButton.Depth = 0;
            this.ShowMenuButton.HighEmphasis = true;
            this.ShowMenuButton.Icon = null;
            this.ShowMenuButton.Location = new System.Drawing.Point(25, 172);
            this.ShowMenuButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowMenuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowMenuButton.Name = "ShowMenuButton";
            this.ShowMenuButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowMenuButton.Size = new System.Drawing.Size(190, 40);
            this.ShowMenuButton.TabIndex = 2;
            this.ShowMenuButton.Text = "Edycja Menu";
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
            this.ShowStatisticsButton.Location = new System.Drawing.Point(25, 101);
            this.ShowStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowStatisticsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowStatisticsButton.Name = "ShowStatisticsButton";
            this.ShowStatisticsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowStatisticsButton.Size = new System.Drawing.Size(190, 40);
            this.ShowStatisticsButton.TabIndex = 1;
            this.ShowStatisticsButton.Text = "Statystyki sprzedaży";
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
            this.ShowOrdersButton.Location = new System.Drawing.Point(25, 30);
            this.ShowOrdersButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowOrdersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowOrdersButton.Name = "ShowOrdersButton";
            this.ShowOrdersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowOrdersButton.Size = new System.Drawing.Size(190, 40);
            this.ShowOrdersButton.TabIndex = 0;
            this.ShowOrdersButton.Text = "Przejrzyj zamówienia";
            this.ShowOrdersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ShowOrdersButton.UseAccentColor = false;
            this.ShowOrdersButton.UseVisualStyleBackColor = true;
            this.ShowOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.SplitContainer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Manager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kebus System : Kierownik";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer SplitContainer;
        private Panel ContentPanel;
        private MaterialSkin.Controls.MaterialButton ShowMenuButton;
        private MaterialSkin.Controls.MaterialButton ShowStatisticsButton;
        private MaterialSkin.Controls.MaterialButton ShowOrdersButton;
        private MaterialSkin.Controls.MaterialListView LastOrdersList;
        private ColumnHeader OrderId;
        private ColumnHeader OrderedItems;
        private ColumnHeader OrderDate;
        private ColumnHeader OrderPrice;
        private MaterialSkin.Controls.MaterialLabel OrdersHeadline;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}