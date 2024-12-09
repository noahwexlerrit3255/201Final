namespace RitchiesFastFood_FinalProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            listBox2 = new ListBox();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label9 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label10 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter your name here.";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 2;
            label2.Text = "Select items for your order.";
            label2.Click += label2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(12, 113);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(520, 113);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 693);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(153, 104);
            listBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 670);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Items selected:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 800);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 820);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 7;
            label5.Text = "$0.00";
            // 
            // button1
            // 
            button1.Location = new Point(12, 850);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 8;
            button1.Text = "Checkout";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(379, 670);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(108, 20);
            label6.TabIndex = 9;
            label6.Text = "Your last order:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(379, 693);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(153, 104);
            listBox2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(379, 803);
            button2.Name = "button2";
            button2.Size = new Size(153, 29);
            button2.TabIndex = 11;
            button2.Text = "Add to current order";
            button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 82);
            label7.Name = "label7";
            label7.Size = new Size(56, 28);
            label7.TabIndex = 12;
            label7.Text = "Main";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(11, 229);
            label8.Name = "label8";
            label8.Size = new Size(58, 28);
            label8.TabIndex = 14;
            label8.Text = "Sides";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Location = new Point(11, 260);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(520, 113);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(11, 376);
            label9.Name = "label9";
            label9.Size = new Size(67, 28);
            label9.TabIndex = 16;
            label9.Text = "Drinks";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Location = new Point(11, 407);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(520, 113);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(11, 523);
            label10.Name = "label10";
            label10.Size = new Size(76, 28);
            label10.TabIndex = 18;
            label10.Text = "Dessert";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Location = new Point(11, 554);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(520, 113);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.GrayText;
            label11.Location = new Point(171, 9);
            label11.Name = "label11";
            label11.Size = new Size(327, 20);
            label11.TabIndex = 19;
            label11.Text = "(This will be used to save your order for next time)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 891);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(label9);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label8);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ritchie's Fast Food Online Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private ListBox listBox2;
        private Button button2;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label11;
    }
}
