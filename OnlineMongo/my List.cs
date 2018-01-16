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
using System.Text.RegularExpressions;
using System.IO;

namespace OnlineMongo
{
    public partial class my_List : Form
    {
        public my_List()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        string currentComputerUserName = Environment.UserName;
        //function to load the books to the panel
        private void loadBooks()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string readBooks = "select book_id, book_name from myclass where user_id = '" + login.user_id + "'";

            MySqlCommand com = new MySqlCommand(readBooks, con);

            MySqlDataReader reader;

            try
            {
                con.Open();

                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    //take the book name
                    string Tittle = reader.GetString("book_name");
                    //take the book id
                    string book_id = reader.GetString("book_id");
                    //Button
                    BunifuFlatButton book = new BunifuFlatButton();
                    book.Name = book_id;
                    book.TextFont = new Font("Cambria", 12, FontStyle.Bold);
                    book.Textcolor = Color.FromArgb(30, 0, 40);
                    book.Text = Tittle;
                    book.AutoSize = true;
                    book.Normalcolor = Color.Silver;
                    book.OnHovercolor = Color.FromArgb(32, 9, 191);
                    book.Activecolor = Color.DarkGreen;
                    book.Iconimage = null;
                    book.TextAlign = ContentAlignment.TopLeft;
                    book.BorderRadius = 5;
                    book.Click += new EventHandler(book_Click);
                    flowLayoutPanel1.Controls.Add(book);

                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        //function to load Lectures
        private void loadLectures()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string readBooks = "select lecture_id, lecture_name from lecture where user_id = '" + login.user_id + "'";
            MySqlDataReader reader;
            MySqlCommand com = new MySqlCommand(readBooks, con);
            DataTable table = new DataTable();


            try
            {
                con.Open();
                //Retreaving Book name


                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //Take the book
                    string Tittle = table.Rows[i][1].ToString();
                    //Button
                    BunifuFlatButton lecture = new BunifuFlatButton();
                    lecture.Name = table.Rows[i][0].ToString();
                    lecture.TextFont = new Font("Cambria", 12, FontStyle.Bold);
                    lecture.Textcolor = Color.FromArgb(30, 0, 40);
                    lecture.Text = Tittle;
                    lecture.AutoSize = true;
                    lecture.Normalcolor = Color.Silver;
                    lecture.OnHovercolor = Color.FromArgb(32, 9, 191);
                    lecture.Activecolor = Color.DarkGreen;
                    lecture.Iconimage = null;
                    lecture.TextAlign = ContentAlignment.TopLeft;
                    lecture.BorderRadius = 5;
                    lecture.Click += new EventHandler(book_Click);



                    flowLayoutPanel1.Controls.Add(lecture);


                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        //for books
        private static int book_id;
        private static bool bCheck = false;
        private void book_Click(object sender, EventArgs e)
        {
           
            var book = sender as BunifuFlatButton;

            book_id = int.Parse(book.Name);
           textBox1.Text = book.Text;
            bCheck = true;

        }

        private void my_List_Load(object sender, EventArgs e)
        {
            if(classPage.sendBooks == true)
            {
                loadBooks();
            }
            else if(classPage.sendLectures == true)
            {
                loadLectures();
            }
            else
            {
                MessageBox.Show("Load Error");
            }
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadBooks();
        }


        //for sending books
        private void sendBook()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            DateTime date = DateTime.Today;
            string bookdetail = "select * from myclass where book_id = '" + book_id + "'";
            MySqlCommand com1 = new MySqlCommand(bookdetail, con);
            MySqlDataAdapter ad;
            try
            {
                con.Open();


                ad = new MySqlDataAdapter(com1);

                DataTable table = new DataTable();
                ad.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No Book found.");
                }
                else
                {
                    byte[] book = (byte[])table.Rows[0][2];

                    //wrinting a Pdf File C:/Users/"+currentComputerUserName+"/AppData/Roaming/UdoRead/Videos/
                    using (Stream file = File.Create("C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Books/book.pdf"))
                    {
                        file.Write(book, 0, book.Length);
                    }

                    //taking the downloaded book
                    byte[] bytes = File.ReadAllBytes("C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Books/book.pdf");

                    string insert = "insert into sentitems(item,item_name,sender_email,receiver_email,date,status) values ( @item,'" + table.Rows[0][3] + "','" + login.user_email + "','" + emailTxt.Text + "','" + date.ToShortDateString() + "','New')";


                    MySqlCommand com = new MySqlCommand(insert, con);

                    if (emailTxt.Text == "" || emailTxt == null)
                    {
                        MessageBox.Show("Please enter the receiver email.");

                    }
                    else if (bCheck == false)
                    {
                        MessageBox.Show("Please select the book to send.");
                    }
                    else
                    {
                        Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                        if (!reg.IsMatch(emailTxt.Text))
                        {
                            MessageBox.Show("Please enter the valid receiver email");
                        }
                        else
                        {
                            //insert the item in the database
                            com.Parameters.AddWithValue("@item", bytes);
                            com.ExecuteNonQuery();
                            emailTxt.Text = null;
                            textBox1.Text = null;
                            items.check = true;
                            dashBoard.iCheck = true;
                            bCheck = false;
                            MessageBox.Show("Sent");

                        }


                    }

                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }


        //for sending lectures
        private void sendLecture()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            DateTime date = DateTime.Today;
            string bookdetail = "select * from lecture where lecture_id = '" + book_id + "'";
            MySqlCommand com1 = new MySqlCommand(bookdetail, con);
            MySqlDataAdapter ad;
            try
            {
                con.Open();


                ad = new MySqlDataAdapter(com1);

                DataTable table = new DataTable();
                ad.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No Lecture found.");
                }
                else
                {
                    byte[] book = (byte[])table.Rows[0][2];

                    //wrinting a Pdf File C:/Users/"+currentComputerUserName+"/AppData/Roaming/UdoRead/Videos/
                    using (Stream file = File.Create("C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Books/book.pdf"))
                    {
                        file.Write(book, 0, book.Length);
                    }

                    //taking the downloaded book
                    byte[] bytes = File.ReadAllBytes("C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Books/book.pdf");

                    string insert = "insert into sentitems(item,item_name,sender_email,receiver_email,date,status) values ( @item,'" + table.Rows[0][3] + "','" + login.user_email + "','" + emailTxt.Text + "','" + date.ToShortDateString() + "','New')";


                    MySqlCommand com = new MySqlCommand(insert, con);

                    if (emailTxt.Text == "" || emailTxt == null)
                    {
                        MessageBox.Show("Please enter the receiver email.");

                    }
                    else if (bCheck == false)
                    {
                        MessageBox.Show("Please select the book to send.");
                    }
                    else
                    {
                        Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                        if (!reg.IsMatch(emailTxt.Text))
                        {
                            MessageBox.Show("Please enter the valid receiver email");
                        }
                        else
                        {
                            //insert the item in the database
                            com.Parameters.AddWithValue("@item", bytes);
                            com.ExecuteNonQuery();
                            emailTxt.Text = null;
                            textBox1.Text = null;
                            items.check = true;
                            dashBoard.iCheck = true;
                            bCheck = false;
                            MessageBox.Show("Sent");

                        }


                    }

                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            if(classPage.sendBooks == true)
            {
                sendBook();
            }
            else if(classPage.sendLectures == true)
            {
                sendLecture();
            }
            else
            {
                MessageBox.Show("Sending Failed.");
            }
           
        }
    }
}
