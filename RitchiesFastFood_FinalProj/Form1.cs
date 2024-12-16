using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Linq.Expressions;

namespace RitchiesFastFood_FinalProj
{
    public partial class Form1 : Form
    {
        //dictionary for usernames and passwords
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "admin", "password" } //placeholder example for admin login
        };

        public Form1()
        {
            InitializeComponent();
            LoadUsers();//load existing dictionary if it exists
            HideMainUI();
        }

        string username;
        string password;

        //variable for displaying the total price at the bottom of the form
        public decimal totalCash = 0.00m;
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
            if (File.Exists($"{username}.txt"))
            {
                using (StreamReader sr = new StreamReader($"{username}.txt"))
                {
                    // load previous data into user name and player score variables 
                    prevOrderListBox.Items.Add(sr.ReadLine());

                }
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("order successful!");
            itemsListBox.Items.Clear();

        }
        private void itemsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        //click handler for login button
        //checks if the username and password given exist in dictionary
        private void button1_Click(object sender, EventArgs e)
        {
            username = nameTextBox.Text;
            password = textBox1.Text;

            //if the username and password already exist in the dictionary, meaning the user has signed up
            if (users.ContainsKey(username) && users[username] == password)
            {
                ShowMainUI();//show the rest of the interface
            }
            else
            {
                //login failed
                MessageBox.Show("Login failed. Incorrect username or password.");
                HideMainUI();//make sure the interface is still hidden
            }

            try
            {
                using (StreamWriter sw = new StreamWriter("username.txt", append: true))
                {
                    sw.WriteLine($"{username}:{password}");
                }
            }
            catch (Exception ex)//if the contents cannot be written to the file
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }

        //click handler for signup button
        private void button2_Click(object sender, EventArgs e)
        {
            username = nameTextBox.Text;
            password = textBox1.Text;

            LoadUsers();//make sure the dictionary is fresh

            //can't have an empty username or password
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }
            else if (users.ContainsKey(username))
            {
                //make sure existing usernames can't be chosen
                MessageBox.Show("Username already exists. Please choose a different one.");
            }
            else
            {
                //add new username and password pair to dictionary
                users[username] = password;
                SaveUsers();//save to file as well
                //then user needs to log in to see application
                MessageBox.Show("Your account has been created!");
            }
        }

        //function to hide all the ui other than the login textboxes/buttons/etc
        private void HideMainUI()
        {
            mainTable.Visible = false;
            sidesTable.Visible = false;
            drinksTable.Visible = false;
            dessertTable.Visible = false;
            itemsListBox.Visible = false;
            addToOrderButton.Visible = false;
            checkoutButton.Visible = false;
            totalIntLabel.Visible = false;
            prevOrderListBox.Visible = false;
            mainLabel.Visible = false;
            sidesLabel.Visible = false;
            drinksLabel.Visible = false;
            dessertLabel.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label3.Visible = false;
            selectItemLabel.Visible = false;
        }

        //show all the ui items that were initially hidden (everything except login)
        private void ShowMainUI()
        {
            mainTable.Visible = true;
            sidesTable.Visible = true;
            drinksTable.Visible = true;
            dessertTable.Visible = true;
            itemsListBox.Visible = true;
            addToOrderButton.Visible = true;
            checkoutButton.Visible = true;
            totalIntLabel.Visible = true;
            prevOrderListBox.Visible = true;
            mainLabel.Visible = true;
            sidesLabel.Visible = true;
            drinksLabel.Visible = true;
            dessertLabel.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label3.Visible = true;
            selectItemLabel.Visible = true;
        }

        //save usernames+passwords dictionary to file
        private void SaveUsers()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("username.txt", append: true))
                {
                    foreach (var user in users)
                    {
                        sw.WriteLine($"{user.Key}:{user.Value}");//save username and password pairs together
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to file: {ex.Message}");
            }
        }


        //load the usernames+passwords dictionary from saved file
        // Load users from the username.txt file
        private void LoadUsers()
        {
            try
            {
                if (File.Exists("username.txt"))
                {
                    users.Clear();

                    using (StreamReader sr = new StreamReader("username.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            //each line has a username and password separated by a colon
                            var parts = line.Split(':');
                            if (parts.Length == 2)
                            {
                                users[parts[0]] = parts[1];//add to dictionary
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}");
                users = new Dictionary<string, string>();//empty dictionary instead if file can't be loaded
            }
        }

       
    }
}

