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
    public partial class transferToFollowUp : Form
    {
        public transferToFollowUp()
        {
            InitializeComponent();
            TransferForm t = new TransferForm();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }
    }
}
