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
    public partial class older : Form
    {
        public older()
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
            age age = new age();
            age.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            transferToFollowUp transferToFollowUp = new transferToFollowUp();
            transferToFollowUp.Show();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            new triage(((btn.Text).ToLower()).Trim());
            this.Hide();
            wait wait = new wait();
            wait.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaintOlder complaintOlder = new complaintOlder();
            complaintOlder.Show();
        }
    }

       
    }

