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

namespace Student_Evaluation_Admin
{


    public partial class Mainform : Form
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "CMtX9jO57WxKg1XSHxpT3LD7BXFhVtb74nWcjHJN",
            BasePath = "https://secadb-fbe74.firebaseio.com/"
        };

        IFirebaseClient client;

        public Mainform()
        {
            InitializeComponent();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Mainform_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            client = new FireSharp.FirebaseClient(config);

            dt.Columns.Add("Date&Time");
            dt.Columns.Add("Email");
            dt.Columns.Add("Prog.Name");
            dt.Columns.Add("CourseName");
            dt.Columns.Add("CourseCode");
            dt.Columns.Add("LecturerName");
            dt.Columns.Add("6.A");
            dt.Columns.Add("6.B");
            dt.Columns.Add("6.C");
            dt.Columns.Add("6.D");
            dt.Columns.Add("6.E");
            dt.Columns.Add("6.F");
            dt.Columns.Add("6.G");
            dt.Columns.Add("6.H");
            dt.Columns.Add("6.I");
            dt.Columns.Add("6.J");
            dt.Columns.Add("How many classes missed?");
            dt.Columns.Add("Received Outline");
            dt.Columns.Add("9. feedback");
            dt.Columns.Add("10. feedback");
            dt.Columns.Add("11. feedback");
            dt.Columns.Add("12. feedback");



            dataGridView1.DataSource = dt;

            var data = new Data
            { };

            var obj = new Cntclass
            {
                cnt = data.Id
            };

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

            ToolTip1.SetToolTip(this.button2, "Before search click the refresh button first!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            export();
        }

        private async void export()
        {
            dt.Rows.Clear();
            int i = 0;
            FirebaseResponse resp2 = await client.GetTaskAsync("Counter/node");
            Cntclass obj1 = resp2.ResultAs<Cntclass>();
            int cnt = Convert.ToInt32(obj1.cnt);
            Globals.Cnt = cnt;

            while (true)
            {
                if (cnt == i)
                {

                    break;
                }
                i++;
                try
                {
                    FirebaseResponse resp3 = await client.GetTaskAsync("DataBase/" + i);
                    Data obj2 = resp3.ResultAs<Data>();

                    DataRow row = dt.NewRow();

                    row["Date&Time"] = obj2.v;
                    row["Email"] = obj2.a;
                    row["Prog.Name"] = obj2.b;
                    row["CourseName"] = obj2.c;
                    row["CourseCode"] = obj2.d;
                    row["LecturerName"] = obj2.e;
                    row["6.A"] = obj2.f;
                    row["6.B"] = obj2.g;
                    row["6.C"] = obj2.h;
                    row["6.D"] = obj2.i;
                    row["6.E"] = obj2.j;
                    row["6.F"] = obj2.k;
                    row["6.G"] = obj2.l;
                    row["6.H"] = obj2.m;
                    row["6.I"] = obj2.n;
                    row["6.J"] = obj2.o;
                    row["How many classes missed?"] = obj2.p;
                    row["Received Outline"] = obj2.q;
                    row["9. feedback"] = obj2.r;
                    row["10. feedback"] = obj2.s;
                    row["11. feedback"] = obj2.t;
                    row["12. feedback"] = obj2.u;



                    dt.Rows.Add(row);
                }

                catch
                {

                }


            }
            MessageBox.Show("Done Refreshing!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Prog.Name like '%{0}%' OR LecturerName like '%{0}%' OR CourseName like '%{0}%' OR CourseCode like '%{0}%'", textBox1.Text);

            dataGridView1.DataSource = dv.ToTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Prog.Name like '%{0}%' OR LecturerName like '%{0}%' OR CourseName like '%{0}%' OR CourseCode like '%{0}%'", textBox1.Text);

            dataGridView1.DataSource = dv.ToTable();
        }

        public static class Globals
        {
            public static int Cnt { get; set; }
            public static int A { get; set; }
            public static int D { get; set; }
            public static int N { get; set; }
            public static int SA { get; set; }
            public static int SD { get; set; }
            public static int A2 { get; set; }
            public static int D2 { get; set; }
            public static int N2 { get; set; }
            public static int SA2 { get; set; }
            public static int SD2 { get; set; }
            public static int A3 { get; set; }
            public static int D3 { get; set; }
            public static int N3 { get; set; }
            public static int SA3 { get; set; }
            public static int SD3 { get; set; }
            public static int A4 { get; set; }
            public static int D4 { get; set; }
            public static int N4 { get; set; }
            public static int SA4 { get; set; }
            public static int SD4 { get; set; }
            public static int A5 { get; set; }
            public static int D5 { get; set; }
            public static int N5 { get; set; }
            public static int SA5 { get; set; }
            public static int SD5 { get; set; }
            public static int A6 { get; set; }
            public static int D6 { get; set; }
            public static int N6 { get; set; }
            public static int SA6 { get; set; }
            public static int SD6 { get; set; }
            public static int A7 { get; set; }
            public static int D7 { get; set; }
            public static int N7 { get; set; }
            public static int SA7 { get; set; }
            public static int SD7 { get; set; }
            public static int A8 { get; set; }
            public static int D8 { get; set; }
            public static int N8 { get; set; }
            public static int SA8 { get; set; }
            public static int SD8 { get; set; }
            public static int A9 { get; set; }
            public static int D9 { get; set; }
            public static int N9 { get; set; }
            public static int SA9 { get; set; }
            public static int SD9 { get; set; }
            public static int A1 { get; set; }
            public static int D1 { get; set; }
            public static int N1 { get; set; }
            public static int SA1 { get; set; }
            public static int SD1 { get; set; }
            public static int N12 { get; set; }
            public static int O12 { get; set; }
            public static int T12 { get; set; }
            public static int F12 { get; set; }
            public static int Y16 { get; set; }
            public static int N16 { get; set; }


        }


        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            var a = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.A"].Value.ToString())
            .Select(aa => new { Value = aa.Key, Count = aa.Count(), Rows = aa.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in a)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA += x.Count;
                }

            }

            //dataGridView1.AllowUserToAddRows = false;
            var b = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.B"].Value.ToString())
            .Select(bb => new { Value = bb.Key, Count = bb.Count(), Rows = bb.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in b)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD2 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD2 += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D2 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D2 += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N2 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N2 += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A2 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A2 += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA2 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA2 += x.Count;
                }

            }

            //dataGridView1.AllowUserToAddRows = false;
            var c = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.C"].Value.ToString())
            .Select(cc => new { Value = cc.Key, Count = cc.Count(), Rows = cc.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in c)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD3 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD3 += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D3 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D3 += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N3 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N3 += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A3 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A3 += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA3 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA3 += x.Count;
                }

            }

            //dataGridView1.AllowUserToAddRows = false;
            var d = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.D"].Value.ToString())
            .Select(dd => new { Value = dd.Key, Count = dd.Count(), Rows = dd.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in d)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD4 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD4 += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D4 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D4 += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N4 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N4 += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A4 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A4 += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA4 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA4 += x.Count;
                }

            }

            //dataGridView1.AllowUserToAddRows = false;
            var e2 = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.E"].Value.ToString())
            .Select(ee => new { Value = ee.Key, Count = ee.Count(), Rows = ee.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in e2)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD5 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD5 += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D5 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D5 += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N5 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N5 += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A5 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A5 += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA5 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA5 += x.Count;
                }

            }

            //dataGridView1.AllowUserToAddRows = false;
            var f2 = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.F"].Value.ToString())
            .Select(ff => new { Value = ff.Key, Count = ff.Count(), Rows = ff.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in f2)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD6 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD6 += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D6 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D6 += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N6 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N6 += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A6 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A6 += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA6 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA6 += x.Count;
                }

            }

            var g = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.G"].Value.ToString())
            .Select(gg => new { Value = gg.Key, Count = gg.Count(), Rows = gg.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in g)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD7 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD7 += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D7 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D7 += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N7 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N7 += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A7 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A7 += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA7 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA7 += x.Count;
                }

            }

            var h = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.H"].Value.ToString())
            .Select(hh => new { Value = hh.Key, Count = hh.Count(), Rows = hh.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in h)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD8 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD8 += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D8 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D8 += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N8 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N8 += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A8 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A8 += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA8 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA8 += x.Count;
                }

            }

            var i = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.I"].Value.ToString())
            .Select(ii => new { Value = ii.Key, Count = ii.Count(), Rows = ii.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in i)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD9 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD9 += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D9 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D9 += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N9 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N9 += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A9 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A9 += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA9 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA9 += x.Count;
                }

            }

            var j2 = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["6.J"].Value.ToString())
            .Select(jj => new { Value = jj.Key, Count = jj.Count(), Rows = jj.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in j2)
            {

                if (x.Value.ToString() == "Strongly Disagree")
                {

                    Globals.SD1 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Strongly Disagree")
                {
                    Globals.SD1 += x.Count;
                }
                else if (x.Value.ToString() == "Disagree")
                {

                    Globals.D1 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Disagree")
                {
                    Globals.D1 += x.Count;
                }
                else if (x.Value.ToString() == "Neutral/Neither agree nor disagree")
                {

                    Globals.N1 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Neutral/Neither agree nor disagree")
                {
                    Globals.N1 += x.Count;
                }
                else if (x.Value.ToString() == "Agree")
                {

                    Globals.A1 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Agree")
                {
                    Globals.A1 += x.Count;
                }
                else if (x.Value.ToString() == "Strongly Agree")
                {

                    Globals.SA1 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "Strongly Agree")
                {
                    Globals.SA1 += x.Count;
                }

            }

            var k = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["How many classes missed?"].Value.ToString())
            .Select(kk => new { Value = kk.Key, Count = kk.Count(), Rows = kk.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in k)
            {

                if (x.Value.ToString() == "none")
                {

                    Globals.N12 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "none")
                {
                    Globals.N12 += x.Count;
                }
                else if (x.Value.ToString() == "1-2 class")
                {

                    Globals.O12 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "1-2 class")
                {
                    Globals.O12 += x.Count;
                }
                else if (x.Value.ToString() == "3 classes")
                {

                    Globals.T12 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "3 classes")
                {
                    Globals.T12 += x.Count;
                }
                else if (x.Value.ToString() == "4 or more classes")
                {

                    Globals.F12 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "4 or more classes")
                {
                    Globals.F12 += x.Count;
                }


            }

            var l = dataGridView1.Rows.OfType<DataGridViewRow>()
            .GroupBy(x => x.Cells["Received Outline"].Value.ToString())
            .Select(ll => new { Value = ll.Key, Count = ll.Count(), Rows = ll.ToList() })
            .OrderByDescending(x => x.Count);

            foreach (var x in l)
            {

                if (x.Value.ToString() == "Yes")
                {

                    Globals.Y16 = x.Count;

                }
                else if (x.Value.ToString().Trim() == "Yes")
                {
                    Globals.Y16 += x.Count;
                }
                else if (x.Value.ToString() == "No")
                {

                    Globals.N16 = x.Count;
                }
                else if (x.Value.ToString().Trim() == "No")
                {
                    Globals.N16 += x.Count;
                }



            }
            

            Statform f5 = new Statform();
            this.Hide();
            f5.FormClosed += (s, args) => this.Close();
            f5.Show();
            f5.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelap = new Microsoft.Office.Interop.Excel.Application();
                excelap.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    excelap.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excelap.Cells[i + 2, j + 1] = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }

                excelap.Columns.AutoFit();
                excelap.Visible = true;
            }
        }

        
    }
}
