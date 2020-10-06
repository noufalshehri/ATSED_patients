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
    public partial class complaintSeven : Form
    {
        public complaintSeven()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            youngerThanSeven youngerThanSeven = new youngerThanSeven();
            youngerThanSeven.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            urineProblems urineProblems = new urineProblems();
            urineProblems.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            constipation constipation = new constipation();
            constipation.Show();
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
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }
    }
}
