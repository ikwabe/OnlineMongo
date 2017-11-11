using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace OnlineMongo
{
    public partial class classPage : UserControl
    {
        public static classPage _instance;
        public static classPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new classPage();
                return _instance;
            }
        }
        public classPage()
        {
            InitializeComponent();
        }


       //A function to read data from the Myclass table
       

       
        private void addBook_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            
            bookDialogBox.Filter = "(*.pdf)|*.PDF";
            if (bookDialogBox.ShowDialog() == DialogResult.OK)
            {
                byte[] bytes = null;
                
                try
                {
                    bytes = File.ReadAllBytes(bookDialogBox.FileName);
                    
                    con.Open();
                    string check = "select book from myclass where book = '" + bookDialogBox.FileName + "'";
                    string checkIfEmpty = "select * from myclass";
                    string insert = "insert into myclass (uname,book) values ('" + login.txt.Text + "', @book)";
                    MySqlCommand com = new MySqlCommand(insert, con);
                    MySqlCommand com1 = new MySqlCommand(check, con);
                    MySqlCommand com2 = new MySqlCommand(checkIfEmpty, con);
                    DataTable table = new DataTable();
                    DataTable table1 = new DataTable();
                    MySqlDataReader reader;

                    reader = com2.ExecuteReader();
                    table1.Load(reader);
                    reader.Close();
                    //checking if the table is empty
                    if (table1.Rows.Count > 0)
                    {
                        MessageBox.Show("The table contains books ");
                        //check if the insertrd book is present
                        reader = com1.ExecuteReader();
                        table.Load(reader);
                        MessageBox.Show("Ready checked the books ");
                        reader.Close();

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Sorry, The is book already saved in the Database");
                        }
                        else
                        {
                            //insert the book in the database
                            MessageBox.Show("inserting the book " + bookDialogBox.FileName.ToString());
                            com.Parameters.AddWithValue("@book", bytes);
                            com.ExecuteNonQuery();
                        }

                    }
                    else
                    {
                        //insert the book in the database
                        MessageBox.Show("The table contains no books ");
                        com.Parameters.AddWithValue("@book", bytes);
                        com.ExecuteNonQuery();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(dialogResult == DialogResult.Yes)
                {
                    bookView.Items.Remove(bookView.SelectedItem);
                }
                
                
               
            }
            catch{
                MessageBox.Show("No Book selected", "Error", MessageBoxButtons.OK);
            }
 


           
        }

        private void addLecture_Click(object sender, EventArgs e)
        {
           
            bookDialogBox.Filter = "(*.pptx;*.ppt;*.docx;*.doc;*.txt;*.pdf)|*.PPTX;*.PPT;*.DOCX;*.DOC;*.TXT;*.PDF";
            if (bookDialogBox.ShowDialog() == DialogResult.OK)
            {
                lectureView.Items.Add(bookDialogBox.FileName);
            }
        }

        private void deleteLecture_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this lecture?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    lectureView.Items.Remove(lectureView.SelectedItem);
                }



            }
            catch
            {
                MessageBox.Show("No lecture selected", "Error", MessageBoxButtons.OK);
            }

        }

        private void addVideo_Click(object sender, EventArgs e)
        {
            bookDialogBox.Filter = "(*.mp4;*.mov;*.mkv;*.avi;*.wmv)|*.MP4;*.MOV;*.MKV;*.AVI;*.WMV";
            if (bookDialogBox.ShowDialog() == DialogResult.OK)
            {
                videoList.Items.Add(bookDialogBox.FileName);
            }
        }

        private void deleteVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if(videoList.Items.Count == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Video?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        videoList.Items.Remove(videoList.SelectedItem);

                    }

                }
                else
                {
                    MessageBox.Show("No video selected", "Error", MessageBoxButtons.OK);
                }

               


            }
            catch
            {
                MessageBox.Show("No video selected","Error",MessageBoxButtons.OK);
            }

           

        }

        private void watchVideo_Click(object sender, EventArgs e)
        {
            try
            {
                
                videoPlayer.Visible = true;
                hideVideoBtn.Visible = true;
                videogroupBox.Visible = false;
                videoPlayer.BringToFront();
                videoPlayer.URL = videoList.SelectedItem.ToString();
                videoPlayer.Ctlcontrols.play();
            }
            catch
            {
                videoPlayer.Visible = false;
                hideVideoBtn.Visible = false;
                MessageBox.Show("No video selected", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void hideVideoBtn_Click(object sender, EventArgs e)
        {
            videoPlayer.Visible = false;
            hideVideoBtn.Visible = false;
            videoPlayer.Ctlcontrols.stop();
        }

        private void requestVideo_Click(object sender, EventArgs e)
        {
            videogroupBox.Visible = true;
            videoPlayer.Visible = false;
            hideVideoBtn.Visible = false;
            videoPlayer.Ctlcontrols.stop();
        }


        private void requestBook_Click(object sender, EventArgs e)
        {
            bookgroupBox.Visible = true;
           
        }

        private void msgCancelBtn3_Click(object sender, EventArgs e)
        {
            videogroupBox.Visible = false;
        }

        private void msgCancelBtn2_Click(object sender, EventArgs e)
        {
            lecturegroupBox.Visible = false;
        }

        private void msgCancelBtn1_Click(object sender, EventArgs e)
        {
            bookgroupBox.Visible = false;
        }

        private void requestLecture_Click(object sender, EventArgs e)
        {
            lecturegroupBox.Visible = true;
        }

        private void openBookBtn_Click(object sender, EventArgs e)
        {
            readerPdf rd = new readerPdf();
            try
            {
                rd.axAcroPDF1.src = bookView.SelectedItem.ToString();
                rd.Show();
            }
            catch
            {
                MessageBox.Show("No book selected..!", "Alert", MessageBoxButtons.OK);
            }
            
        }
    }
}
