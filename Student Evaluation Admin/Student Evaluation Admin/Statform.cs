using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Student_Evaluation_Admin
{


    public partial class Statform : Form
    {
        public Statform()
        {
            InitializeComponent();
        }

        

        private void Statform_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
           
            label2.Text = Mainform.Globals.Cnt.ToString();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Title title = new Title();
            title.Font = new Font("Cambria", 16, FontStyle.Bold);
            title.Text = "Stacked Bar Chart for the Question 6.";
            chart1.Titles.Add(title);


            chart1.Series["Agree"].IsValueShownAsLabel = true;
            chart1.Series["Disagree"].IsValueShownAsLabel = true;
            chart1.Series["Neutral/Neither"].IsValueShownAsLabel = true;
            chart1.Series["Strongly Agree"].IsValueShownAsLabel = true;
            chart1.Series["Strongly Disagree"].IsValueShownAsLabel = true;


            chart1.Series["Agree"].Points.AddXY("6.J", Mainform.Globals.A1);
            chart1.Series["Disagree"].Points.AddXY("6.J", Mainform.Globals.D1);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.J", Mainform.Globals.N1);
            chart1.Series["Strongly Agree"].Points.AddXY("6.J", Mainform.Globals.SA1);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.J", Mainform.Globals.SD1);

            chart1.Series["Agree"].Points.AddXY("6.I", Mainform.Globals.A9);
            chart1.Series["Disagree"].Points.AddXY("6.I", Mainform.Globals.D9);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.I", Mainform.Globals.N9);
            chart1.Series["Strongly Agree"].Points.AddXY("6.I", Mainform.Globals.SA9);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.I", Mainform.Globals.SD9);

            chart1.Series["Agree"].Points.AddXY("6.H", Mainform.Globals.A8);
            chart1.Series["Disagree"].Points.AddXY("6.H", Mainform.Globals.D8);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.H", Mainform.Globals.N8);
            chart1.Series["Strongly Agree"].Points.AddXY("6.H", Mainform.Globals.SA8);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.H", Mainform.Globals.SD8);

            chart1.Series["Agree"].Points.AddXY("6.G", Mainform.Globals.A7);
            chart1.Series["Disagree"].Points.AddXY("6.G", Mainform.Globals.D7);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.G", Mainform.Globals.N7);
            chart1.Series["Strongly Agree"].Points.AddXY("6.G", Mainform.Globals.SA7);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.G", Mainform.Globals.SD7);

            chart1.Series["Agree"].Points.AddXY("6.F", Mainform.Globals.A6);
            chart1.Series["Disagree"].Points.AddXY("6.F", Mainform.Globals.D6);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.F", Mainform.Globals.N6);
            chart1.Series["Strongly Agree"].Points.AddXY("6.F", Mainform.Globals.SA6);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.F", Mainform.Globals.SD6);


            chart1.Series["Agree"].Points.AddXY("6.E", Mainform.Globals.A5);
            chart1.Series["Disagree"].Points.AddXY("6.E", Mainform.Globals.D5);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.E", Mainform.Globals.N5);
            chart1.Series["Strongly Agree"].Points.AddXY("6.E", Mainform.Globals.SA5);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.E", Mainform.Globals.SD5);

            chart1.Series["Agree"].Points.AddXY("6.D", Mainform.Globals.A4);
            chart1.Series["Disagree"].Points.AddXY("6.D", Mainform.Globals.D4);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.D", Mainform.Globals.N4);
            chart1.Series["Strongly Agree"].Points.AddXY("6.D", Mainform.Globals.SA4);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.D", Mainform.Globals.SD4);

            chart1.Series["Agree"].Points.AddXY("6.C", Mainform.Globals.A3);
            chart1.Series["Disagree"].Points.AddXY("6.C", Mainform.Globals.D3);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.C", Mainform.Globals.N3);
            chart1.Series["Strongly Agree"].Points.AddXY("6.C", Mainform.Globals.SA3);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.C", Mainform.Globals.SD3);

            chart1.Series["Agree"].Points.AddXY("6.B", Mainform.Globals.A2);
            chart1.Series["Disagree"].Points.AddXY("6.B", Mainform.Globals.D2);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.B", Mainform.Globals.N2);
            chart1.Series["Strongly Agree"].Points.AddXY("6.B", Mainform.Globals.SA2);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.B", Mainform.Globals.SD2);

            chart1.Series["Agree"].Points.AddXY("6.A", Mainform.Globals.A);
            chart1.Series["Disagree"].Points.AddXY("6.A", Mainform.Globals.D);
            chart1.Series["Neutral/Neither"].Points.AddXY("6.A", Mainform.Globals.N);
            chart1.Series["Strongly Agree"].Points.AddXY("6.A", Mainform.Globals.SA);
            chart1.Series["Strongly Disagree"].Points.AddXY("6.A", Mainform.Globals.SD);

            Title title2 = new Title();
            title2.Font = new Font("Cambria", 14, FontStyle.Bold);
            title2.Text = "PIE CHART for number of classes missed.";
            chart2.Titles.Add(title2);



            chart2.Series["Q7"].IsValueShownAsLabel = true;


            chart2.Series["Q7"].Points.AddXY("none", Mainform.Globals.N12);
            chart2.Series["Q7"].Points.AddXY("1-2 classes", Mainform.Globals.O12);
            chart2.Series["Q7"].Points.AddXY("3 classes", Mainform.Globals.T12);
            chart2.Series["Q7"].Points.AddXY("4 or more classes", Mainform.Globals.F12);

            Title title3 = new Title();
            title3.Font = new Font("Cambria", 14, FontStyle.Bold);
            title3.Text = "PIE CHART to Received Outline Question";
            chart3.Titles.Add(title3);


            chart3.Series["Q8"].IsValueShownAsLabel = true;


            chart3.Series["Q8"].Points.AddXY("Yes", Mainform.Globals.Y16);
            chart3.Series["Q8"].Points.AddXY("No", Mainform.Globals.N16);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainform f4 = new Mainform();
            this.Hide();
            f4.FormClosed += (s, args) => this.Close();
            f4.Show();
            f4.Focus();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.chart1.SaveImage(dlg.FileName, ChartImageFormat.Png);
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg2 = new SaveFileDialog();
            if (dlg2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.chart2.SaveImage(dlg2.FileName, ChartImageFormat.Png);
        }

        private void chart3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg3 = new SaveFileDialog();
            if (dlg3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.chart3.SaveImage(dlg3.FileName, ChartImageFormat.Png);
        }
    }
}
