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

namespace WindowsFormsApp7try
{
    public partial class Form4 : Form
    {
        public static string rb11 = "";
        public static string rb12 = "";

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "CMtX9jO57WxKg1XSHxpT3LD7BXFhVtb74nWcjHJN",
            BasePath = "https://secadb-fbe74.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form4()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton51.Checked && !radioButton52.Checked && !radioButton53.Checked && !radioButton54.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
                errorProvider1.Clear();
            }
            else if (!radioButton55.Checked && !radioButton56.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
                errorProvider1.Clear();
            }
            else if (textBox4.Text == "Enter your answer here" || textBox5.Text == "Enter your answer here" || textBox6.Text == "Enter your answer here")
            {
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                if (radioButton51.Checked)
                {
                    rb11 = radioButton51.Text;
                }
                else if (radioButton52.Checked)
                {
                    rb11 = radioButton52.Text;
                }
                else if (radioButton53.Checked)
                {
                    rb11 = radioButton53.Text;
                }
                else if (radioButton54.Checked)
                {
                    rb11 = radioButton54.Text;
                }

                if (radioButton55.Checked)
                {
                    rb12 = radioButton55.Text;
                }
                else if (radioButton56.Checked)
                {
                    rb12 = radioButton56.Text;

                }


                FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
                Counter_class get = resp.ResultAs<Counter_class>();

                var data = new Data
                {
                    Id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                    a = Form1.st1,
                    b = Form1.st2,
                    c = Form1.st3,
                    d = Form1.st4,
                    e = Form1.st5,
                    f = Form3.rb1,
                    g = Form3.rb2,
                    h = Form3.rb3,
                    i = Form3.rb4,
                    j = Form3.rb5,
                    k = Form3.rb6,
                    l = Form3.rb7,
                    m = Form3.rb8,
                    n = Form3.rb9,
                    o = Form3.rb10,
                    p = rb11,
                    q = rb12,
                    r = textBox4.Text,
                    s = textBox5.Text,
                    t = textBox6.Text,
                    u = textBox7.Text,
                    v = DateTime.Now.ToString()


                };
                SetResponse response = await client.SetTaskAsync("DataBase/" + data.Id, data);
                Data result = response.ResultAs<Data>();
                MessageBox.Show("Submission Successful","Thank You.");

                var obj = new Counter_class
                {
                    cnt = data.Id
                };

                SetResponse response1 = await client.SetTaskAsync("Counter/node", obj);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox4enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Enter your answer here")
                textBox4.Text = null;
            textBox4.ForeColor = Color.Black;
        }

        private void textbox4leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                errorProvider2.SetError(this.textBox4, "Please fill in here first!");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (textBox4.Text == "")
                textBox4.Text = "Enter your answer here";
            textBox4.ForeColor = Color.DarkGray;

            
        }

        private void textbox5leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                errorProvider3.SetError(this.textBox5, "Please fill in here first!");
            }
            else
            {
                errorProvider3.Clear();
            }

            if (textBox5.Text == "")
                textBox5.Text = "Enter your answer here";
            textBox5.ForeColor = Color.DarkGray;

            
        }

        private void textbox5enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Enter your answer here")
                textBox5.Text = null;
            textBox5.ForeColor = Color.Black;
        }

        private void txtbx6leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                errorProvider4.SetError(this.textBox6, "Please fill in here first!");
            }
            else
            {
                errorProvider4.Clear();
            }

            if (textBox6.Text == "")
                textBox6.Text = "Enter your answer here";
            textBox6.ForeColor = Color.DarkGray;
        }

        private void txtbx6enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Enter your answer here")
                textBox6.Text = null;
            textBox6.ForeColor = Color.Black;
        }

        private void txtbx7leave(object sender, EventArgs e)
        {
            
            
           

            
        }

        private void textbox7enter(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do You really want to close the program?", "Exit SECA", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dia == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
