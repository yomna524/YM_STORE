using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMN_STORE
{
    public partial class Form2 : Form
    {

        private string username;
        private string password;
        private string confirmPassword;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox passWord = sender as TextBox;
            if (passWord != null)
            {
                password = passWord.Text;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //UserNameeeee
            TextBox userName = sender as TextBox;
            if (userName != null)
            {
                username = userName.Text;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox confirmPasswordValue = sender as TextBox;
            if (confirmPasswordValue != null)
            {
                confirmPassword = confirmPasswordValue.Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if (usernameTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0 || cPasswordTextBox.Text.Length == 0)
            //{
            //    errorMessage.Text = "All inputs are required";
            //}
            //else
            //{
            //    errorMessage.Text = "";
            //    if (password.Length < 8)
            //    {
            //        errorMessage.Text = "Make sure to enter password not less than 8 characters";
            //    }
            //    if (password != confirmPassword)
            //    {
            //        errorMessage.Text = "Password confirm failed";
            //    }
                //else
                //{
                    CreateAccount2 createAccount2 = new CreateAccount2();
                    createAccount2.Show();
                    this.Hide();
                //}
        }
    }
}
