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
            nameTextBox = new TextBox();
            selectItemLabel = new Label();
            mainTable = new TableLayoutPanel();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            mainItem1 = new Label();
            itemsListBox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            totalIntLabel = new Label();
            checkoutButton = new Button();
            label6 = new Label();
            prevOrderListBox = new ListBox();
            addToOrderButton = new Button();
            mainLabel = new Label();
            sidesLabel = new Label();
            sidesTable = new TableLayoutPanel();
            label9 = new Label();
            label8 = new Label();
            drinksLabel = new Label();
            drinksTable = new TableLayoutPanel();
            dessertLabel = new Label();
            dessertTable = new TableLayoutPanel();
            label11 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            mainTable.SuspendLayout();
            sidesTable.SuspendLayout();
            drinksTable.SuspendLayout();
            dessertTable.SuspendLayout();
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
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 1;
            // 
            // selectItemLabel
            // 
            selectItemLabel.AutoSize = true;
            selectItemLabel.Location = new Point(12, 62);
            selectItemLabel.Name = "selectItemLabel";
            selectItemLabel.Size = new Size(188, 20);
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
            mainTable.Controls.Add(label7, 3, 0);
            mainTable.Controls.Add(label5, 2, 0);
            mainTable.Controls.Add(label2, 1, 0);
            mainTable.Controls.Add(mainItem1, 0, 0);
            mainTable.Location = new Point(12, 113);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 1;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.Size = new Size(520, 113);
            mainTable.TabIndex = 3;
            mainTable.Paint += mainTable_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(392, 2);
            label7.Name = "label7";
            label7.Size = new Size(123, 109);
            label7.TabIndex = 3;
            label7.Text = "Taco - $9.99";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(263, 2);
            label5.Name = "label5";
            label5.Size = new Size(121, 109);
            label5.TabIndex = 2;
            label5.Text = "Hot Dog - $4.99";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(134, 2);
            label2.Name = "label2";
            label2.Size = new Size(121, 109);
            label2.TabIndex = 1;
            label2.Text = "Burger - $13.99";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click_1;
            // 
            // mainItem1
            // 
            mainItem1.AutoSize = true;
            mainItem1.Dock = DockStyle.Fill;
            mainItem1.Location = new Point(5, 2);
            mainItem1.Name = "mainItem1";
            mainItem1.Size = new Size(121, 109);
            mainItem1.TabIndex = 0;
            mainItem1.Text = "Pizza Slice - $10.99";
            mainItem1.TextAlign = ContentAlignment.MiddleCenter;
            mainItem1.Click += label2_Click_1;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(12, 693);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(153, 104);
            itemsListBox.TabIndex = 4;
            itemsListBox.Click += itemsListBox_SelectedIndexChanged;
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
            // totalIntLabel
            // 
            totalIntLabel.AutoSize = true;
            totalIntLabel.Font = new Font("Segoe UI", 12F);
            totalIntLabel.Location = new Point(12, 820);
            totalIntLabel.Name = "totalIntLabel";
            totalIntLabel.Size = new Size(60, 28);
            totalIntLabel.TabIndex = 7;
            totalIntLabel.Text = "$0.00";
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(12, 850);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(153, 29);
            checkoutButton.TabIndex = 8;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
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
            // prevOrderListBox
            // 
            prevOrderListBox.FormattingEnabled = true;
            prevOrderListBox.Location = new Point(379, 693);
            prevOrderListBox.Name = "prevOrderListBox";
            prevOrderListBox.Size = new Size(153, 104);
            prevOrderListBox.TabIndex = 10;
            // 
            // addToOrderButton
            // 
            addToOrderButton.Location = new Point(379, 803);
            addToOrderButton.Name = "addToOrderButton";
            addToOrderButton.Size = new Size(153, 29);
            addToOrderButton.TabIndex = 11;
            addToOrderButton.Text = "Add to current order";
            addToOrderButton.UseVisualStyleBackColor = true;
            addToOrderButton.Click += addToOrderButton_Click;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 12F);
            mainLabel.Location = new Point(12, 82);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(56, 28);
            mainLabel.TabIndex = 12;
            mainLabel.Text = "Main";
            // 
            // sidesLabel
            // 
            sidesLabel.AutoSize = true;
            sidesLabel.Font = new Font("Segoe UI", 12F);
            sidesLabel.Location = new Point(11, 229);
            sidesLabel.Name = "sidesLabel";
            sidesLabel.Size = new Size(58, 28);
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
            sidesTable.Controls.Add(label12, 3, 0);
            sidesTable.Controls.Add(label10, 2, 0);
            sidesTable.Controls.Add(label9, 1, 0);
            sidesTable.Controls.Add(label8, 0, 0);
            sidesTable.Location = new Point(11, 260);
            sidesTable.Name = "sidesTable";
            sidesTable.RowCount = 1;
            sidesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sidesTable.Size = new Size(520, 113);
            sidesTable.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(134, 2);
            label9.Name = "label9";
            label9.Size = new Size(121, 109);
            label9.TabIndex = 2;
            label9.Text = "Salad - $4.99";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label2_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(5, 2);
            label8.Name = "label8";
            label8.Size = new Size(121, 109);
            label8.TabIndex = 1;
            label8.Text = "Mozzarella Sticks - $6.99";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label2_Click_1;
            // 
            // drinksLabel
            // 
            drinksLabel.AutoSize = true;
            drinksLabel.Font = new Font("Segoe UI", 12F);
            drinksLabel.Location = new Point(11, 376);
            drinksLabel.Name = "drinksLabel";
            drinksLabel.Size = new Size(67, 28);
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
            drinksTable.Controls.Add(label16, 3, 0);
            drinksTable.Controls.Add(label15, 2, 0);
            drinksTable.Controls.Add(label14, 1, 0);
            drinksTable.Controls.Add(label13, 0, 0);
            drinksTable.Location = new Point(11, 407);
            drinksTable.Name = "drinksTable";
            drinksTable.RowCount = 1;
            drinksTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            drinksTable.Size = new Size(520, 113);
            drinksTable.TabIndex = 15;
            // 
            // dessertLabel
            // 
            dessertLabel.AutoSize = true;
            dessertLabel.Font = new Font("Segoe UI", 12F);
            dessertLabel.Location = new Point(11, 523);
            dessertLabel.Name = "dessertLabel";
            dessertLabel.Size = new Size(76, 28);
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
            dessertTable.Controls.Add(label20, 3, 0);
            dessertTable.Controls.Add(label19, 2, 0);
            dessertTable.Controls.Add(label18, 1, 0);
            dessertTable.Controls.Add(label17, 0, 0);
            dessertTable.Location = new Point(11, 554);
            dessertTable.Name = "dessertTable";
            dessertTable.RowCount = 1;
            dessertTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dessertTable.Size = new Size(520, 113);
            dessertTable.TabIndex = 17;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(263, 2);
            label10.Name = "label10";
            label10.Size = new Size(121, 109);
            label10.TabIndex = 3;
            label10.Text = "Fries - $3.99";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label2_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(392, 2);
            label12.Name = "label12";
            label12.Size = new Size(123, 109);
            label12.TabIndex = 4;
            label12.Text = "Chips - $3.99";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += label2_Click_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(5, 2);
            label13.Name = "label13";
            label13.Size = new Size(121, 109);
            label13.TabIndex = 3;
            label13.Text = "Pepsi - $2.99";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Click += label2_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(134, 2);
            label14.Name = "label14";
            label14.Size = new Size(121, 109);
            label14.TabIndex = 4;
            label14.Text = "Coke - $2.99";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            label14.Click += label2_Click_1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Location = new Point(263, 2);
            label15.Name = "label15";
            label15.Size = new Size(121, 109);
            label15.TabIndex = 5;
            label15.Text = "Iced Tea - $3.49";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            label15.Click += label2_Click_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Location = new Point(392, 2);
            label16.Name = "label16";
            label16.Size = new Size(123, 109);
            label16.TabIndex = 6;
            label16.Text = "Water - FREE";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            label16.Click += label2_Click_1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Location = new Point(5, 2);
            label17.Name = "label17";
            label17.Size = new Size(121, 109);
            label17.TabIndex = 4;
            label17.Text = "Apple Pie - $6.99";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            label17.Click += label2_Click_1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Fill;
            label18.Location = new Point(134, 2);
            label18.Name = "label18";
            label18.Size = new Size(121, 109);
            label18.TabIndex = 5;
            label18.Text = "Soft Serve Ice Cream - $4.49";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            label18.Click += label2_Click_1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Fill;
            label19.Location = new Point(263, 2);
            label19.Name = "label19";
            label19.Size = new Size(121, 109);
            label19.TabIndex = 6;
            label19.Text = "Cookie - $3.99";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            label19.Click += label2_Click_1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Fill;
            label20.Location = new Point(392, 2);
            label20.Name = "label20";
            label20.Size = new Size(123, 109);
            label20.TabIndex = 7;
            label20.Text = "Fried Dough - $7.99";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            label20.Click += label2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 889);
            Controls.Add(label11);
            Controls.Add(dessertLabel);
            Controls.Add(dessertTable);
            Controls.Add(drinksLabel);
            Controls.Add(drinksTable);
            Controls.Add(sidesLabel);
            Controls.Add(sidesTable);
            Controls.Add(mainLabel);
            Controls.Add(addToOrderButton);
            Controls.Add(prevOrderListBox);
            Controls.Add(label6);
            Controls.Add(checkoutButton);
            Controls.Add(totalIntLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(itemsListBox);
            Controls.Add(mainTable);
            Controls.Add(selectItemLabel);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
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
        private Label label6;
        private ListBox prevOrderListBox;
        private Button addToOrderButton;
        private Label mainLabel;
        private Label sidesLabel;
        private TableLayoutPanel sidesTable;
        private Label drinksLabel;
        private TableLayoutPanel drinksTable;
        private Label dessertLabel;
        private TableLayoutPanel dessertTable;
        private Label label11;
        private Label mainItem1;
        private Label label7;
        private Label label5;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label12;
        private Label label10;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label17;
        private Label label20;
        private Label label19;
        private Label label18;
    }
}
