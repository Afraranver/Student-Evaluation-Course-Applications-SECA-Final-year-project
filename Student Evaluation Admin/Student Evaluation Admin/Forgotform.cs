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
    public partial class Forgotform : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "OmlVupCDG39cJqjiE3djY9Pd5e5k8DJMnxh1L0jU",
            BasePath = "https://secaul-fb4c5.firebaseio.com/"
        };

        IFirebaseClient client;

        public Forgotform()
        {
            InitializeComponent();
        }

        private void Forgotform_Load(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data1 = new LData
            {
                username = textBox1.Text,
                email = textBox2.Text,
                password = textBox3.Text
            };

            try
            {
                FirebaseResponse response1 = await client.GetTaskAsync("Logindetails/" + textBox1.Text);
                LData obj = response1.ResultAs<LData>();
                if (obj.username == textBox1.Text)
                {
                    FirebaseResponse response = await client.UpdateTaskAsync("Logindetails/" + textBox1.Text, data1);
                    LData result = response.ResultAs<LData>();
                    MessageBox.Show("Password Successfully Updated!");

                }
                else
                {
                    MessageBox.Show("Username not found!");
                }
            }
            catch
            {
                MessageBox.Show("Username not found!");
            }

            LoginForm f1 = new LoginForm();
            f1.Show();
            this.Hide();
        }
    }
}
