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

namespace ATSED_Patient
{
    public partial class services : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");

        string id;
        public services(string id)
        {
            this.id = id;
            InitializeComponent();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Id Id = new Id("services");
            Id.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from printing where id=" + id + ";", cn);
            string u = cmd.ExecuteScalar().ToString();
            long num = Int64.Parse(u);
            if (num > 0)
            {
                cmd = new SqlCommand("select count(*) from printing where id=" + id + " AND type='" + "Transfer to specialized clinic" + "';", cn);
                string s = cmd.ExecuteScalar().ToString();
                num = Int64.Parse(s);
                if (num > 0)
                {
                    this.Hide();
                    TransferForm TransferForm = new TransferForm(id);
                }
                else
                    MessageBox.Show("Sorry, you're not permitted for this service. \n نعتذر لا تملك الإذن لهذه الخدمة ");

            }
            else
                MessageBox.Show("Sorry, you're not permitted for this service. \n نعتذر لا تملك الإذن لهذه الخدمة ");
            cn.Close();
        }

    

        private void Button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from printing where id=" + id + ";", cn);
            string u = cmd.ExecuteScalar().ToString();
            long num = Int64.Parse(u);
            if (num > 0)
            {
                cmd = new SqlCommand("select count(*) from printing where id=" + id + " AND type='" + "Sick leave" + "';", cn);
                string s = cmd.ExecuteScalar().ToString();
                num = Int64.Parse(s);
                if (num > 0)
                {
                    this.Hide();
                    SickLeaveForm SickLeaveForm = new SickLeaveForm(id);
                }
                else
                    MessageBox.Show("Sorry, you're not permitted for this service. \n نعتذر لا تملك الإذن لهذه الخدمة ");

            }
            else
                MessageBox.Show("Sorry, you're not permitted for this service. \n نعتذر لا تملك الإذن لهذه الخدمة ");
            cn.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from printing where id=" + id + ";", cn);
            string u = cmd.ExecuteScalar().ToString();
            long num = Int64.Parse(u);
            if (num > 0)
            {
                cmd = new SqlCommand("select count(*) from printing where id=" + id + " AND type="+ "'x-ray report'" + ";", cn);
                string s = cmd.ExecuteScalar().ToString();
                num = Int64.Parse(s);
                if (num > 0)
                {
                    this.Hide();
                    xrayForm xrayForm = new xrayForm(id);
                }
                else
                    MessageBox.Show("Sorry, you're not permitted for this service. \n نعتذر لا تملك الإذن لهذه الخدمة ");

            }
            else
                MessageBox.Show("Sorry, you're not permitted for this service. \n نعتذر لا تملك الإذن لهذه الخدمة ");
            cn.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from printing where id=" + id + ";", cn);
            string u = cmd.ExecuteScalar().ToString();
            long num = Int64.Parse(u);
            if (num > 0)
            {
                cmd = new SqlCommand("select count(*) from printing where id=" + id + " AND type='" + "Status report" + "';", cn);
                string s = cmd.ExecuteScalar().ToString();
                num = Int64.Parse(s);
                if (num > 0)
                {
                    this.Hide();
                    StatusReportForm StatusReportForm = new StatusReportForm(id);
                }
                else
                    MessageBox.Show("Sorry, you're not permitted for this service. \n نعتذر لا تملك الإذن لهذه الخدمة ");
            }
            else
                MessageBox.Show("Sorry, you're not permitted for this service. \n نعتذر لا تملك الإذن لهذه الخدمة ");
            cn.Close();
 
        }
    }
}
