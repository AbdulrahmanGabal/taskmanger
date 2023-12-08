using c_project.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data.SqlClient;
namespace c_project
{
    public partial class Log_in : Form
    {
        Database obj = new Database();
        public Log_in()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Database c1 = new Database();
            string userEmail = textUserName.Text, userPass = textPassword.Text;
            if (!string.IsNullOrWhiteSpace(userEmail) && !string.IsNullOrWhiteSpace(userPass))
            {
                userdata u1 = new userdata();
                u1.u_email = userEmail;
                u1.u_password = userPass;
                if (u1.isfoundUser(u1))
                {
                    //  MessageBox.Show("user is here");
                    DashBoard d = new DashBoard();
                    d.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("No user with that data. please try again or sign up");
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(userEmail) && string.IsNullOrWhiteSpace(userPass))
                    MessageBox.Show("please enter your password and email");
                else if (string.IsNullOrWhiteSpace(userEmail))
                    MessageBox.Show("please enter your email");
                else if (string.IsNullOrWhiteSpace(userPass))
                    MessageBox.Show("please enter your password");
            }

            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*') {
                button4.BringToFront();
                textPassword.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textPassword.PasswordChar == '\0') { 
            button3.BringToFront(); 
             textPassword.PasswordChar = '*';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
