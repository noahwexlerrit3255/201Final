﻿namespace RitchiesFastFood_FinalProj
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
            nameTextBox = new TextBox();
            selectItemLabel = new Label();
            mainTable = new TableLayoutPanel();
            mainitem4 = new Label();
            mainitem3 = new Label();
            mainitem2 = new Label();
            mainItem1 = new Label();
            itemsListBox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            totalIntLabel = new Label();
            checkoutButton = new Button();
            mainLabel = new Label();
            sidesLabel = new Label();
            sidesTable = new TableLayoutPanel();
            sideitem8 = new Label();
            sideitem7 = new Label();
            sideitem6 = new Label();
            sideitem5 = new Label();
            drinksLabel = new Label();
            drinksTable = new TableLayoutPanel();
            drinkItem12 = new Label();
            drinkItem11 = new Label();
            drinkItem10 = new Label();
            drinkItem9 = new Label();
            dessertLabel = new Label();
            dessertTable = new TableLayoutPanel();
            dessertItem16 = new Label();
            dessertItem15 = new Label();
            dessertItem14 = new Label();
            dessertItem13 = new Label();
            label11 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            mainTable.SuspendLayout();
            sidesTable.SuspendLayout();
            drinksTable.SuspendLayout();
            dessertTable.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(449, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter your username and password here.";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(94, 122);
            nameTextBox.Margin = new Padding(5, 5, 5, 5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(202, 39);
            nameTextBox.TabIndex = 1;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // selectItemLabel
            // 
            selectItemLabel.AutoSize = true;
            selectItemLabel.Location = new Point(94, 219);
            selectItemLabel.Margin = new Padding(5, 0, 5, 0);
            selectItemLabel.Name = "selectItemLabel";
            selectItemLabel.Size = new Size(304, 32);
            selectItemLabel.TabIndex = 2;
            selectItemLabel.Text = "Select items for your order.";
            selectItemLabel.Click += label2_Click;
            // 
            // mainTable
            // 
            mainTable.BackColor = Color.White;
            mainTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            mainTable.ColumnCount = 4;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTable.Controls.Add(mainitem4, 3, 0);
            mainTable.Controls.Add(mainitem3, 2, 0);
            mainTable.Controls.Add(mainitem2, 1, 0);
            mainTable.Controls.Add(mainItem1, 0, 0);
            mainTable.Location = new Point(94, 300);
            mainTable.Margin = new Padding(5, 5, 5, 5);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 1;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.Size = new Size(848, 179);
            mainTable.TabIndex = 3;
            mainTable.Paint += mainTable_Paint;
            // 
            // mainitem4
            // 
            mainitem4.AutoSize = true;
            mainitem4.Dock = DockStyle.Fill;
            mainitem4.Location = new Point(640, 2);
            mainitem4.Margin = new Padding(5, 0, 5, 0);
            mainitem4.Name = "mainitem4";
            mainitem4.Size = new Size(201, 175);
            mainitem4.TabIndex = 3;
            mainitem4.Text = "Taco - $9.99";
            mainitem4.TextAlign = ContentAlignment.MiddleCenter;
            mainitem4.Click += label2_Click_1;
            // 
            // mainitem3
            // 
            mainitem3.AutoSize = true;
            mainitem3.Dock = DockStyle.Fill;
            mainitem3.Location = new Point(429, 2);
            mainitem3.Margin = new Padding(5, 0, 5, 0);
            mainitem3.Name = "mainitem3";
            mainitem3.Size = new Size(199, 175);
            mainitem3.TabIndex = 2;
            mainitem3.Text = "Hot Dog - $4.99";
            mainitem3.TextAlign = ContentAlignment.MiddleCenter;
            mainitem3.Click += label2_Click_1;
            // 
            // mainitem2
            // 
            mainitem2.AutoSize = true;
            mainitem2.Dock = DockStyle.Fill;
            mainitem2.Location = new Point(218, 2);
            mainitem2.Margin = new Padding(5, 0, 5, 0);
            mainitem2.Name = "mainitem2";
            mainitem2.Size = new Size(199, 175);
            mainitem2.TabIndex = 1;
            mainitem2.Text = "Burger - $13.99";
            mainitem2.TextAlign = ContentAlignment.MiddleCenter;
            mainitem2.Click += label2_Click_1;
            // 
            // mainItem1
            // 
            mainItem1.AutoSize = true;
            mainItem1.Dock = DockStyle.Fill;
            mainItem1.Location = new Point(7, 2);
            mainItem1.Margin = new Padding(5, 0, 5, 0);
            mainItem1.Name = "mainItem1";
            mainItem1.Size = new Size(199, 175);
            mainItem1.TabIndex = 0;
            mainItem1.Text = "Pizza Slice - $10.99";
            mainItem1.TextAlign = ContentAlignment.MiddleCenter;
            mainItem1.Click += label2_Click_1;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(694, 1056);
            itemsListBox.Margin = new Padding(5, 5, 5, 5);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(485, 164);
            itemsListBox.TabIndex = 4;
            itemsListBox.Click += itemsListBox_SelectedIndexChanged;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(792, 1003);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(172, 32);
            label3.TabIndex = 5;
            label3.Text = "Items selected:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(705, 1245);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            // 
            // totalIntLabel
            // 
            totalIntLabel.AutoSize = true;
            totalIntLabel.Font = new Font("Segoe UI", 12F);
            totalIntLabel.Location = new Point(1069, 1235);
            totalIntLabel.Margin = new Padding(5, 0, 5, 0);
            totalIntLabel.Name = "totalIntLabel";
            totalIntLabel.Size = new Size(95, 45);
            totalIntLabel.TabIndex = 7;
            totalIntLabel.Text = "$0.00";
          
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(809, 1316);
            checkoutButton.Margin = new Padding(5, 5, 5, 5);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(250, 46);
            checkoutButton.TabIndex = 8;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 12F);
            mainLabel.Location = new Point(94, 251);
            mainLabel.Margin = new Padding(5, 0, 5, 0);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(91, 45);
            mainLabel.TabIndex = 12;
            mainLabel.Text = "Main";
            // 
            // sidesLabel
            // 
            sidesLabel.AutoSize = true;
            sidesLabel.Font = new Font("Segoe UI", 12F);
            sidesLabel.Location = new Point(993, 252);
            sidesLabel.Margin = new Padding(5, 0, 5, 0);
            sidesLabel.Name = "sidesLabel";
            sidesLabel.Size = new Size(95, 45);
            sidesLabel.TabIndex = 14;
            sidesLabel.Text = "Sides";
            // 
            // sidesTable
            // 
            sidesTable.BackColor = Color.White;
            sidesTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            sidesTable.ColumnCount = 4;
            sidesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            sidesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            sidesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            sidesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            sidesTable.Controls.Add(sideitem8, 3, 0);
            sidesTable.Controls.Add(sideitem7, 2, 0);
            sidesTable.Controls.Add(sideitem6, 1, 0);
            sidesTable.Controls.Add(sideitem5, 0, 0);
            sidesTable.Location = new Point(993, 302);
            sidesTable.Margin = new Padding(5, 5, 5, 5);
            sidesTable.Name = "sidesTable";
            sidesTable.RowCount = 1;
            sidesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sidesTable.Size = new Size(848, 179);
            sidesTable.TabIndex = 13;
            // 
            // sideitem8
            // 
            sideitem8.AutoSize = true;
            sideitem8.Dock = DockStyle.Fill;
            sideitem8.Location = new Point(640, 2);
            sideitem8.Margin = new Padding(5, 0, 5, 0);
            sideitem8.Name = "sideitem8";
            sideitem8.Size = new Size(201, 175);
            sideitem8.TabIndex = 4;
            sideitem8.Text = "Chips - $3.99";
            sideitem8.TextAlign = ContentAlignment.MiddleCenter;
            sideitem8.Click += label2_Click_1;
            // 
            // sideitem7
            // 
            sideitem7.AutoSize = true;
            sideitem7.Dock = DockStyle.Fill;
            sideitem7.Location = new Point(429, 2);
            sideitem7.Margin = new Padding(5, 0, 5, 0);
            sideitem7.Name = "sideitem7";
            sideitem7.Size = new Size(199, 175);
            sideitem7.TabIndex = 3;
            sideitem7.Text = "French Fries - $3.99";
            sideitem7.TextAlign = ContentAlignment.MiddleCenter;
            sideitem7.Click += label2_Click_1;
            // 
            // sideitem6
            // 
            sideitem6.AutoSize = true;
            sideitem6.Dock = DockStyle.Fill;
            sideitem6.Location = new Point(218, 2);
            sideitem6.Margin = new Padding(5, 0, 5, 0);
            sideitem6.Name = "sideitem6";
            sideitem6.Size = new Size(199, 175);
            sideitem6.TabIndex = 2;
            sideitem6.Text = "Salad - $4.99";
            sideitem6.TextAlign = ContentAlignment.MiddleCenter;
            sideitem6.Click += label2_Click_1;
            // 
            // sideitem5
            // 
            sideitem5.AutoSize = true;
            sideitem5.Dock = DockStyle.Fill;
            sideitem5.Location = new Point(7, 2);
            sideitem5.Margin = new Padding(5, 0, 5, 0);
            sideitem5.Name = "sideitem5";
            sideitem5.Size = new Size(199, 175);
            sideitem5.TabIndex = 1;
            sideitem5.Text = "Mozzarella Sticks - $6.99";
            sideitem5.TextAlign = ContentAlignment.MiddleCenter;
            sideitem5.Click += label2_Click_1;
            // 
            // drinksLabel
            // 
            drinksLabel.AutoSize = true;
            drinksLabel.Font = new Font("Segoe UI", 12F);
            drinksLabel.Location = new Point(94, 722);
            drinksLabel.Margin = new Padding(5, 0, 5, 0);
            drinksLabel.Name = "drinksLabel";
            drinksLabel.Size = new Size(109, 45);
            drinksLabel.TabIndex = 16;
            drinksLabel.Text = "Drinks";
            // 
            // drinksTable
            // 
            drinksTable.BackColor = Color.White;
            drinksTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            drinksTable.ColumnCount = 4;
            drinksTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            drinksTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            drinksTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            drinksTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            drinksTable.Controls.Add(drinkItem12, 3, 0);
            drinksTable.Controls.Add(drinkItem11, 2, 0);
            drinksTable.Controls.Add(drinkItem10, 1, 0);
            drinksTable.Controls.Add(drinkItem9, 0, 0);
            drinksTable.Location = new Point(94, 773);
            drinksTable.Margin = new Padding(5, 5, 5, 5);
            drinksTable.Name = "drinksTable";
            drinksTable.RowCount = 1;
            drinksTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            drinksTable.Size = new Size(848, 179);
            drinksTable.TabIndex = 15;
            // 
            // drinkItem12
            // 
            drinkItem12.AutoSize = true;
            drinkItem12.Dock = DockStyle.Fill;
            drinkItem12.Location = new Point(640, 2);
            drinkItem12.Margin = new Padding(5, 0, 5, 0);
            drinkItem12.Name = "drinkItem12";
            drinkItem12.Size = new Size(201, 175);
            drinkItem12.TabIndex = 6;
            drinkItem12.Text = "Water - FREE";
            drinkItem12.TextAlign = ContentAlignment.MiddleCenter;
            drinkItem12.Click += label2_Click_1;
            // 
            // drinkItem11
            // 
            drinkItem11.AutoSize = true;
            drinkItem11.Dock = DockStyle.Fill;
            drinkItem11.Location = new Point(429, 2);
            drinkItem11.Margin = new Padding(5, 0, 5, 0);
            drinkItem11.Name = "drinkItem11";
            drinkItem11.Size = new Size(199, 175);
            drinkItem11.TabIndex = 5;
            drinkItem11.Text = "Iced Tea - $3.49";
            drinkItem11.TextAlign = ContentAlignment.MiddleCenter;
            drinkItem11.Click += label2_Click_1;
            // 
            // drinkItem10
            // 
            drinkItem10.AutoSize = true;
            drinkItem10.Dock = DockStyle.Fill;
            drinkItem10.Location = new Point(218, 2);
            drinkItem10.Margin = new Padding(5, 0, 5, 0);
            drinkItem10.Name = "drinkItem10";
            drinkItem10.Size = new Size(199, 175);
            drinkItem10.TabIndex = 4;
            drinkItem10.Text = "Coke - $2.99";
            drinkItem10.TextAlign = ContentAlignment.MiddleCenter;
            drinkItem10.Click += label2_Click_1;
            // 
            // drinkItem9
            // 
            drinkItem9.AutoSize = true;
            drinkItem9.Dock = DockStyle.Fill;
            drinkItem9.Location = new Point(7, 2);
            drinkItem9.Margin = new Padding(5, 0, 5, 0);
            drinkItem9.Name = "drinkItem9";
            drinkItem9.Size = new Size(199, 175);
            drinkItem9.TabIndex = 3;
            drinkItem9.Text = "Pepsi - $2.99";
            drinkItem9.TextAlign = ContentAlignment.MiddleCenter;
            drinkItem9.Click += label2_Click_1;
            // 
            // dessertLabel
            // 
            dessertLabel.AutoSize = true;
            dessertLabel.Font = new Font("Segoe UI", 12F);
            dessertLabel.Location = new Point(993, 722);
            dessertLabel.Margin = new Padding(5, 0, 5, 0);
            dessertLabel.Name = "dessertLabel";
            dessertLabel.Size = new Size(126, 45);
            dessertLabel.TabIndex = 18;
            dessertLabel.Text = "Dessert";
            // 
            // dessertTable
            // 
            dessertTable.BackColor = Color.White;
            dessertTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            dessertTable.ColumnCount = 4;
            dessertTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dessertTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dessertTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dessertTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            dessertTable.Controls.Add(dessertItem16, 3, 0);
            dessertTable.Controls.Add(dessertItem15, 2, 0);
            dessertTable.Controls.Add(dessertItem14, 1, 0);
            dessertTable.Controls.Add(dessertItem13, 0, 0);
            dessertTable.Location = new Point(993, 771);
            dessertTable.Margin = new Padding(5, 5, 5, 5);
            dessertTable.Name = "dessertTable";
            dessertTable.RowCount = 1;
            dessertTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dessertTable.Size = new Size(848, 179);
            dessertTable.TabIndex = 17;
            // 
            // dessertItem16
            // 
            dessertItem16.AutoSize = true;
            dessertItem16.Dock = DockStyle.Fill;
            dessertItem16.Location = new Point(640, 2);
            dessertItem16.Margin = new Padding(5, 0, 5, 0);
            dessertItem16.Name = "dessertItem16";
            dessertItem16.Size = new Size(201, 175);
            dessertItem16.TabIndex = 7;
            dessertItem16.Text = "Fried Dough - $7.99";
            dessertItem16.TextAlign = ContentAlignment.MiddleCenter;
            dessertItem16.Click += label2_Click_1;
            // 
            // dessertItem15
            // 
            dessertItem15.AutoSize = true;
            dessertItem15.Dock = DockStyle.Fill;
            dessertItem15.Location = new Point(429, 2);
            dessertItem15.Margin = new Padding(5, 0, 5, 0);
            dessertItem15.Name = "dessertItem15";
            dessertItem15.Size = new Size(199, 175);
            dessertItem15.TabIndex = 6;
            dessertItem15.Text = "Cookie - $3.99";
            dessertItem15.TextAlign = ContentAlignment.MiddleCenter;
            dessertItem15.Click += label2_Click_1;
            // 
            // dessertItem14
            // 
            dessertItem14.AutoSize = true;
            dessertItem14.Dock = DockStyle.Fill;
            dessertItem14.Location = new Point(218, 2);
            dessertItem14.Margin = new Padding(5, 0, 5, 0);
            dessertItem14.Name = "dessertItem14";
            dessertItem14.Size = new Size(199, 175);
            dessertItem14.TabIndex = 5;
            dessertItem14.Text = "Soft Serve Ice Cream - $4.49";
            dessertItem14.TextAlign = ContentAlignment.MiddleCenter;
            dessertItem14.Click += label2_Click_1;
            // 
            // dessertItem13
            // 
            dessertItem13.AutoSize = true;
            dessertItem13.Dock = DockStyle.Fill;
            dessertItem13.Location = new Point(7, 2);
            dessertItem13.Margin = new Padding(5, 0, 5, 0);
            dessertItem13.Name = "dessertItem13";
            dessertItem13.Size = new Size(199, 175);
            dessertItem13.TabIndex = 4;
            dessertItem13.Text = "Apple Pie - $6.99";
            dessertItem13.TextAlign = ContentAlignment.MiddleCenter;
            dessertItem13.Click += label2_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.GrayText;
            label11.Location = new Point(94, 46);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(535, 32);
            label11.TabIndex = 19;
            label11.Text = "(This will be used to save your order for next time)";
            label11.Click += label11_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 84);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 20;
            label2.Text = "Username:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 122);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 39);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 84);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 22;
            label5.Text = "Password:";
            // 
            // button1
            // 
            button1.Location = new Point(94, 168);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 23;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(369, 168);
            button2.Name = "button2";
            button2.Size = new Size(136, 47);
            button2.TabIndex = 24;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1862, 1531);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(dessertLabel);
            Controls.Add(dessertTable);
            Controls.Add(drinksLabel);
            Controls.Add(drinksTable);
            Controls.Add(sidesLabel);
            Controls.Add(sidesTable);
            Controls.Add(mainLabel);
            Controls.Add(checkoutButton);
            Controls.Add(totalIntLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(itemsListBox);
            Controls.Add(mainTable);
            Controls.Add(selectItemLabel);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Ritchie's Fast Food Online Menu";
            mainTable.ResumeLayout(false);
            mainTable.PerformLayout();
            sidesTable.ResumeLayout(false);
            sidesTable.PerformLayout();
            drinksTable.ResumeLayout(false);
            drinksTable.PerformLayout();
            dessertTable.ResumeLayout(false);
            dessertTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label selectItemLabel;
        private TableLayoutPanel mainTable;
        private ListBox itemsListBox;
        private Label label3;
        private Label label4;
        private Label totalIntLabel;
        private Button checkoutButton;
        private Label mainLabel;
        private Label sidesLabel;
        private TableLayoutPanel sidesTable;
        private Label drinksLabel;
        private TableLayoutPanel drinksTable;
        private Label dessertLabel;
        private TableLayoutPanel dessertTable;
        private Label label11;
        private Label mainitem4;
        private Label mainitem3;
        private Label mainitem2;
        private Label sideitem6;
        private Label sideitem8;
        private Label sideitem7;
        private Label drinkItem12;
        private Label drinkItem11;
        private Label drinkItem10;
        private Label dessertItem16;
        private Label dessertItem15;
        private Label dessertItem14;
        private Label sideitem5;
        private Label dessertItem13;
        private Label mainItem1;
        private Label drinkItem9;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}