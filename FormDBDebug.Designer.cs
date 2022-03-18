namespace Kebus
{
    partial class FormDBDebug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenuAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMenuCategory = new System.Windows.Forms.TextBox();
            this.txtMenuCost = new System.Windows.Forms.TextBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Location = new System.Drawing.Point(45, 112);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(103, 23);
            this.btnMenuAdd.TabIndex = 0;
            this.btnMenuAdd.Text = "Dodaj";
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.AddMenuItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMenuCategory);
            this.groupBox1.Controls.Add(this.txtMenuCost);
            this.groupBox1.Controls.Add(this.txtMenuName);
            this.groupBox1.Controls.Add(this.btnMenuAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj do menu";
            // 
            // txtMenuCategory
            // 
            this.txtMenuCategory.Location = new System.Drawing.Point(45, 80);
            this.txtMenuCategory.Name = "txtMenuCategory";
            this.txtMenuCategory.Size = new System.Drawing.Size(100, 23);
            this.txtMenuCategory.TabIndex = 3;
            // 
            // txtMenuCost
            // 
            this.txtMenuCost.Location = new System.Drawing.Point(45, 51);
            this.txtMenuCost.Name = "txtMenuCost";
            this.txtMenuCost.Size = new System.Drawing.Size(100, 23);
            this.txtMenuCost.TabIndex = 3;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(45, 22);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(100, 23);
            this.txtMenuName.TabIndex = 2;
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(218, 22);
            this.txtMenu.Multiline = true;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.ReadOnly = true;
            this.txtMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMenu.Size = new System.Drawing.Size(313, 131);
            this.txtMenu.TabIndex = 2;
            // 
            // FormDBDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDBDebug";
            this.Text = "FormDBDebug";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMenuAdd;
        private GroupBox groupBox1;
        private TextBox txtMenuName;
        private TextBox txtMenuCost;
        private TextBox txtMenuCategory;
        private TextBox txtMenu;
    }
}