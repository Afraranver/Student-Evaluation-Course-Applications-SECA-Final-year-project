using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp7try
{
    public partial class Form1 : Form
    {
        public static string st1 = "";
        public static string st2 = "";
        public static string st3 = "";
        public static string st4 = "";
        public static string st5 = "";
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(Startform));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Startform()
        {

            Application.Run(new Form2());
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
                st1 = textBox1.Text;
                st2 = comboBox1.Text;
                st3 = textBox2.Text;
                st4 = textBox3.Text;
                st5 = comboBox2.Text;


                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            
            
          
            
        }

        private void textbox1leave(object sender, EventArgs e)
        {
            string pattern = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$";
            if (Regex.IsMatch(textBox1.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox1,"Please fill in correct email format!");
            }

            if (textBox1.Text == "")
                textBox1.Text = "example@mail.com";
            textBox1.ForeColor = Color.Black;
        }

        private void textbox1enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "example@mail.com")
                textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textbox2leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider2.SetError(this.textBox2, "Please fill in here first!");
            }
            else
            {
                errorProvider2.Clear();
            }
            
        }

        private void textbox3leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider3.SetError(this.textBox3, "Please fill in here first!");
            }
            else
            {
                errorProvider3.Clear();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
