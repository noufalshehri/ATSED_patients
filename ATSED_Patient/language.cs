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
    public partial class language : Form
    {
        string go;
        public language(string s)
        {
            InitializeComponent();
            go = s;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Id Id = new Id(go);
            Id.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
                this.Hide();
                IdAr IdAr = new IdAr(go);
                IdAr.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
