namespace Kebus {
    partial class CashierOrdersView {
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.ContentScroll = new MaterialSkin.Controls.MaterialScrollBar();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(495, 638);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(190, 40);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Cofnij";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ContentScroll
            // 
            this.ContentScroll.Depth = 0;
            this.ContentScroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContentScroll.Location = new System.Drawing.Point(3, 687);
            this.ContentScroll.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContentScroll.Name = "ContentScroll";
            this.ContentScroll.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Horizontal;
            this.ContentScroll.Size = new System.Drawing.Size(1194, 10);
            this.ContentScroll.SmallChange = 5;
            this.ContentScroll.TabIndex = 1;
            this.ContentScroll.Text = "materialScrollBar1";
            this.ContentScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ContentScroll_Scroll);
            // 
            // CashierOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.ContentScroll);
            this.Controls.Add(this.materialButton1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "CashierOrdersView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kebus System : Ekspedient";
            this.Load += new System.EventHandler(this.CashierOrdersView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialScrollBar ContentScroll;
    }
}