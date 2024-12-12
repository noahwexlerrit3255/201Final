using System.Windows.Forms;

namespace RitchiesFastFood_FinalProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variable for displaying the total price at the bottom of the form
        public double totalCash = 0.00;

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
                //adds the clicked item to the current order listbox
                itemsListBox.Items.Add(clickedLabel.Text);

                //(placeholder for getting the price from the selected item);

                //(placeholder for adding that value to totalCash);
            }

            //updates the displayed total price
            totalIntLabel.Text = $"${totalCash}";
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
    }
}
