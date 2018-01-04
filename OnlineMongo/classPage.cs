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
using iTextSharp.text;

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

        //function to read books to datagridview

            private void loadBooks()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string readBooks = "select book_name 'Book Name(s)' from myclass where uname = '"+ login.txt.Text +"'";
            
            MySqlCommand com = new MySqlCommand(readBooks, con);
            DataTable table = new DataTable();
            MySqlDataReader reader;

            try
            {
                con.Open();
                //Retreaving Book name
                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();
  //appending the book name to the DataGrid view
                bookDataGrid.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

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
                    string check = "select book from myclass where book_name = '" + bookDialogBox.SafeFileName + "'";
                    string checkIfEmpty = "select * from myclass";
                    string insert = "insert into myclass (uname,book,book_name) values ('" + login.txt.Text + "', @book,'"+ bookDialogBox.SafeFileName +"')";
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
                            timer1.Start();
                        }

                    }
                    else
                    {
                        //insert the book in the database
                        MessageBox.Show("The table contains no books ");
                        com.Parameters.AddWithValue("@book", bytes);
                        com.ExecuteNonQuery();
                        timer1.Start();
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
                    //bookView.Items.Remove(bookView.SelectedItem);
                }
                
                
               
            }
            catch{
                MessageBox.Show("No Book selected", "Error", MessageBoxButtons.OK);
            }
 


           
        }

        private void addLecture_Click(object sender, EventArgs e)
        {
           
            bookDialogBox.Filter = "(*.txt;*.pdf)|*.TXT;*.PDF";
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

        string selectedWord;
        private void bookDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            try
            {
                DataGridViewRow selectedIndex = bookDataGrid.Rows[index];
                selectedWord = selectedIndex.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void openBookBtn_Click(object sender, EventArgs e)
        {
            readerPdf rd = new readerPdf();
            try
            {
                MySqlDataAdapter ad;
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
                string bookdetail = "select * from myclass where book_name = '" + selectedWord + "'";
                MySqlCommand com = new MySqlCommand(bookdetail, con);

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
                        byte[] book = (byte[])table.Rows[0][2];
                        MemoryStream ms = new MemoryStream(book);

                       
                        //FileStream fstream = new FileStream("book.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        //fstream.Write(book, 0, book.Length);

                        //rd.axAcroPDF1.LoadDocument(ms);


                        rd.Show();
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
            catch
            {
                MessageBox.Show("No book selected..!", "Alert", MessageBoxButtons.OK);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            loadBooks();
        }

        private void classPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void openLectureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (lectureView.SelectedItem != null)
                {
                    readerPdf rd = new readerPdf();
                    rd.axAcroPDF1.src = lectureView.SelectedItem.ToString();
                    rd.Show();
                }
                else
                {
                    MessageBox.Show("Please select the Lecture for open");
                }
            }
            catch
            {
                MessageBox.Show("Please select the Lecture for open");
            }
        }
        private static string senderEmail;
        private static string emailLocation;
        private void lectSendBtn_Click(object sender, EventArgs e)
        {
            int i = 0;


            //for the while loop
            Boolean check = true;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";

            //getting the computer user name for identifying the app directory location
            string currentComputerUserrName = Environment.UserName;

            //checking if the filename exist to avoid overiding
            while (check == true)
            {
                if (!File.Exists("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1.Text + " by " + login.txt.Text + "(" + i + ").txt"))
                {

                    //creating a text file in the app directory
                    StreamWriter email = new StreamWriter("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1.Text + " by " + login.txt.Text + "(" + i + ").txt");
                    //writing to a text file the words from the richtext box.
                    email.WriteLine(composetextBox2.Text);
                    email.Close();
                    emailLocation = "C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1.Text + " by " + login.txt.Text + "(" + i + ").txt";
                    check = false;
                }
                else
                {

                }
                i++;
            }

            string sendmail = "select * from users where username = '" + login.txt.Text + "'";

            //command for retreiving email from the database
            MySqlCommand com = new MySqlCommand(sendmail, con);
            MySqlDataAdapter ad;

            try
            {
                con.Open();
                //retrieving sender email from the database
                ad = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                ad.Fill(table);
                senderEmail = table.Rows[0][3].ToString();
                ad.Dispose();
                string subject = subjectTextBox2.Text + "(By " + login.txt.Text + ")";
                string insert = "insert into sentmail (mailsubject,sentmsg,senderemail,receiveremail,status) values ('" + subject + "', @sentmsg,'" + senderEmail + "', '" + toTextBox2.Text + "','New')";


                byte[] mail = null;


                //fill the sent email to the byte for uploading it to the database

                mail = File.ReadAllBytes(emailLocation);
                //command for inseting email to the database
                MySqlCommand com1 = new MySqlCommand(insert, con);

                //inserting the email text file to the database
                com1.Parameters.AddWithValue("@sentmsg", mail);
                com1.ExecuteNonQuery();

                MessageBox.Show("Message Sent.");
                toTextBox2.Text = null;
                composetextBox2.Text = null;
                subjectTextBox2.Text = null;
                inbonTab.check = true;
                dashBoard.check = true;

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
    }
}
