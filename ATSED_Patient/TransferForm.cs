﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Data.SqlClient;

namespace ATSED_Patient
{
    public partial class TransferForm : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");
        string id;
        public TransferForm()
        {
            InitializeComponent();
            string sd = " ";
            this.Show();            
            this.Location = new Point(-1000, -1000);
            //this.Visible = false;
            submit.Hide();
            label27.Text = sd;
            label24.Text = sd;
            label26.Text = sd;
            label38.Text = sd;
            //**//
            label40.Text = sd;
            //**//
            label47.Text = sd;
            //**//
            label48.Text = sd;
            //**//
            label41.Text = sd;
            //**//
            label42.Text = sd;
            //**//
            label49.Text = sd;
            //**//
            label44.Text = sd;
            //**//
            label51.Text = sd;
            //**//
            label52.Text = sd;
            //**//
            label45.Text = sd;
            //**//
            label53.Text = sd;
            //**//
            label46.Text = sd;
            label25.Text = sd;
            label28.Text = sd;
            this.AutoScroll = false;
            var pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                var bmp = new Bitmap(Width, Height);
                this.DrawToBitmap(bmp, new Rectangle(Point.Empty, this.Size));
                ev.Graphics.DrawImageUnscaled(bmp, ev.MarginBounds.Location);
                ev.HasMorePages = false;
            };

            var dlg = new PrintPreviewDialog();
            dlg.Document = pd;

            pd.Print();

            //serviceDone serviceDone = new serviceDone();
            //serviceDone.Show();
            this.Hide();
        }
        public TransferForm(string id)
        {
            InitializeComponent();
            this.id = id;
            this.StartPosition = FormStartPosition.Manual;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.Location = new Point(-1000, -1000);
            this.Show();
            label25.Text = id;
            label28.Text = id;
            //**//
            cn.Open();
            SqlCommand cmd = new SqlCommand("select enName from diagnosedPatients where id="+ id +";", cn);
            string s = cmd.ExecuteScalar().ToString();
            label27.Text = s;
            cmd = new SqlCommand("select arName from diagnosedPatients where id="+id+";", cn);
            s = cmd.ExecuteScalar().ToString();
            label24.Text = s;
            cmd = new SqlCommand("select age from diagnosedPatients where id="+ id+";", cn);
            s = cmd.ExecuteScalar().ToString();
            label26.Text = s;
            label38.Text = s;
            //**//
            cmd = new SqlCommand("select ar_nat from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label40.Text = s;
            //**//
            cmd = new SqlCommand("select nat from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label47.Text = s;
            //**//
            cmd = new SqlCommand("select en_work from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label48.Text = s;
            //**//
            cmd = new SqlCommand("select ar_work from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label41.Text = s;
            //**//
            cmd = new SqlCommand("select first_date from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label42.Text = s;
            //**//
            cmd = new SqlCommand("select xray_details from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label49.Text = s;
            //**//
            cmd = new SqlCommand("select second_date from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label44.Text = s;
            //**//
            cmd = new SqlCommand("select days from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label51.Text = s;
            //**//
            cmd = new SqlCommand("select diagnosis from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label52.Text = s;
            //**//
            cmd = new SqlCommand("select ar_diagnosis from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label45.Text = s;
            //**//
            cmd = new SqlCommand("select doctor from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label53.Text = s;
            //**//
            cmd = new SqlCommand("select ar_doctor from printing where time = (select max(time) from printing where id =" + id + " AND type='Transfer to specialized clinic');", cn);
            s = cmd.ExecuteScalar().ToString();
            label46.Text = s;


            cn.Close();

        }


        private void submit_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            submit.Hide();
            this.AutoScroll = false;
            var pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                var bmp = new Bitmap(Width, Height);
                this.DrawToBitmap(bmp, new Rectangle(Point.Empty, this.Size));
                ev.Graphics.DrawImageUnscaled(bmp, ev.MarginBounds.Location);
                ev.HasMorePages = false;
            };

            var dlg = new PrintPreviewDialog();
            dlg.Document = pd;

            pd.Print();

            serviceDone serviceDone = new serviceDone();
            serviceDone.Show();
            this.Hide();
        }


    }
}
