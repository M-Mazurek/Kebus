namespace Kebus {
    partial class SelfCheckoutOrderView {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderList = new MaterialSkin.Controls.MaterialListView();
            this.DishCount = new System.Windows.Forms.ColumnHeader();
            this.DishName = new System.Windows.Forms.ColumnHeader();
            this.DishPrice = new System.Windows.Forms.ColumnHeader();
            this.OrderTitle = new MaterialSkin.Controls.MaterialLabel();
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.CloseOrderButton = new MaterialSkin.Controls.MaterialButton();
            this.TotalPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ConfirmOrderButton = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.PaymentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrderList);
            this.panel1.Controls.Add(this.OrderTitle);
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 795);
            this.panel1.TabIndex = 0;
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
            this.OrderList.Depth = 0;
            this.OrderList.FullRowSelect = true;
            this.OrderList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrderList.LabelWrap = false;
            this.OrderList.Location = new System.Drawing.Point(17, 72);
            this.OrderList.Margin = new System.Windows.Forms.Padding(0);
            this.OrderList.MinimumSize = new System.Drawing.Size(200, 100);
            this.OrderList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OrderList.MouseState = MaterialSkin.MouseState.OUT;
            this.OrderList.MultiSelect = false;
            this.OrderList.Name = "OrderList";
            this.OrderList.OwnerDraw = true;
            this.OrderList.Size = new System.Drawing.Size(810, 723);
            this.OrderList.TabIndex = 4;
            this.OrderList.TabStop = false;
            this.OrderList.UseCompatibleStateImageBehavior = false;
            this.OrderList.View = System.Windows.Forms.View.Details;
            // 
            // DishCount
            // 
            this.DishCount.Text = "ilość";
            this.DishCount.Width = 135;
            // 
            // DishName
            // 
            this.DishName.Text = "nazwa";
            this.DishName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DishName.Width = 560;
            // 
            // DishPrice
            // 
            this.DishPrice.Text = "cena";
            this.DishPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DishPrice.Width = 135;
            // 
            // OrderTitle
            // 
            this.OrderTitle.AutoSize = true;
            this.OrderTitle.Depth = 0;
            this.OrderTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrderTitle.Location = new System.Drawing.Point(358, 24);
            this.OrderTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrderTitle.Name = "OrderTitle";
            this.OrderTitle.Size = new System.Drawing.Size(118, 19);
            this.OrderTitle.TabIndex = 0;
            this.OrderTitle.Text = "Zamówienie { x }";
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.Controls.Add(this.CloseOrderButton);
            this.PaymentPanel.Controls.Add(this.TotalPriceLabel);
            this.PaymentPanel.Controls.Add(this.ConfirmOrderButton);
            this.PaymentPanel.Location = new System.Drawing.Point(6, 868);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(840, 126);
            this.PaymentPanel.TabIndex = 4;
            // 
            // CloseOrderButton
            // 
            this.CloseOrderButton.AutoSize = false;
            this.CloseOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseOrderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CloseOrderButton.Depth = 0;
            this.CloseOrderButton.HighEmphasis = true;
            this.CloseOrderButton.Icon = null;
            this.CloseOrderButton.Location = new System.Drawing.Point(17, 71);
            this.CloseOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseOrderButton.Name = "CloseOrderButton";
            this.CloseOrderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CloseOrderButton.Size = new System.Drawing.Size(195, 36);
            this.CloseOrderButton.TabIndex = 7;
            this.CloseOrderButton.Text = "Cofnij";
            this.CloseOrderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseOrderButton.UseAccentColor = false;
            this.CloseOrderButton.UseVisualStyleBackColor = true;
            this.CloseOrderButton.Click += new System.EventHandler(this.CloseOrderButton_Click);
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Depth = 0;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TotalPriceLabel.Location = new System.Drawing.Point(618, 33);
            this.TotalPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(98, 19);
            this.TotalPriceLabel.TabIndex = 6;
            this.TotalPriceLabel.Text = "Suma: 0.00 zł";
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmOrderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ConfirmOrderButton.Depth = 0;
            this.ConfirmOrderButton.HighEmphasis = true;
            this.ConfirmOrderButton.Icon = null;
            this.ConfirmOrderButton.Location = new System.Drawing.Point(618, 71);
            this.ConfirmOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConfirmOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ConfirmOrderButton.Size = new System.Drawing.Size(198, 36);
            this.ConfirmOrderButton.TabIndex = 5;
            this.ConfirmOrderButton.Text = "Potwierdź zamówienie";
            this.ConfirmOrderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ConfirmOrderButton.UseAccentColor = false;
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.ConfirmOrderButton_Click);
            // 
            // SelfCheckoutOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 1000);
            this.Controls.Add(this.PaymentPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 1000);
            this.Name = "SelfCheckoutOrderView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelfCheckoutOrderView";
            this.Load += new System.EventHandler(this.SelfCheckoutOrderView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel OrderTitle;
        private Panel PaymentPanel;
        private MaterialSkin.Controls.MaterialButton CloseOrderButton;
        private MaterialSkin.Controls.MaterialLabel TotalPriceLabel;
        private MaterialSkin.Controls.MaterialButton ConfirmOrderButton;
        private MaterialSkin.Controls.MaterialListView OrderList;
        private ColumnHeader DishCount;
        private ColumnHeader DishName;
        private ColumnHeader DishPrice;
    }
}