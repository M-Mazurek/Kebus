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
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.txtOrders = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnF = new System.Windows.Forms.Button();
            this.cbF = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnK = new System.Windows.Forms.Button();
            this.cbK = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnD = new System.Windows.Forms.Button();
            this.cbD = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox.SuspendLayout();
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
            // lbMenu
            // 
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 15;
            this.lbMenu.Location = new System.Drawing.Point(12, 159);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.ScrollAlwaysVisible = true;
            this.lbMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMenu.Size = new System.Drawing.Size(200, 229);
            this.lbMenu.TabIndex = 2;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(36, 394);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(145, 23);
            this.btnNewOrder.TabIndex = 3;
            this.btnNewOrder.Text = "Złóż zamówienie";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.CreateOrder);
            // 
            // txtOrders
            // 
            this.txtOrders.Location = new System.Drawing.Point(218, 19);
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.Size = new System.Drawing.Size(254, 398);
            this.txtOrders.TabIndex = 4;
            this.txtOrders.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnF);
            this.groupBox2.Controls.Add(this.cbF);
            this.groupBox2.Location = new System.Drawing.Point(478, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stanowisko - Frytki";
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(232, 22);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(72, 23);
            this.btnF.TabIndex = 6;
            this.btnF.Text = "Zatwierdź";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // cbF
            // 
            this.cbF.FormattingEnabled = true;
            this.cbF.Location = new System.Drawing.Point(6, 22);
            this.cbF.Name = "cbF";
            this.cbF.Size = new System.Drawing.Size(220, 23);
            this.cbF.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnK);
            this.groupBox3.Controls.Add(this.cbK);
            this.groupBox3.Location = new System.Drawing.Point(478, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 54);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stanowisko - Kebaby";
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(232, 22);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(72, 23);
            this.btnK.TabIndex = 6;
            this.btnK.Text = "Zatwierdź";
            this.btnK.UseVisualStyleBackColor = true;
            // 
            // cbK
            // 
            this.cbK.FormattingEnabled = true;
            this.cbK.Location = new System.Drawing.Point(6, 22);
            this.cbK.Name = "cbK";
            this.cbK.Size = new System.Drawing.Size(220, 23);
            this.cbK.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnD);
            this.groupBox.Controls.Add(this.cbD);
            this.groupBox.Location = new System.Drawing.Point(478, 139);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(310, 54);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Stanowisko - Napoje i desery";
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(232, 22);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(72, 23);
            this.btnD.TabIndex = 6;
            this.btnD.Text = "Zatwierdź";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // cbD
            // 
            this.cbD.FormattingEnabled = true;
            this.cbD.Location = new System.Drawing.Point(6, 22);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(220, 23);
            this.cbD.TabIndex = 0;
            // 
            // FormDBDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtOrders);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDBDebug";
            this.Text = "FormDBDebug";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMenuAdd;
        private GroupBox groupBox1;
        private TextBox txtMenuName;
        private TextBox txtMenuCost;
        private TextBox txtMenuCategory;
        private ListBox lbMenu;
        private Button btnNewOrder;
        private RichTextBox txtOrders;
        private GroupBox groupBox2;
        private Button btnF;
        private ComboBox cbF;
        private GroupBox groupBox3;
        private Button btnK;
        private ComboBox cbK;
        private GroupBox groupBox;
        private Button btnD;
        private ComboBox cbD;
    }
}