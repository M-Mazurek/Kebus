namespace Kebus {
    partial class Bagger {
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
            this.ContentScroll = new MaterialSkin.Controls.MaterialScrollBar();
            this.SuspendLayout();
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
            this.ContentScroll.TabIndex = 0;
            this.ContentScroll.Text = "materialScrollBar1";
            // 
            // Bagger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.ContentScroll);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Bagger";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kebus System : Stanowisko Pakowacza";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialScrollBar ContentScroll;
    }
}