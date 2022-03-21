namespace Kebus {
    partial class Cook {
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
            this.ContectScroll = new MaterialSkin.Controls.MaterialScrollBar();
            this.SuspendLayout();
            // 
            // ContectScroll
            // 
            this.ContectScroll.Depth = 0;
            this.ContectScroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContectScroll.Location = new System.Drawing.Point(3, 687);
            this.ContectScroll.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContectScroll.Name = "ContectScroll";
            this.ContectScroll.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Horizontal;
            this.ContectScroll.Size = new System.Drawing.Size(1194, 10);
            this.ContectScroll.TabIndex = 0;
            this.ContectScroll.Text = "ContentScroll";
            // 
            // OrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.ContectScroll);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "OrdersView";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kebus System : Stanowisko Frytkarza";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialScrollBar ContectScroll;
    }
}