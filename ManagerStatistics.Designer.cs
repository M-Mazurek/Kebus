namespace Kebus {
    partial class ManagerStatistics {
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
            this.DailyStats = new System.Windows.Forms.Panel();
            this.MonthlyStats = new System.Windows.Forms.Panel();
            this.YesterdayText = new MaterialSkin.Controls.MaterialLabel();
            this.TodayText = new MaterialSkin.Controls.MaterialLabel();
            this.DailyText = new MaterialSkin.Controls.MaterialLabel();
            this.YesterdayScore = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.ContentPanel.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.DailyStats.SuspendLayout();
            this.MonthlyStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.MonthlyStats);
            this.ContentPanel.Controls.Add(this.DailyStats);
            this.ContentPanel.Controls.Add(this.TitleBar);
            this.ContentPanel.Location = new System.Drawing.Point(6, 67);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(933, 627);
            this.ContentPanel.TabIndex = 1;
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
            this.TitleBar.Size = new System.Drawing.Size(311, 41);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Text = "Statystyki sprzedaży";
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
            this.Sidebar.TabIndex = 2;
            // 
            // CreateRaportButton
            // 
            this.CreateRaportButton.AutoSize = false;
            this.CreateRaportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateRaportButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateRaportButton.Depth = 0;
            this.CreateRaportButton.HighEmphasis = true;
            this.CreateRaportButton.Icon = null;
            this.CreateRaportButton.Location = new System.Drawing.Point(29, 561);
            this.CreateRaportButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateRaportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateRaportButton.Name = "CreateRaportButton";
            this.CreateRaportButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateRaportButton.Size = new System.Drawing.Size(190, 40);
            this.CreateRaportButton.TabIndex = 7;
            this.CreateRaportButton.Text = "Utwórz raport";
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
            this.ShowStatisticsButton.Text = "Cofnij";
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
            // DailyStats
            // 
            this.DailyStats.Controls.Add(this.materialLabel2);
            this.DailyStats.Controls.Add(this.materialLabel1);
            this.DailyStats.Controls.Add(this.YesterdayScore);
            this.DailyStats.Controls.Add(this.DailyText);
            this.DailyStats.Controls.Add(this.TodayText);
            this.DailyStats.Controls.Add(this.YesterdayText);
            this.DailyStats.Location = new System.Drawing.Point(19, 68);
            this.DailyStats.Name = "DailyStats";
            this.DailyStats.Size = new System.Drawing.Size(877, 182);
            this.DailyStats.TabIndex = 1;
            // 
            // MonthlyStats
            // 
            this.MonthlyStats.Controls.Add(this.materialLabel3);
            this.MonthlyStats.Controls.Add(this.materialLabel4);
            this.MonthlyStats.Controls.Add(this.materialLabel5);
            this.MonthlyStats.Controls.Add(this.materialLabel6);
            this.MonthlyStats.Controls.Add(this.materialLabel7);
            this.MonthlyStats.Controls.Add(this.materialLabel8);
            this.MonthlyStats.Location = new System.Drawing.Point(19, 256);
            this.MonthlyStats.Name = "MonthlyStats";
            this.MonthlyStats.Size = new System.Drawing.Size(877, 182);
            this.MonthlyStats.TabIndex = 2;
            // 
            // YesterdayText
            // 
            this.YesterdayText.AutoSize = true;
            this.YesterdayText.Depth = 0;
            this.YesterdayText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.YesterdayText.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.YesterdayText.Location = new System.Drawing.Point(95, 142);
            this.YesterdayText.MouseState = MaterialSkin.MouseState.HOVER;
            this.YesterdayText.Name = "YesterdayText";
            this.YesterdayText.Size = new System.Drawing.Size(43, 14);
            this.YesterdayText.TabIndex = 0;
            this.YesterdayText.Text = "wczoraj";
            // 
            // TodayText
            // 
            this.TodayText.AutoSize = true;
            this.TodayText.Depth = 0;
            this.TodayText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TodayText.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.TodayText.Location = new System.Drawing.Point(413, 142);
            this.TodayText.MouseState = MaterialSkin.MouseState.HOVER;
            this.TodayText.Name = "TodayText";
            this.TodayText.Size = new System.Drawing.Size(36, 14);
            this.TodayText.TabIndex = 1;
            this.TodayText.Text = "dzisiaj";
            // 
            // DailyText
            // 
            this.DailyText.AutoSize = true;
            this.DailyText.Depth = 0;
            this.DailyText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.DailyText.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.DailyText.Location = new System.Drawing.Point(683, 142);
            this.DailyText.MouseState = MaterialSkin.MouseState.HOVER;
            this.DailyText.Name = "DailyText";
            this.DailyText.Size = new System.Drawing.Size(83, 14);
            this.DailyText.TabIndex = 2;
            this.DailyText.Text = "norma dzienna";
            // 
            // YesterdayScore
            // 
            this.YesterdayScore.AutoSize = true;
            this.YesterdayScore.Depth = 0;
            this.YesterdayScore.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.YesterdayScore.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.YesterdayScore.Location = new System.Drawing.Point(62, 76);
            this.YesterdayScore.MouseState = MaterialSkin.MouseState.HOVER;
            this.YesterdayScore.Name = "YesterdayScore";
            this.YesterdayScore.Size = new System.Drawing.Size(108, 29);
            this.YesterdayScore.TabIndex = 3;
            this.YesterdayScore.Text = "1977,13 zł";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(378, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 29);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "2432,98 zł";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(671, 76);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 29);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "2000,00 zł";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(671, 84);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(121, 29);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "60000,00 zł";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(365, 84);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(121, 29);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "63032,98 zł";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel5.Location = new System.Drawing.Point(49, 84);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(121, 29);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "57777,13 zł";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel6.Location = new System.Drawing.Point(677, 150);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(102, 14);
            this.materialLabel6.TabIndex = 8;
            this.materialLabel6.Text = "norma miesiączna";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel7.Location = new System.Drawing.Point(398, 150);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(63, 14);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "ten miesiąc";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel8.Location = new System.Drawing.Point(74, 150);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(79, 14);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "zeszły miesiąc";
            // 
            // ManagerStatistics
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
            this.Name = "ManagerStatistics";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kebus System : Kierownik";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            this.DailyStats.ResumeLayout(false);
            this.DailyStats.PerformLayout();
            this.MonthlyStats.ResumeLayout(false);
            this.MonthlyStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ContentPanel;
        private MaterialSkin.Controls.MaterialLabel TitleBar;
        private Panel MonthlyStats;
        private Panel DailyStats;
        private MaterialSkin.Controls.MaterialLabel YesterdayText;
        private Panel Sidebar;
        private MaterialSkin.Controls.MaterialButton CreateRaportButton;
        private MaterialSkin.Controls.MaterialButton ShowMenuButton;
        private MaterialSkin.Controls.MaterialButton ShowStatisticsButton;
        private MaterialSkin.Controls.MaterialButton ShowOrdersButton;
        private MaterialSkin.Controls.MaterialLabel DailyText;
        private MaterialSkin.Controls.MaterialLabel TodayText;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel YesterdayScore;
    }
}