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
    public partial class ageAr : Form
    {
        public ageAr()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            redCasesAr redCasesAr = new redCasesAr();
            redCasesAr.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            youngerThanSevenAr younger = new youngerThanSevenAr();
            younger.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaintAr complaint = new complaintAr("ageAr");
            complaint.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            olderAr older = new olderAr();
            older.Show();
        }
    }
}
