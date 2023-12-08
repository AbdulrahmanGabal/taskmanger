using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;
using c_project.database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace c_project
{
    public partial class SignUp : Form
    {
        public string imgPath;
        public SignUp()
        {
            InitializeComponent();
        }
       
        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (c_pass.Text == Pass.Text && !string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(email0.Text) && !string.IsNullOrWhiteSpace(Pass.Text))
            {
                userdata u1 = new userdata()
                {
                    u_name = name.Text,
                    u_email = email0.Text,
                    u_password = Pass.Text
                };

                bool isvalide = true, isvalidn = true, isvalidpass = true, isvalid = true;
                //  bool isvalidname=true ;
                // adduser au1 = new adduser();
                //calling to ensure name
                u1.validname(u1.u_name, ref isvalidn);
                /*
                       if (isvalid)
                           MessageBox.Show("correct");
                       else
                           MessageBox.Show("not correct");*/
                //calling to ensure email
                u1.validemail(u1.u_email, ref isvalide);
                /* if(isvalid)
                     MessageBox.Show("correct");
                 else
                     MessageBox.Show("not correct");*/
                //calling to ensure pass
                u1.vaildpass(u1.u_password, ref isvalidpass);
                /* if (isvalid)
                     MessageBox.Show("correct");
                 else
                     MessageBox.Show("not correct");*/
                u1.adduser(ref isvalidpass, ref isvalidn, ref isvalide, ref isvalid);
                //  if (!string.IsNullOrWhiteSpace(u1.u_name) && !string.IsNullOrWhiteSpace(u1.u_password) && !string.IsNullOrWhiteSpace(u1.u_email))
                //{


                if (isvalid)
                {

                    if (u1.isfoundUser(u1))
                    {
                        MessageBox.Show("User already Exists, please sign up");
                    }
                    else
                    {
                       // u1.img = imgPath;
                        db.userdatas.Add(u1);
                        db.SaveChanges();
                        if (imgPath != "")
                        {
                            string path = Environment.CurrentDirectory + "\\images\\users\\" + u1.u_id + ".jpg";
                            File.Copy(imgPath, path);
                            u1.img = path;

                        }
                        
                        db.SaveChanges();
                        MessageBox.Show("Successful singup");
                        Log_in l = new Log_in();
                        l.Show();
                        this.Hide();
                    }
                }
                else if (isvalide && isvalidn)
                    MessageBox.Show("too short password");
                else if (isvalide && isvalidpass)
                    MessageBox.Show("name that you was entered not vaild, Please enter olny letters");
                else if (isvalidpass && isvalidn)
                    MessageBox.Show("not vaild email");
                else if (isvalide)
                    MessageBox.Show("not vaild name and password");
                else if (isvalidn)
                    MessageBox.Show("not vaild email and password");
                else if (isvalidpass)
                    MessageBox.Show("not vaild name and email");
                else
                    MessageBox.Show("not vaild input");


                // }
                /* else
                 {
                     if(string.IsNullOrWhiteSpace(u1.u_name)&& string.IsNullOrWhiteSpace(u1.u_password))
                         MessageBox.Show("please enter your name and ")
                 }*/

            }
            else if(string.IsNullOrWhiteSpace(name.Text)||string.IsNullOrWhiteSpace(Pass.Text)||string.IsNullOrWhiteSpace(email0.Text)|| string.IsNullOrWhiteSpace(c_pass.Text))
            {
                MessageBox.Show("pkeses complete your data");
            }
            else
            {
                MessageBox.Show("please check your password");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_in l = new Log_in();
            l.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();

            if (img.ShowDialog() == DialogResult.OK)
            {
                imgPath = img.FileName;
                pictureBox1.ImageLocation = img.FileName;
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }


        private void button4_Click_2(object sender, EventArgs e)
        {
         
        }
    }
    
}
