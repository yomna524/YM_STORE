using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YM_STORE;

namespace YMN_STORE
{
    public partial class CreateAccount2 : Form
    {


        private string fName;
        private string lName;
        private string age;
        private string email;
        private string phoneNumber;
        private string address;

        public CreateAccount2()
        {
            InitializeComponent();
           // LoadData();
        }

       /* private void LoadData()
        {
            string connectionString = "Data Source=database.db;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access data from the reader, momken te access hagat tnya 8er el id
                            Console.WriteLine($"Id: {reader["Id"]}");
                        }
                    }
                }

                connection.Close();
            }
        }*/

        private void fnTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox fnTextBox = (TextBox)sender;
            fName = fnTextBox.Text;
        }



        private void lastName_TextChanged(object sender, EventArgs e)
        {
            TextBox lnTextBox = (TextBox)sender;
            lName = lnTextBox.Text;
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox ageTextBox = (TextBox)sender;
            age = ageTextBox.Text;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox phoneTextBox = (TextBox)sender;
            phoneNumber = phoneTextBox.Text;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox emailTextBox = (TextBox)sender;
            email = emailTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox addressTextBox = (TextBox)sender;
            address = addressTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (fName == null || lName == null || email == null || address == null || phoneNumber == null)
                {
                    errorMessage.Text = "Inputs are required!";
                }

                else
                {
                    instruments instruments = new instruments();
                    instruments.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnTextBox.Text = null;
            phoneTextBox.Text = null;
            emailTextBox.Text = null;
            ageTextBox.Text = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //HOme page
            Form1 homePage = new Form1();
            homePage.Show();
            this.Hide();
        }
    }
}
