using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Bunifu.Framework.UI;
using System.IO;

namespace OnlineMongo
{
    public partial class items : Form
    {
        public items()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static bool check = false;
     
        private void loadItems()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
           
            string load = "select * from sentitems where receiver_email = '" + login.user_email + "' order by item_id DESC";
            MySqlCommand com = new MySqlCommand(load, con);
            MySqlDataAdapter da;
            DataTable table = new DataTable();
            try
            {
                con.Open();
                //taking the items from the database
                da = new MySqlDataAdapter(com);
                da.Fill(table);
               
                for(int j=0; j<table.Rows.Count; j++)
                {
                    //checking if the item is new(never opened)
                    if(table.Rows[j][6].ToString() == "New")
                    {
                        //creating a sign to show the item is new
                        Label sign = new Label();
                        sign.Text = "New";
                        sign.Font = new Font("Cambria", 8, FontStyle.Bold);
                        sign.ForeColor = Color.DarkGreen;
                       
                        //a lable to hold the name of the item
                        Label item = new Label();
                        item = new Label();
                        item.Name = table.Rows[j][0].ToString();
                      
                        item.ForeColor = Color.FromArgb(30,0,40);
                        item.Font = new Font("Cambria", 12, FontStyle.Bold);
                        item.Text = table.Rows[j][2].ToString();

                        //creating the butto to download the item
                        // Download Button
                        BunifuFlatButton bt = new BunifuFlatButton();
                        bt.Name = table.Rows[j][0].ToString();
                        bt.Text = "Download";
                        bt.Height = 30;
                        bt.Width = 120;
                       
                        bt.Normalcolor = Color.FromArgb(0, 122, 204);
                        bt.OnHovercolor = Color.FromArgb(32, 9, 191);
                        bt.Activecolor = Color.FromArgb(0, 122, 204);
                        bt.Iconimage = null;
                        bt.TextAlign = ContentAlignment.MiddleCenter;
                        bt.BorderRadius = 5;
                        bt.Click += new EventHandler(downloadBtn_Click);

                        // Delete Button
                        BunifuFlatButton bt1 = new BunifuFlatButton();
                        bt1.Name = table.Rows[j][0].ToString();
                        bt1.Text = "Delete";
                        bt1.Height = 30;
                        bt1.Width = 120;
                        bt1.Normalcolor = Color.FromArgb(0, 122, 204);
                        bt1.OnHovercolor = Color.FromArgb(32, 9, 191);
                        bt1.Activecolor = Color.FromArgb(0, 122, 204);
                        bt1.Iconimage = null;
                        bt1.TextAlign = ContentAlignment.MiddleCenter;
                        bt1.BorderRadius = 5;
                        bt1.Click += new EventHandler(deletebtn_Click);

                        //a panel to catch the rows
                        FlowLayoutPanel fly = new FlowLayoutPanel();
                        fly.Height = 40;
                        fly.Width = 850;
                        fly.AutoSize = true;
                        fly.FlowDirection = FlowDirection.LeftToRight;
                        fly.WrapContents = false;

                        //adding the controls to the dynamic panel
                        fly.Controls.Add(sign);
                        fly.Controls.Add(item);
                        fly.Controls.Add(bt);
                        fly.Controls.Add(bt1);

                        //adding the pannel to the mother flowpanel
                        flowLayoutPanel1.Controls.Add(fly);

                      

                    }
                    else
                    {
                        //creating a sign to show the item is new
                        Label sign = new Label();
                        sign.Text = "√";
                        sign.Font = new Font("Cambria", 9, FontStyle.Bold);
                        sign.ForeColor = Color.FromArgb(235, 60, 0);
                        //a lable to hold the name of the item
                        Label item = new Label();
                        item = new Label();
                        item.Name = table.Rows[j][0].ToString();
                      
                        item.ForeColor = Color.FromArgb(30, 0, 40);
                        item.Font = new Font("Cambria", 12, FontStyle.Bold);
                        item.Text = table.Rows[j][2].ToString();

                        //creating the butto to download the item
                        //Button
                        BunifuFlatButton bt = new BunifuFlatButton();
                        bt.Name = table.Rows[j][0].ToString();
                        bt.Text = "Download";
                        bt.Height = 30;
                        bt.Width = 120;
                       
                        bt.Normalcolor = Color.FromArgb(0, 122, 204);
                        bt.OnHovercolor = Color.FromArgb(32, 9, 191);
                        bt.Activecolor = Color.FromArgb(0, 122, 204);
                        bt.Iconimage = null;
                        bt.TextAlign = ContentAlignment.MiddleCenter;
                        bt.BorderRadius = 5;
                        bt.Click += new EventHandler(downloadBtn_Click);

                        // Delete Button
                        BunifuFlatButton bt1 = new BunifuFlatButton();
                        bt1.Name = table.Rows[j][0].ToString();
                        bt1.Text = "Delete";
                        bt1.Height = 30;
                        bt1.Width = 120;
                        bt1.Normalcolor = Color.FromArgb(0, 122, 204);
                        bt1.OnHovercolor = Color.FromArgb(32, 9, 191);
                        bt1.Activecolor = Color.FromArgb(0, 122, 204);
                        bt1.Iconimage = null;
                        bt1.TextAlign = ContentAlignment.MiddleCenter;
                        bt1.BorderRadius = 5;
                        bt1.Click += new EventHandler(deletebtn_Click);

                        //a panel to catch the rows
                        FlowLayoutPanel fly = new FlowLayoutPanel();
                        fly.Height = 40;
                        fly.Width = 850;
                        fly.AutoSize = true;
                        fly.FlowDirection = FlowDirection.LeftToRight;
                        fly.WrapContents = false;

                        //adding the controls to the dynamic panel
                        fly.Controls.Add(sign);
                        fly.Controls.Add(item);
                        fly.Controls.Add(bt);
                        fly.Controls.Add(bt1);

                        //adding the pannel to the mother flowpanel
                        flowLayoutPanel1.Controls.Add(fly);


                    }
                    da.Dispose();
                }

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //a function to handle download button events
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.pdf)|*.PDF";
            string load = "select * from sentitems where item_id = '" + button.Name + "'";
            string update = "update sentitems set status = 'Read' where item_id = '" + button.Name + "' ";
            MySqlCommand com = new MySqlCommand(load, con);
            MySqlCommand com1 = new MySqlCommand(update, con);
            MySqlDataAdapter da;
            DataTable table = new DataTable();
            MySqlDataReader rd;

            try
            {
                con.Open();
                //reading the file
                da = new MySqlDataAdapter(com);
                da.Fill(table);
                da.Dispose();

                if(save.ShowDialog() == DialogResult.OK)
                {
                    byte[] item = (byte[])table.Rows[0][1];

                    //saving the file in a specified directory
                    using (Stream file = File.Create(save.FileName))
                    {
                        file.Write(item, 0, item.Length);
                    }
                    //update the status to READ
                    rd = com1.ExecuteReader();
                    rd.Close();
                    //load the item again
                    check = true;
                    //item noticification check
                    dashBoard.iCheck = true;
                }
                else
                {

                }

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string delete = "delete from sentitems where item_id = '" + button.Name + "'";
            MySqlCommand com = new MySqlCommand(delete, con);
            MySqlDataReader rd;
            try
            {
                con.Open();
                if(MessageBox.Show("Deleting the item?","Alert",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete the item
                    rd = com.ExecuteReader();
                    rd.Close();
                    //item check
                    check = true;
                    //notisfication check
                    dashBoard.iCheck = true;

                }
                else
                {

                }
                

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void items_Load(object sender, EventArgs e)
        {
            //load the items in the database
            check = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check == true)
            {
                flowLayoutPanel1.Controls.Clear();
                loadItems();
                check = false;
            }
            else
            {

            }
        }

    }
}
