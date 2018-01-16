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
        private int count;
        string computerUserName = Environment.UserName;
        private void loadItems()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
           
            string load = "select item_id,item_name,status from sentitems where receiver_email = '" + login.user_email + "' order by item_id DESC";
            MySqlCommand com = new MySqlCommand(load, con);
           
            DataTable table = new DataTable();
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();
                count = table.Rows.Count;
                if (count == 0)
                {
                    //a lable to hold the name of the item
                    Label item = new Label();
                    item = new Label();
                    item.AutoSize = true;
                    item.ForeColor = Color.FromArgb(235, 60, 0);
                    item.Font = new Font("Cambria", 15, FontStyle.Bold);
                    item.Text = "Sorry, You Have No Items To View -:)";

                    //seperator for the emails
                    BunifuSeparator spr = new BunifuSeparator();
                    spr.LineThickness = 2;
                    spr.Height = 1;
                    spr.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    spr.LineColor = Color.FromArgb(0, 122, 204);
                    spr.Transparency = 50;

                    //a panel to catch the rows
                    FlowLayoutPanel fly = new FlowLayoutPanel();
                    fly.Height = 40;
                    fly.Width = 850;
                    fly.AutoSize = true;
                    fly.FlowDirection = FlowDirection.LeftToRight;
                    fly.WrapContents = false;

                    //adding the controls to the dynamic panel
                    fly.Controls.Add(item);

                    //adding the pannel to the mother flowpanel
                    flowLayoutPanel1.Controls.Add(fly);
                    flowLayoutPanel1.Controls.Add(spr);

                }
                else
                {
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    //taking the item id
                    string item_id = reader.GetString("item_id");
                    //taking th enam of the item
                    string item_name = reader.GetString("item_name");
                    //checking the status of the item
                    string status = reader.GetString("status");

                    //checking if the item is new(never opened)
                    if (status == "New")
                    {
                        //creating a sign to show the item is new
                        Label sign = new Label();
                        sign.Text = "New";
                        sign.Font = new Font("Cambria", 8, FontStyle.Bold);
                        sign.ForeColor = Color.DarkGreen;

                        //a lable to hold the name of the item
                        Label item = new Label();
                        item = new Label();
                        item.Name = item_id;
                        item.Width = 500;
                        item.ForeColor = Color.FromArgb(30, 0, 40);
                        item.Font = new Font("Cambria", 12, FontStyle.Bold);
                        item.Text = item_name;

                        //creating the butto to download the item
                        // Download Button
                        BunifuFlatButton bt = new BunifuFlatButton();
                        bt.Name = item_id;
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
                        bt1.Name = item_id;
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

                        //seperator for the emails
                        BunifuSeparator spr = new BunifuSeparator();
                        spr.LineThickness = 2;
                        spr.Height = 1;
                        spr.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                        spr.LineColor = Color.FromArgb(235, 60, 0);
                        spr.Transparency = 50;

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
                        flowLayoutPanel1.Controls.Add(spr);



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
                        item.Name = item_id;
                        item.Width = 500;
                        item.ForeColor = Color.FromArgb(129, 129, 131);
                        item.Font = new Font("Cambria", 12, FontStyle.Regular);
                        item.Text = item_name;

                        //creating the butto to download the item
                        //Button
                        BunifuFlatButton bt = new BunifuFlatButton();
                        bt.Name = item_id;
                        bt.Text = "View";
                        bt.Height = 30;
                        bt.Width = 120;

                        bt.Normalcolor = Color.DarkGray;
                        bt.OnHovercolor = Color.DimGray;
                        bt.Activecolor = Color.DarkGray;
                        bt.Iconimage = null;
                        bt.TextAlign = ContentAlignment.MiddleCenter;
                        bt.BorderRadius = 5;
                        bt.Click += new EventHandler(viewBtn_Click);
                        
                        // Delete Button
                        BunifuFlatButton bt1 = new BunifuFlatButton();
                        bt1.Name = item_id;
                        bt1.Text = "Delete";
                        bt1.Height = 30;
                        bt1.Width = 120;
                        bt1.Normalcolor = Color.DarkGray;
                        bt1.OnHovercolor = Color.DimGray;
                        bt1.Activecolor = Color.DarkGray;
                        bt1.Iconimage = null;
                        bt1.TextAlign = ContentAlignment.MiddleCenter;
                        bt1.BorderRadius = 5;
                        bt1.Click += new EventHandler(deletebtn_Click);

                            //Redownload Button
                            BunifuFlatButton bt2 = new BunifuFlatButton();
                            bt2.Name = item_id;
                            bt2.Text = "Re-Download";
                            bt2.Height = 30;
                            bt2.Width = 120;

                            bt2.Normalcolor = Color.DarkGray;
                            bt2.OnHovercolor = Color.DimGray;
                            bt2.Activecolor = Color.DarkGray;
                            bt2.Iconimage = null;
                            bt2.TextAlign = ContentAlignment.MiddleCenter;
                            bt2.BorderRadius = 5;
                            bt2.Click += new EventHandler(downloadBtn_Click);

                            //seperator for the emails
                            BunifuSeparator spr = new BunifuSeparator();
                        spr.LineThickness = 2;
                        spr.Height = 1;
                        spr.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                        spr.LineColor = Color.FromArgb(235, 60, 0);
                        spr.Transparency = 50;


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
                        fly.Controls.Add(bt2);

                            //adding the pannel to the mother flowpanel
                            flowLayoutPanel1.Controls.Add(fly);
                        flowLayoutPanel1.Controls.Add(spr);


                    }




                }
            }
                reader.Close();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //a function to handle download button events
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.pdf)|*.PDF";
            string load = "select * from sentitems where item_id = '" + button.Name + "' and receiver_email = '"+login.user_email+"'";
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

               
                    byte[] item = (byte[])table.Rows[0][1];
                   
                    //saving the file in a specified directory
                    using (Stream file = File.Create("C:/Users/"+computerUserName+"/AppData/Roaming/UdoRead/Item(s)/item.pdf"))
                    {
                        file.Write(item, 0, item.Length);
                    }
                    //update the status to READ
                    rd = com1.ExecuteReader();
                    rd.Close();
                    
                    
                    

                //uploading the item to the database after download
                string insert = "insert into myclass (user_id,book,book_name) values ('" + login.user_id + "', @book,'" + table.Rows[0][2] + "')";
                MySqlCommand com2 = new MySqlCommand(insert, con);
                byte[] bytes = null;

                try
                {
                    bytes = File.ReadAllBytes("C:/Users/" + computerUserName + "/AppData/Roaming/UdoRead/Item(s)/item.pdf");
                    //insert the book in the database
                    com2.Parameters.AddWithValue("@book", bytes);
                    com2.ExecuteNonQuery();
                    //load the item again
                    check = true;

                    //item noticification check
                    dashBoard.iCheck = true;

                    //activate boockCheckTimer
                    classPage.bookTimerCheck = true;
                }
                catch
                {
                    MessageBox.Show("Download Failed.");
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            readerPdf rd = new readerPdf();
           
              
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = login.dbConnection;
                string bookdetail = "select item from sentitems where item_id = '" + button.Name + "'";
                MySqlCommand com = new MySqlCommand(bookdetail, con);
                DataTable table = new DataTable();
                MySqlDataReader reader;

              try
              {
                    con.Open();
                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();

                    byte[] book = (byte[])table.Rows[0][0];

                            //wrinting a Pdf File C:/Users/"+currentComputerUserName+"/AppData/Roaming/UdoRead/Videos/
                            using (Stream file = File.Create("C:/Users/" + computerUserName + "/AppData/Roaming/UdoRead/Books/book.pdf"))
                            {
                                file.Write(book, 0, book.Length);
                            }

                            //opening the pdf file
                            rd.axAcroPDF1.src = "C:/Users/" + computerUserName + "/AppData/Roaming/UdoRead/Books/book.pdf";
                            rd.Show();       

                }
                catch (MySqlException ex)
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
            this.WindowState = FormWindowState.Maximized;
            //load the items in the database
            closeBtn.Location = new Point(1320, closeBtn.Location.Y);
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
