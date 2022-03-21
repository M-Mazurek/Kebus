namespace Kebus {
    partial class PositionSelector {
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
            this.PositionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.Confirm = new MaterialSkin.Controls.MaterialButton();
            this.Cancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.AutoResize = false;
            this.PositionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PositionComboBox.Depth = 0;
            this.PositionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PositionComboBox.DropDownHeight = 174;
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.DropDownWidth = 121;
            this.PositionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PositionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.IntegralHeight = false;
            this.PositionComboBox.ItemHeight = 43;
            this.PositionComboBox.Items.AddRange(new object[] {
            "Ekspedient",
            "Stanowisko Pakowacza",
            "Stanowisko Frytkarza",
            "Stanowisko Kebusiarza",
            "Stanowisko Napojów i Deserów",
            "Monitor Zamówień",
            "Kasa Samoobsługowa",
            "Kierownik"});
            this.PositionComboBox.Location = new System.Drawing.Point(145, 210);
            this.PositionComboBox.MaxDropDownItems = 4;
            this.PositionComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(489, 49);
            this.PositionComboBox.StartIndex = 0;
            this.PositionComboBox.TabIndex = 0;
            // 
            // Confirm
            // 
            this.Confirm.AutoSize = false;
            this.Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Confirm.Depth = 0;
            this.Confirm.HighEmphasis = true;
            this.Confirm.Icon = null;
            this.Confirm.Location = new System.Drawing.Point(444, 390);
            this.Confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.Confirm.Name = "Confirm";
            this.Confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Confirm.Size = new System.Drawing.Size(190, 40);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Potwierdź";
            this.Confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Confirm.UseAccentColor = false;
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = false;
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Cancel.Depth = 0;
            this.Cancel.HighEmphasis = true;
            this.Cancel.Icon = null;
            this.Cancel.Location = new System.Drawing.Point(145, 390);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancel.Name = "Cancel";
            this.Cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Cancel.Size = new System.Drawing.Size(190, 40);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Anuluj i Zamknij";
            this.Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Cancel.UseAccentColor = false;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // PositionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.PositionComboBox);
            this.Name = "PositionSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kebus System : Wybór Stanowiska";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox PositionComboBox;
        private MaterialSkin.Controls.MaterialButton Confirm;
        private MaterialSkin.Controls.MaterialButton Cancel;
    }
}