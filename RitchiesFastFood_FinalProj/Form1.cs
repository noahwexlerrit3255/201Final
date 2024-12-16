using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RitchiesFastFood_FinalProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variable for displaying the total price at the bottom of the form
        public decimal totalCash = 0.00m;
        string username;
        //arrays for item names, prices, and sugar/calorie conts.
        string[] itemNames = { "Pizza", "Burger", "Hot Dog", "Taco", "Mozz. Sticks", "Salad", "Fries", "Chips", "Pepsi", "Coke", "Iced Tea", "Water", "Pie", "Ice Cream", "Cookie", "F. Dough" };

        decimal[] itemPrices = { 10.99m, 13.99m, 4.99m, 9.99m, 6.99m, 4.99m, 3.99m, 3.99m, 2.99m, 2.99m, 3.49m, 0.00m, 6.99m, 4.49m, 3.99m, 7.99m };

        int[] sugCal = { 285, 354, 151, 156, 370, 150, 365, 304, 40, 39, 22, 0, 248, 382, 142, 274 };


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {

            //iterates over every item in previous order and adds them to current order
            foreach (string i in prevOrderListBox.Items)
            {
                itemsListBox.Items.Add(i);
            };
        }

        private void mainTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                try
                {
                    string labelName = clickedLabel.Name.Substring(clickedLabel.Name.IndexOf("tem") + 3);
                    int labelIndex = int.Parse(labelName) - 1;

                    //adds the clicked item to the current order listbox

                    if (clickedLabel.Name == "drinkItem" + labelName)
                    {
                        itemsListBox.Items.Add(new Drink(itemNames[labelIndex], itemPrices[labelIndex], sugCal[labelIndex]));
                    }
                    else
                    {
                        itemsListBox.Items.Add(new Food(itemNames[labelIndex], itemPrices[labelIndex], sugCal[labelIndex]));
                    }

                    // adds item price to total price
                    totalCash += itemPrices[labelIndex];

                    //updates the displayed total price
                    totalIntLabel.Text = $"${totalCash}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("failed to add item " + ex.Message);
                }
            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //removes the selected item in the current order listbox
            if (itemsListBox.SelectedIndex > -1)
            {
                itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
            };

            //clears selection
            itemsListBox.ClearSelected();
        }

        private void totalIntLabel_Click(object sender, EventArgs e)
        {

        }

        private void prevOrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            // create a file
            username = nameTextBox.Text;
            
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists($"{username}.txt"))
            {
                using (StreamWriter sw = new StreamWriter($"{username}.txt"))
                {
                    sw.WriteLine(itemsListBox.Items);

                }
                
            }
            using (StreamReader sr = new StreamReader($"{username}.txt"))
            {
                // load previous data into user name and player score variables 
                prevOrderListBox.Text += sr.ReadLine();
            }
        }
            private void itemsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }
    }
}

