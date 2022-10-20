using Data.Models;
using Micron;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer_v1._0;
namespace Login_UI_design
{
    public partial class LoginForm : Form
    {
        MicronDbContext micron = new MicronDbContext();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (ShowPassword.Text == "Show password")
            {
                PasswordTextBox.PasswordChar = '\0';
                ShowPassword.Text = "Hide password";
            }
            else if (ShowPassword.Text == "Hide password")
            {
                PasswordTextBox.PasswordChar = '●';
                ShowPassword.Text = "Show password";
            }
        }

        private void SIGNUP_Click(object sender, EventArgs e)
        {
            PageLoginSignup.SetPage(1);
        }


        private void label2_Click(object sender, EventArgs e)
        {
            PageLoginSignup.SetPage(0);
        }

        private void ShowUnShowCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (ShowUnShowCheckBox.Checked == true)
            {
                NewPasswordTextBox.PasswordChar = '\0';
                NewConfirmPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                NewPasswordTextBox.PasswordChar = '●';
                NewConfirmPasswordTextBox.PasswordChar = '●';
            }    
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = micron.GetRecord<User>($"Email='{EmailTextBox.Text}' AND Password = MD5('{PasswordTextBox.Text}')");
            if (user == null)
            {
                MessageBox.Show("Invalid Login Credentials");
                return;
            }
            this.Visible = false;
            dashBoard dasboard = new dashBoard();
            dasboard.ShowDialog();
            this.Visible = true;

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            User user = micron.GetRecord<User>($"Email='{EmailTextBox.Text}' AND Password = MD5('{PasswordTextBox.Text}')");
            if (user != null)
            {
                MessageBox.Show("User already exists.");
                return;
            }
            user = new User()
            {
                Name = NameTextBox.Text,
                Phone = Int32.Parse(PhoneTextBox.Text),
                Password = NewPasswordTextBox.Text,
                Email = NewEmailTextBox.Text,
            };
            user = micron.Save(user);
            MessageBox.Show("Account successfully created");
            EmailTextBox.Text = user.Email;
            PasswordTextBox.Text = user.Password;
            PageLoginSignup.SetPage(0);
        }
    }
}
