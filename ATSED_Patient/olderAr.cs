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
    public partial class olderAr : Form
    {
        public olderAr()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ageAr age = new ageAr();
            age.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaintOlderAr complaintOlderAr = new complaintOlderAr();
            complaintOlderAr.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            transferToFollowUp transferToFollowUp = new transferToFollowUp();
            transferToFollowUp.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Unstable").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Hallucination").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new triage((("Difficulty in speaking").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }
    }
}
