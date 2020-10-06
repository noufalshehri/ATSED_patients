using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATSED_Patient
{
    public partial class constipationAr : Form
    {
        public constipationAr()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new triage((("Constipation without flatulence").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaint complaint = new complaint("");
            complaint.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new triage((("Constipation with flatulence").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }
    }
}
