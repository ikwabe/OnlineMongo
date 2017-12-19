﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace OnlineMongo
{
    public partial class pictureView : Form
    {
        public pictureView()
        {
            InitializeComponent();
        }

        private void pictureView_Load(object sender, EventArgs e)
        {
            //takin the image from the database
            MySqlDataAdapter ad;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string detail = "select * from post where post_id = '" + postb.photName + "'";
            MySqlCommand com = new MySqlCommand(detail, con);

            try
            {

                con.Open();
                // MySqlDataReader reader;
                ad = new MySqlDataAdapter(com);
                // reader = com.ExecuteReader();
                DataTable table = new DataTable();
                ad.Fill(table);
                try
                {
                    byte[] img = (byte[])table.Rows[0][1];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                catch
                {

                }

                ad.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Headerpanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //double click for maximizing or minimizing the form
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
               CancelBtn.Location = new Point(1270, CancelBtn.Location.Y);
                //CancelBtn.BringToFront();

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                CancelBtn.Location = new Point(841, CancelBtn.Location.Y);
            }
        }
    }
}