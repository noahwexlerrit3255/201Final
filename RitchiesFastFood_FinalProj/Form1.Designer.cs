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
            drinksLabel = new Label();
            drinksTable = new TableLayoutPanel();
            dessertLabel = new Label();
            dessertTable = new TableLayoutPanel();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter your name here.";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(15, 40);
            nameTextBox.Margin = new Padding(4, 4, 4, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(155, 31);
            nameTextBox.TabIndex = 1;
            // 
            // selectItemLabel
            // 
            selectItemLabel.AutoSize = true;
            selectItemLabel.Location = new Point(15, 78);
            selectItemLabel.Margin = new Padding(4, 0, 4, 0);
            selectItemLabel.Name = "selectItemLabel";
            selectItemLabel.Size = new Size(227, 25);
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
            mainTable.Location = new Point(15, 141);
            mainTable.Margin = new Padding(4, 4, 4, 4);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 1;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.Size = new Size(650, 141);
            mainTable.TabIndex = 3;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 25;
            itemsListBox.Location = new Point(15, 866);
            itemsListBox.Margin = new Padding(4, 4, 4, 4);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(190, 129);
            itemsListBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 838);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(129, 25);
            label3.TabIndex = 5;
            label3.Text = "Items selected:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 1000);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            // 
            // totalIntLabel
            // 
            totalIntLabel.AutoSize = true;
            totalIntLabel.Font = new Font("Segoe UI", 12F);
            totalIntLabel.Location = new Point(15, 1025);
            totalIntLabel.Margin = new Padding(4, 0, 4, 0);
            totalIntLabel.Name = "totalIntLabel";
            totalIntLabel.Size = new Size(71, 32);
            totalIntLabel.TabIndex = 7;
            totalIntLabel.Text = "$0.00";
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(15, 1062);
            checkoutButton.Margin = new Padding(4, 4, 4, 4);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(191, 36);
            checkoutButton.TabIndex = 8;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(474, 838);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(131, 25);
            label6.TabIndex = 9;
            label6.Text = "Your last order:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // prevOrderListBox
            // 
            prevOrderListBox.FormattingEnabled = true;
            prevOrderListBox.ItemHeight = 25;
            prevOrderListBox.Location = new Point(474, 866);
            prevOrderListBox.Margin = new Padding(4, 4, 4, 4);
            prevOrderListBox.Name = "prevOrderListBox";
            prevOrderListBox.Size = new Size(190, 129);
            prevOrderListBox.TabIndex = 10;
            // 
            // addToOrderButton
            // 
            addToOrderButton.Location = new Point(474, 1004);
            addToOrderButton.Margin = new Padding(4, 4, 4, 4);
            addToOrderButton.Name = "addToOrderButton";
            addToOrderButton.Size = new Size(191, 36);
            addToOrderButton.TabIndex = 11;
            addToOrderButton.Text = "Add to current order";
            addToOrderButton.UseVisualStyleBackColor = true;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 12F);
            mainLabel.Location = new Point(15, 102);
            mainLabel.Margin = new Padding(4, 0, 4, 0);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(68, 32);
            mainLabel.TabIndex = 12;
            mainLabel.Text = "Main";
            // 
            // sidesLabel
            // 
            sidesLabel.AutoSize = true;
            sidesLabel.Font = new Font("Segoe UI", 12F);
            sidesLabel.Location = new Point(14, 286);
            sidesLabel.Margin = new Padding(4, 0, 4, 0);
            sidesLabel.Name = "sidesLabel";
            sidesLabel.Size = new Size(70, 32);
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
            sidesTable.Location = new Point(14, 325);
            sidesTable.Margin = new Padding(4, 4, 4, 4);
            sidesTable.Name = "sidesTable";
            sidesTable.RowCount = 1;
            sidesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sidesTable.Size = new Size(650, 141);
            sidesTable.TabIndex = 13;
            // 
            // drinksLabel
            // 
            drinksLabel.AutoSize = true;
            drinksLabel.Font = new Font("Segoe UI", 12F);
            drinksLabel.Location = new Point(14, 470);
            drinksLabel.Margin = new Padding(4, 0, 4, 0);
            drinksLabel.Name = "drinksLabel";
            drinksLabel.Size = new Size(81, 32);
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
            drinksTable.Location = new Point(14, 509);
            drinksTable.Margin = new Padding(4, 4, 4, 4);
            drinksTable.Name = "drinksTable";
            drinksTable.RowCount = 1;
            drinksTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            drinksTable.Size = new Size(650, 141);
            drinksTable.TabIndex = 15;
            // 
            // dessertLabel
            // 
            dessertLabel.AutoSize = true;
            dessertLabel.Font = new Font("Segoe UI", 12F);
            dessertLabel.Location = new Point(14, 654);
            dessertLabel.Margin = new Padding(4, 0, 4, 0);
            dessertLabel.Name = "dessertLabel";
            dessertLabel.Size = new Size(93, 32);
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
            dessertTable.Location = new Point(14, 692);
            dessertTable.Margin = new Padding(4, 4, 4, 4);
            dessertTable.Name = "dessertTable";
            dessertTable.RowCount = 1;
            dessertTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dessertTable.Size = new Size(650, 141);
            dessertTable.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.GrayText;
            label11.Location = new Point(214, 11);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(402, 25);
            label11.TabIndex = 19;
            label11.Text = "(This will be used to save your order for next time)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 1114);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Ritchie's Fast Food Online Menu";
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
    }
}
