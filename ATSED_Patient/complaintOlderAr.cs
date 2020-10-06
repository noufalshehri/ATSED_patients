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
    public partial class complaintOlderAr : Form
    {
        public complaintOlderAr()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            olderAr older = new olderAr();
            older.Show();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            transferToFollowUp t = new transferToFollowUp();
            t.Show();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            new triage("none");
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Cough or cold or coryza").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            painAr pain = new painAr();
            pain.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Joint pain or Joint swelling").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            urineProblemsAr urineProblems = new urineProblemsAr();
            urineProblems.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            constipationAr constipation = new constipationAr();
            constipation.Show();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Under the influence of alcohol or anaesthetic").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Fever").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Irritation").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Heart palpitations").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Vomiting").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Swollen feet").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("severe headache").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("diabetes or hypertension Follow up").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage((("Transfer from pharmacy or lab").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((" object entered the eye or vision changes").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }
    }
}
