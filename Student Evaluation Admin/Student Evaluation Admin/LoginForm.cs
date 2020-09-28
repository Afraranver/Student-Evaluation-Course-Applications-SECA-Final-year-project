using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net;

namespace Student_Evaluation_Admin
{


    public partial class LoginForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "OmlVupCDG39cJqjiE3djY9Pd5e5k8DJMnxh1L0jU",
            BasePath = "https://secaul-fb4c5.firebaseio.com/"
        };

        IFirebaseClient client;

        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var client1 = new WebClient())
                using (client1.OpenRead("http://google.com/generate_204"))
                    client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Please check your network connection and try again!");
                Application.Exit();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse response1 = await client.GetTaskAsync("Logindetails/" + textBox1.Text);
                LData obj = response1.ResultAs<LData>();
                if (obj.username == textBox1.Text && obj.password == textBox2.Text)
                {
                    Mainform f4 = new Mainform();
                    this.Hide();
                    f4.FormClosed += (s, args) => this.Close();
                    f4.Show();
                    f4.Focus();
                    
                }
                else
                {
                    MessageBox.Show("Username and Password not match!");
                }
            }
            catch
            {
                MessageBox.Show("Username and Password not match!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Signupform f2 = new Signupform();
            this.Hide();
            f2.FormClosed += (s, args) => this.Close();
            f2.Show();
            f2.Focus();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Forgotform f3 = new Forgotform();
            this.Hide();
            f3.FormClosed += (s, args) => this.Close();
            f3.Show();
            f3.Focus();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
