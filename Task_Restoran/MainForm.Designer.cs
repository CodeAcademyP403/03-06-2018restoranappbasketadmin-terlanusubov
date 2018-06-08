namespace Task_Restoran
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_count = new System.Windows.Forms.TextBox();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.cmbx_name = new System.Windows.Forms.ComboBox();
            this.cmbx_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_order = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.total_price = new System.Windows.Forms.Label();
            this.asda = new System.Windows.Forms.Label();
            this.list_name = new System.Windows.Forms.ListBox();
            this.list_count = new System.Windows.Forms.ListBox();
            this.list_price = new System.Windows.Forms.ListBox();
            this.list_total = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbx_count);
            this.panel1.Controls.Add(this.txbx_price);
            this.panel1.Controls.Add(this.cmbx_name);
            this.panel1.Controls.Add(this.cmbx_category);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 462);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(175, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "AZN";
            // 
            // txbx_count
            // 
            this.txbx_count.Location = new System.Drawing.Point(106, 203);
            this.txbx_count.Name = "txbx_count";
            this.txbx_count.Size = new System.Drawing.Size(121, 27);
            this.txbx_count.TabIndex = 23;
            // 
            // txbx_price
            // 
            this.txbx_price.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txbx_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbx_price.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_price.ForeColor = System.Drawing.Color.White;
            this.txbx_price.Location = new System.Drawing.Point(106, 258);
            this.txbx_price.Multiline = true;
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.ReadOnly = true;
            this.txbx_price.Size = new System.Drawing.Size(63, 29);
            this.txbx_price.TabIndex = 22;
            this.txbx_price.Text = "0";
            // 
            // cmbx_name
            // 
            this.cmbx_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_name.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbx_name.FormattingEnabled = true;
            this.cmbx_name.Location = new System.Drawing.Point(107, 143);
            this.cmbx_name.Name = "cmbx_name";
            this.cmbx_name.Size = new System.Drawing.Size(121, 29);
            this.cmbx_name.TabIndex = 20;
            this.cmbx_name.SelectedIndexChanged += new System.EventHandler(this.cmbx_name_SelectedIndexChanged);
            // 
            // cmbx_category
            // 
            this.cmbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_category.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbx_category.FormattingEnabled = true;
            this.cmbx_category.Location = new System.Drawing.Point(107, 93);
            this.cmbx_category.Name = "cmbx_category";
            this.cmbx_category.Size = new System.Drawing.Size(121, 29);
            this.cmbx_category.TabIndex = 19;
            this.cmbx_category.SelectedIndexChanged += new System.EventHandler(this.cmbx_category_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_order);
            this.panel4.Location = new System.Drawing.Point(3, 355);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 107);
            this.panel4.TabIndex = 3;
            // 
            // btn_order
            // 
            this.btn_order.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_order.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_order.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_order.Location = new System.Drawing.Point(-6, 5);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(244, 104);
            this.btn_order.TabIndex = 0;
            this.btn_order.Text = "ORDER";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.total_price);
            this.panel2.Controls.Add(this.asda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(244, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 107);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(230, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 30;
            this.label11.Tag = "";
            this.label11.Text = "AZN";
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total_price.Location = new System.Drawing.Point(168, 37);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(24, 25);
            this.total_price.TabIndex = 29;
            this.total_price.Text = "0";
            // 
            // asda
            // 
            this.asda.AutoSize = true;
            this.asda.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asda.Location = new System.Drawing.Point(20, 37);
            this.asda.Name = "asda";
            this.asda.Size = new System.Drawing.Size(142, 25);
            this.asda.TabIndex = 0;
            this.asda.Text = "TOTAL PRICE:";
            // 
            // list_name
            // 
            this.list_name.BackColor = System.Drawing.Color.DarkSlateGray;
            this.list_name.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_name.ForeColor = System.Drawing.Color.White;
            this.list_name.FormattingEnabled = true;
            this.list_name.ItemHeight = 21;
            this.list_name.Location = new System.Drawing.Point(244, 73);
            this.list_name.Name = "list_name";
            this.list_name.Size = new System.Drawing.Size(151, 277);
            this.list_name.TabIndex = 2;
            // 
            // list_count
            // 
            this.list_count.BackColor = System.Drawing.Color.DarkSlateGray;
            this.list_count.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_count.ForeColor = System.Drawing.Color.White;
            this.list_count.FormattingEnabled = true;
            this.list_count.ItemHeight = 21;
            this.list_count.Location = new System.Drawing.Point(401, 73);
            this.list_count.Name = "list_count";
            this.list_count.Size = new System.Drawing.Size(137, 277);
            this.list_count.TabIndex = 3;
            // 
            // list_price
            // 
            this.list_price.BackColor = System.Drawing.Color.DarkSlateGray;
            this.list_price.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_price.ForeColor = System.Drawing.Color.White;
            this.list_price.FormattingEnabled = true;
            this.list_price.ItemHeight = 21;
            this.list_price.Location = new System.Drawing.Point(544, 73);
            this.list_price.Name = "list_price";
            this.list_price.Size = new System.Drawing.Size(152, 277);
            this.list_price.TabIndex = 4;
            // 
            // list_total
            // 
            this.list_total.BackColor = System.Drawing.Color.DarkSlateGray;
            this.list_total.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_total.ForeColor = System.Drawing.Color.White;
            this.list_total.FormattingEnabled = true;
            this.list_total.ItemHeight = 21;
            this.list_total.Location = new System.Drawing.Point(702, 73);
            this.list_total.Name = "list_total";
            this.list_total.Size = new System.Drawing.Size(167, 277);
            this.list_total.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(243, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(401, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Count";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(540, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(698, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total Price";
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(381, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 104);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(869, 462);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.list_total);
            this.Controls.Add(this.list_price);
            this.Controls.Add(this.list_count);
            this.Controls.Add(this.list_name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_name;
        private System.Windows.Forms.ComboBox cmbx_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_count;
        private System.Windows.Forms.TextBox txbx_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox list_name;
        private System.Windows.Forms.ListBox list_count;
        private System.Windows.Forms.ListBox list_price;
        private System.Windows.Forms.ListBox list_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label total_price;
        private System.Windows.Forms.Label asda;
        private System.Windows.Forms.Button button1;
    }
}

