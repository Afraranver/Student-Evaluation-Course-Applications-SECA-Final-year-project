using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7try
{
    public partial class Form3 : Form
    {
        public static string rb1 = "";
        public static string rb2 = "";
        public static string rb3 = "";
        public static string rb4 = "";
        public static string rb5 = "";
        public static string rb6 = "";
        public static string rb7 = "";
        public static string rb8 = "";
        public static string rb9 = "";
        public static string rb10 = "";

        

        public Form3()
        {
            
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else if (!radioButton6.Checked && !radioButton7.Checked && !radioButton8.Checked && !radioButton9.Checked && !radioButton10.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else if (!radioButton11.Checked && !radioButton12.Checked && !radioButton13.Checked && !radioButton14.Checked && !radioButton15.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else if (!radioButton16.Checked && !radioButton17.Checked && !radioButton18.Checked && !radioButton19.Checked && !radioButton20.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else if (!radioButton21.Checked && !radioButton22.Checked && !radioButton23.Checked && !radioButton24.Checked && !radioButton25.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else if (!radioButton26.Checked && !radioButton27.Checked && !radioButton28.Checked && !radioButton29.Checked && !radioButton30.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else if (!radioButton31.Checked && !radioButton32.Checked && !radioButton33.Checked && !radioButton34.Checked && !radioButton35.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else if (!radioButton36.Checked && !radioButton37.Checked && !radioButton38.Checked && !radioButton39.Checked && !radioButton40.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else if (!radioButton41.Checked && !radioButton42.Checked && !radioButton43.Checked && !radioButton44.Checked && !radioButton45.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else if (!radioButton46.Checked && !radioButton47.Checked && !radioButton48.Checked && !radioButton49.Checked && !radioButton50.Checked)
            {
                errorProvider1.SetError(this.button1, "Please select the radiobuttons!");
                button1.Enabled = false;
                button1.Enabled = true;
            }
            else
            {

                if (radioButton1.Checked)
                {
                    rb1 = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    rb1 = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    rb1 = radioButton3.Text;
                }
                else if (radioButton4.Checked)
                {
                    rb1 = radioButton4.Text;
                }
                else if (radioButton5.Checked)
                {
                    rb1 = radioButton5.Text;
                }
                if (radioButton6.Checked)
                {
                    rb2 = radioButton6.Text;
                }
                else if (radioButton7.Checked)
                {
                    rb2 = radioButton7.Text;
                }
                else if (radioButton8.Checked)
                {
                    rb2 = radioButton8.Text;
                }
                else if (radioButton9.Checked)
                {
                    rb2 = radioButton9.Text;
                }
                else if (radioButton10.Checked)
                {
                    rb2 = radioButton10.Text;
                }
                if (radioButton11.Checked)
                {
                    rb3 = radioButton11.Text;
                }
                else if (radioButton12.Checked)
                {
                    rb3 = radioButton12.Text;
                }
                else if (radioButton13.Checked)
                {
                    rb3 = radioButton13.Text;
                }
                else if (radioButton14.Checked)
                {
                    rb3 = radioButton14.Text;
                }
                else if (radioButton15.Checked)
                {
                    rb3 = radioButton15.Text;
                }

                if (radioButton16.Checked)
                {
                    rb4 = radioButton16.Text;
                }
                else if (radioButton17.Checked)
                {
                    rb4 = radioButton17.Text;
                }
                else if (radioButton18.Checked)
                {
                    rb4 = radioButton18.Text;
                }
                else if (radioButton19.Checked)
                {
                    rb4 = radioButton19.Text;
                }
                else if (radioButton20.Checked)
                {
                    rb4 = radioButton20.Text;
                }
                if (radioButton21.Checked)
                {
                    rb5 = radioButton21.Text;
                }
                else if (radioButton22.Checked)
                {
                    rb5 = radioButton22.Text;
                }
                else if (radioButton23.Checked)
                {
                    rb5 = radioButton23.Text;
                }
                else if (radioButton24.Checked)
                {
                    rb5 = radioButton24.Text;
                }
                else if (radioButton25.Checked)
                {
                    rb5 = radioButton25.Text;
                }
                if (radioButton26.Checked)
                {
                    rb6 = radioButton26.Text;
                }
                else if (radioButton27.Checked)
                {
                    rb6 = radioButton27.Text;
                }
                else if (radioButton28.Checked)
                {
                    rb6 = radioButton28.Text;
                }
                else if (radioButton29.Checked)
                {
                    rb6 = radioButton29.Text;
                }
                else if (radioButton30.Checked)
                {
                    rb6 = radioButton30.Text;
                }
                if (radioButton31.Checked)
                {
                    rb7 = radioButton31.Text;
                }
                else if (radioButton32.Checked)
                {
                    rb7 = radioButton23.Text;
                }
                else if (radioButton33.Checked)
                {
                    rb7 = radioButton33.Text;
                }
                else if (radioButton34.Checked)
                {
                    rb7 = radioButton34.Text;
                }
                else if (radioButton35.Checked)
                {
                    rb7 = radioButton35.Text;
                }
                if (radioButton36.Checked)
                {
                    rb8 = radioButton36.Text;
                }
                else if (radioButton37.Checked)
                {
                    rb8 = radioButton37.Text;
                }
                else if (radioButton38.Checked)
                {
                    rb8 = radioButton38.Text;
                }
                else if (radioButton39.Checked)
                {
                    rb8 = radioButton39.Text;
                }
                else if (radioButton40.Checked)
                {
                    rb8 = radioButton40.Text;
                }
                if (radioButton41.Checked)
                {
                    rb9 = radioButton41.Text;
                }
                else if (radioButton42.Checked)
                {
                    rb9 = radioButton42.Text;
                }
                else if (radioButton43.Checked)
                {
                    rb9 = radioButton43.Text;
                }
                else if (radioButton44.Checked)
                {
                    rb9 = radioButton44.Text;
                }
                else if (radioButton45.Checked)
                {
                    rb9 = radioButton45.Text;
                }
                if (radioButton46.Checked)
                {
                    rb10 = radioButton46.Text;
                }
                else if (radioButton47.Checked)
                {
                    rb10 = radioButton47.Text;
                }
                else if (radioButton48.Checked)
                {
                    rb10 = radioButton48.Text;
                }
                else if (radioButton49.Checked)
                {
                    rb10 = radioButton49.Text;
                }
                else if (radioButton50.Checked)
                {
                    rb10 = radioButton50.Text;
                }

                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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
