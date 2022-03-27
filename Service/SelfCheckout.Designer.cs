namespace Kebus {
    partial class SelfCheckout {
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
            this.DishesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.DishesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.KebabsPage = new System.Windows.Forms.TabPage();
            this.FriesPage = new System.Windows.Forms.TabPage();
            this.DrinksPage = new System.Windows.Forms.TabPage();
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.ShowOrderButton = new MaterialSkin.Controls.MaterialButton();
            this.TotalPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ConfirmOrderButton = new MaterialSkin.Controls.MaterialButton();
            this.DishesTabControl.SuspendLayout();
            this.PaymentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DishesTabSelector
            // 
            this.DishesTabSelector.BaseTabControl = this.DishesTabControl;
            this.DishesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.DishesTabSelector.Depth = 0;
            this.DishesTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.DishesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DishesTabSelector.Location = new System.Drawing.Point(3, 64);
            this.DishesTabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.DishesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.DishesTabSelector.Name = "DishesTabSelector";
            this.DishesTabSelector.Size = new System.Drawing.Size(844, 48);
            this.DishesTabSelector.TabIndex = 1;
            this.DishesTabSelector.TabIndicatorHeight = 1;
            this.DishesTabSelector.Text = "dishesTabSelector";
            // 
            // DishesTabControl
            // 
            this.DishesTabControl.Controls.Add(this.KebabsPage);
            this.DishesTabControl.Controls.Add(this.FriesPage);
            this.DishesTabControl.Controls.Add(this.DrinksPage);
            this.DishesTabControl.Depth = 0;
            this.DishesTabControl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DishesTabControl.Location = new System.Drawing.Point(3, 112);
            this.DishesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.DishesTabControl.Multiline = true;
            this.DishesTabControl.Name = "DishesTabControl";
            this.DishesTabControl.SelectedIndex = 0;
            this.DishesTabControl.Size = new System.Drawing.Size(844, 750);
            this.DishesTabControl.TabIndex = 2;
            // 
            // KebabsPage
            // 
            this.KebabsPage.AutoScroll = true;
            this.KebabsPage.CausesValidation = false;
            this.KebabsPage.Location = new System.Drawing.Point(4, 30);
            this.KebabsPage.Name = "KebabsPage";
            this.KebabsPage.Padding = new System.Windows.Forms.Padding(3);
            this.KebabsPage.Size = new System.Drawing.Size(836, 716);
            this.KebabsPage.TabIndex = 1;
            this.KebabsPage.Text = "KEBABY";
            this.KebabsPage.UseVisualStyleBackColor = true;
            // 
            // FriesPage
            // 
            this.FriesPage.Location = new System.Drawing.Point(4, 30);
            this.FriesPage.Name = "FriesPage";
            this.FriesPage.Size = new System.Drawing.Size(836, 716);
            this.FriesPage.TabIndex = 2;
            this.FriesPage.Text = "FRYTKI";
            this.FriesPage.UseVisualStyleBackColor = true;
            // 
            // DrinksPage
            // 
            this.DrinksPage.Location = new System.Drawing.Point(4, 30);
            this.DrinksPage.Name = "DrinksPage";
            this.DrinksPage.Size = new System.Drawing.Size(836, 716);
            this.DrinksPage.TabIndex = 3;
            this.DrinksPage.Text = "NAPOJE I DESERY";
            this.DrinksPage.UseVisualStyleBackColor = true;
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.Controls.Add(this.ShowOrderButton);
            this.PaymentPanel.Controls.Add(this.TotalPriceLabel);
            this.PaymentPanel.Controls.Add(this.ConfirmOrderButton);
            this.PaymentPanel.Location = new System.Drawing.Point(3, 868);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(840, 126);
            this.PaymentPanel.TabIndex = 3;
            // 
            // ShowOrderButton
            // 
            this.ShowOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowOrderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ShowOrderButton.Depth = 0;
            this.ShowOrderButton.HighEmphasis = true;
            this.ShowOrderButton.Icon = null;
            this.ShowOrderButton.Location = new System.Drawing.Point(17, 71);
            this.ShowOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowOrderButton.Name = "ShowOrderButton";
            this.ShowOrderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowOrderButton.Size = new System.Drawing.Size(195, 36);
            this.ShowOrderButton.TabIndex = 7;
            this.ShowOrderButton.Text = "Przejrzyj Zamówienie";
            this.ShowOrderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ShowOrderButton.UseAccentColor = false;
            this.ShowOrderButton.UseVisualStyleBackColor = true;
            this.ShowOrderButton.Click += new System.EventHandler(this.ShowOrderButton_Click);
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
            // SelfCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 1000);
            this.Controls.Add(this.PaymentPanel);
            this.Controls.Add(this.DishesTabControl);
            this.Controls.Add(this.DishesTabSelector);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 1000);
            this.Name = "SelfCheckout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kebus System : Kasa Samoobsługowa";
            this.Load += new System.EventHandler(this.SelfCheckout_Load);
            this.DishesTabControl.ResumeLayout(false);
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector DishesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl DishesTabControl;
        private TabPage KebabsPage;
        private TabPage FriesPage;
        private TabPage DrinksPage;
        private Panel PaymentPanel;
        private MaterialSkin.Controls.MaterialButton ShowOrderButton;
        private MaterialSkin.Controls.MaterialLabel TotalPriceLabel;
        private MaterialSkin.Controls.MaterialButton ConfirmOrderButton;
    }
}