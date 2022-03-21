namespace Kebus {
    partial class ManagerRaport {
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
            this.TitleBar = new MaterialSkin.Controls.MaterialLabel();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.CreateRaportButton = new MaterialSkin.Controls.MaterialButton();
            this.ShowMenuButton = new MaterialSkin.Controls.MaterialButton();
            this.ShowStatisticsButton = new MaterialSkin.Controls.MaterialButton();
            this.ShowOrdersButton = new MaterialSkin.Controls.MaterialButton();
            this.CreateRaport = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ContentPanel.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.materialLabel1);
            this.ContentPanel.Controls.Add(this.CreateRaport);
            this.ContentPanel.Controls.Add(this.materialTextBox1);
            this.ContentPanel.Controls.Add(this.TitleBar);
            this.ContentPanel.Location = new System.Drawing.Point(6, 67);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(933, 627);
            this.ContentPanel.TabIndex = 3;
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
            this.TitleBar.Size = new System.Drawing.Size(277, 41);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Text = "Tworzenie raportu";
            // 
            // Sidebar
            // 
            this.Sidebar.Controls.Add(this.CreateRaportButton);
            this.Sidebar.Controls.Add(this.ShowMenuButton);
            this.Sidebar.Controls.Add(this.ShowStatisticsButton);
            this.Sidebar.Controls.Add(this.ShowOrdersButton);
            this.Sidebar.Location = new System.Drawing.Point(945, 67);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(249, 627);
            this.Sidebar.TabIndex = 5;
            // 
            // CreateRaportButton
            // 
            this.CreateRaportButton.AutoSize = false;
            this.CreateRaportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateRaportButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateRaportButton.Depth = 0;
            this.CreateRaportButton.HighEmphasis = true;
            this.CreateRaportButton.Icon = null;
            this.CreateRaportButton.Location = new System.Drawing.Point(29, 569);
            this.CreateRaportButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateRaportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateRaportButton.Name = "CreateRaportButton";
            this.CreateRaportButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateRaportButton.Size = new System.Drawing.Size(190, 40);
            this.CreateRaportButton.TabIndex = 7;
            this.CreateRaportButton.Text = "Cofnij";
            this.CreateRaportButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateRaportButton.UseAccentColor = false;
            this.CreateRaportButton.UseVisualStyleBackColor = true;
            this.CreateRaportButton.Click += new System.EventHandler(this.CreateRaportButton_Click);
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
            this.ShowStatisticsButton.Location = new System.Drawing.Point(29, 97);
            this.ShowStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowStatisticsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowStatisticsButton.Name = "ShowStatisticsButton";
            this.ShowStatisticsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowStatisticsButton.Size = new System.Drawing.Size(190, 40);
            this.ShowStatisticsButton.TabIndex = 5;
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
            this.ShowOrdersButton.Location = new System.Drawing.Point(29, 26);
            this.ShowOrdersButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowOrdersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowOrdersButton.Name = "ShowOrdersButton";
            this.ShowOrdersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowOrdersButton.Size = new System.Drawing.Size(190, 40);
            this.ShowOrdersButton.TabIndex = 4;
            this.ShowOrdersButton.Text = "Przejrzyj Zamówienia";
            this.ShowOrdersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ShowOrdersButton.UseAccentColor = false;
            this.ShowOrdersButton.UseVisualStyleBackColor = true;
            this.ShowOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // CreateRaport
            // 
            this.CreateRaport.AutoSize = false;
            this.CreateRaport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateRaport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateRaport.Depth = 0;
            this.CreateRaport.HighEmphasis = true;
            this.CreateRaport.Icon = null;
            this.CreateRaport.Location = new System.Drawing.Point(707, 569);
            this.CreateRaport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateRaport.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateRaport.Name = "CreateRaport";
            this.CreateRaport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateRaport.Size = new System.Drawing.Size(190, 40);
            this.CreateRaport.TabIndex = 8;
            this.CreateRaport.Text = "Utwórz raport";
            this.CreateRaport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateRaport.UseAccentColor = false;
            this.CreateRaport.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Wprowadź nazwę raportu";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(18, 158);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(277, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(301, 158);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(349, 50);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Jeżeli nie zostanie wprowadzona żadna nazwa to\r\nraport otrzyma domyślną nazwę: da" +
    "ta-raport\r\n";
            this.materialLabel1.UseAccent = true;
            // 
            // ManagerRaport
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
            this.Name = "ManagerRaport";
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
        private MaterialSkin.Controls.MaterialButton CreateRaportButton;
        private MaterialSkin.Controls.MaterialButton ShowMenuButton;
        private MaterialSkin.Controls.MaterialButton ShowStatisticsButton;
        private MaterialSkin.Controls.MaterialButton ShowOrdersButton;
        private MaterialSkin.Controls.MaterialButton CreateRaport;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}