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
    public partial class IdAr : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");
        string go; 
        public IdAr(string s)
        {
            InitializeComponent();
            go = s;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            language language = new language(go);
            language.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //check that the length is not more than 10 digits
            if ((textBox1.Text.Trim()).Length > 10 || (textBox1.Text.Trim()).Length < 10)
                MessageBox.Show("أدخل 10 ارقام فقط");

            //not more than 10 digits
            else
            {
                cn.Open();

                //check if the id exist
                SqlCommand cmd = new SqlCommand
                    ("select count(*) from hospitalRecords where id=" + textBox1.Text.Trim() + ";", cn);
                string s = cmd.ExecuteScalar().ToString();
                if (s.Equals("1"))
                { //the id is correct

                    //check that id is not in the waiting patients
                    cmd = new SqlCommand
                ("select count(*) from waitingPatients where id=" + textBox1.Text.Trim() + ";", cn);
                    string t = cmd.ExecuteScalar().ToString();
                    
                    if (t.Equals("1")) // if it's in the waiting patients
                    {
                        MessageBox.Show("لقد تم تسجيلك بالفعل، رجاءاً انتظر حتى يتم نداء اسمك");
                    }
                    else
                    {
                        string id = textBox1.Text.Trim();
                        new currentPatientID(Int32.Parse(id));
                        if (go == "services")
                        {
                            this.Hide();
                            services services = new services(textBox1.Text.Trim());
                            services.Show();
                        }
                        else if (go == "redCases")
                        {
                            this.Hide();
                            redCasesAr redCases = new redCasesAr();
                            redCases.Show();
                        }
                    }
                    cn.Close();
                }
                else
                    MessageBox.Show("رقم هوية خاطئ");
            }
        }
    }
}
