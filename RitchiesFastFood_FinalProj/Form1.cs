using System.Windows.Forms;

namespace RitchiesFastFood_FinalProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

            //disables the button
            addToOrderButton.Enabled = false;
        }

        private void mainTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                itemsListBox.Items.Add(clickedLabel.Text);
            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex > -1)
            {
                itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
            };

            itemsListBox.ClearSelected();
        }
    }
}
