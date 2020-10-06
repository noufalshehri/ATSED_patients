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
    public partial class age : Form
    {
        public age()
        {
            InitializeComponent();
          
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {

                    this.Hide();
                    redCases redCases = new redCases();
            redCases.Show();
        
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            youngerThanSeven younger = new youngerThanSeven();
            younger.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaint complaint = new complaint("age");
            complaint.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            older older = new older();
            older.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
