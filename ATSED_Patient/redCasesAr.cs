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
    public partial class redCasesAr : Form
    {
        public redCasesAr()
        {
            InitializeComponent();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            new triage((("Burns").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            ageAr ageAr = new ageAr();
            ageAr.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            new triage((("Accident, assault or bite").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            new triage((("shortness of breath ").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            new triage((("Severe chest pain").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            new triage((("seizures").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            new triage((("Severe bleeding").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new triage((("Newborn (month or younger)").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new triage((("hyper sensitivity").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new triage((("loss of conscious ").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new triage((("Vomiting blood").ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IdAr Id = new IdAr("redCases");
            Id.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

       
    }
}
