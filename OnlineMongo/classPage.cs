using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Bunifu.Framework.UI;
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

        private static bool Bcheck = false;
        private static bool Lcheck = false;
        private static bool Vcheck = false;
        string currentComputerUserName = Environment.UserName;
        private void loadBooks()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string readBooks = "select * from myclass where user_id = '"+ login.user_id +"'";
            MySqlDataAdapter da;
            MySqlCommand com = new MySqlCommand(readBooks, con);
            DataTable table = new DataTable();
            

            try
            {
                con.Open();
                //Retreaving Book name
                da = new MySqlDataAdapter(com);
                da.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //Take the book
                    string Tittle = table.Rows[i][3].ToString();
                    //Button
                    BunifuFlatButton book = new BunifuFlatButton();
                    book.Name = table.Rows[i][0].ToString();
                    book.TextFont = new Font("Cambria", 12, FontStyle.Bold);
                    book.Textcolor = Color.FromArgb(30,0,40);
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

        //for books
        private static int book_id;
       
        private void book_Click(object sender, EventArgs e)
        {
            Lcheck = false;
            Bcheck = true;
            Vcheck = false;

            var book = sender as BunifuFlatButton;
           
                book_id = int.Parse(book.Name);
               
        }

        //for lect
        private static int lect_id;
        private void lec_Click(object sender, EventArgs e)
        {

            Lcheck = true;
            Bcheck = false;
            Vcheck = false;
            var lect = sender as BunifuFlatButton;

            lect_id = int.Parse(lect.Name);

        }

        //for video
        private static int vid_id;
        private void video_Click(object sender, EventArgs e)
        {
            Lcheck = false;
            Bcheck = false;
            Vcheck = true;

            var video = sender as BunifuFlatButton;

            vid_id = int.Parse(video.Name);

        }

        //function to load Lectures
        private void loadLectures()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string readBooks = "select * from lecture where user_id = '" + login.user_id + "'";
            MySqlDataAdapter da;
            MySqlCommand com = new MySqlCommand(readBooks, con);
            DataTable table = new DataTable();


            try
            {
                con.Open();
                //Retreaving Book name
                da = new MySqlDataAdapter(com);
                da.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //Take the book
                    string Tittle = table.Rows[i][3].ToString();
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
                    lecture.Click += new EventHandler(lec_Click);



                    flowLayoutPanel2.Controls.Add(lecture);
                    

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        //function to load Lectures
        private void loadVideos()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string readBooks = "select * from video where user_id = '" + login.user_id + "'";
            MySqlDataAdapter da;
            MySqlCommand com = new MySqlCommand(readBooks, con);
            DataTable table = new DataTable();


            try
            {
                con.Open();
                //Retreaving Book name
                da = new MySqlDataAdapter(com);
                da.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //Take the book
                    string Tittle = table.Rows[i][2].ToString();
                    //Button
                    BunifuFlatButton video = new BunifuFlatButton();
                    video.Name = table.Rows[i][0].ToString();
                    video.TextFont = new Font("Cambria", 12, FontStyle.Bold);
                    video.Textcolor = Color.FromArgb(30, 0, 40);
                    video.Text = Tittle;
                    video.AutoSize = true;
                    video.Normalcolor = Color.Silver;
                    video.OnHovercolor = Color.FromArgb(32, 9, 191);
                    video.Activecolor = Color.DarkGreen;
                    video.Iconimage = null;
                    video.TextAlign = ContentAlignment.TopLeft;
                    video.BorderRadius = 5;
                    video.Click += new EventHandler(video_Click);



                   
                    flowLayoutPanel3.Controls.Add(video);
                   

                }

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
            con.ConnectionString = login.dbConnection;

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
                    string insert = "insert into myclass (user_id,book,book_name) values ('" + login.user_id + "', @book,'"+ bookDialogBox.SafeFileName +"')";
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
                            loadBookTimer.Start();
                        }

                    }
                    else
                    {
                        //insert the book in the database
                        MessageBox.Show("The table contains no books ");
                        com.Parameters.AddWithValue("@book", bytes);
                        com.ExecuteNonQuery();
                        loadBookTimer.Start();
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

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

            bookDialogBox.Filter = "(*.pdf)|*.PDF";
            if (bookDialogBox.ShowDialog() == DialogResult.OK)
            {
                byte[] bytes = null;

                try
                {
                    bytes = File.ReadAllBytes(bookDialogBox.FileName);

                    con.Open();
                    string check = "select book from myclass where book_name = '" + bookDialogBox.SafeFileName + "'";
                    string checkIfEmpty = "select * from lecture";
                    string insert = "insert into lecture (user_id,lecture,lecture_name) values ('" + login.user_id + "', @lecture,'" + bookDialogBox.SafeFileName + "')";
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
                            com.Parameters.AddWithValue("@lecture", bytes);
                            com.ExecuteNonQuery();
                            loadLectureTimer.Start();
                        }

                    }
                    else
                    {
                        //insert the book in the database
                        MessageBox.Show("The table contains no books ");
                        com.Parameters.AddWithValue("@lecture", bytes);
                        com.ExecuteNonQuery();
                        loadLectureTimer.Start();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            }

        private void deleteLecture_Click(object sender, EventArgs e)
        {
           

        }

        private void addVideo_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

            bookDialogBox.Filter = "(*.mp4;*.mov;*.avi;*.wmv)|*.MP4;*.MOV;*.AVI;*.WMV";
            if (bookDialogBox.ShowDialog() == DialogResult.OK)
            {
               
                
                File.Copy(@bookDialogBox.FileName, "C:/Users/"+currentComputerUserName+"/AppData/Roaming/UdoRead/Videos/" + bookDialogBox.SafeFileName + "",true);
                try
                {
                  
                    con.Open();
                    string check = "select video_name from video where video_name = '" + bookDialogBox.SafeFileName + "'";
                    string checkIfEmpty = "select * from video";
                    string insert = "insert into video (user_id,video_name) values ('" + login.user_id + "','" + bookDialogBox.SafeFileName + "')";
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
                        
                        //check if the insertrd video is present
                        reader = com1.ExecuteReader();
                        table.Load(reader);
                        reader.Close();

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Sorry, The is book already saved in the Database");
                        }
                        else
                        {
                            //insert the book in the database
                           
                            com.ExecuteNonQuery();
                            MessageBox.Show("Video uploaded ");
                            loadVideoTimer.Start();
                        }

                    }
                    else
                    {
                        //insert the book in the database
                        
                        com.ExecuteNonQuery();
                        MessageBox.Show("Video Uploaded ");
                        loadVideoTimer.Start();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        //deleting the selected video
        private void deleteVideo_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string getVideoName = "select * from video where video_id = '" + vid_id + "'";
            string delete = "delete from video where video_id = '" + vid_id + "'";
            MySqlDataAdapter da;
            MySqlCommand com = new MySqlCommand(getVideoName, con);
            MySqlCommand com1 = new MySqlCommand(delete, con);
            DataTable table = new DataTable();

            try
            {
                con.Open();
                if(Vcheck == true)
                {
                    da = new MySqlDataAdapter(com);
                    da.Fill(table);


                    //taking the file name to be deleted
                    string filename = table.Rows[0][2].ToString();
                   
                    //if the file exist in the direcory deletion perfomed
                    if (File.Exists("C:/Users/"+currentComputerUserName+"/AppData/Roaming/UdoRead/Videos/" + table.Rows[0][2].ToString() + ""))
                    {
                        File.Delete("C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Videos/" + table.Rows[0][2].ToString() + "");
                        com1.ExecuteNonQuery();
                        loadVideoTimer.Start();
                    }
                    //the video name exist only in the database deletion perfomed
                    else
                    {
                        com1.ExecuteNonQuery();
                        loadVideoTimer.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select the Video for deletion.");
                }
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();



            
           
        }

        private void watchVideo_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlDataAdapter ad;
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = login.dbConnection;
                string bookdetail = "select * from video where video_id = '" + vid_id + "'";
                MySqlCommand com = new MySqlCommand(bookdetail, con);

                try
                {

                    con.Open();

                    if(Vcheck == true)
                    {
                        // MySqlDataReader reader;
                        ad = new MySqlDataAdapter(com);
                        // reader = com.ExecuteReader();
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        try
                        {
                            //byte[] video = (byte[])table.Rows[0][2];


                            ////wrinting a Pdf File
                            //using (Stream file = File.Create("C:/Users/Shadrack Ikwabe/AppData/Roaming/UdoRead/Videos/video.mp4"))
                            //{
                            //    file.Write(video, 0, video.Length);
                            //}

                            //opening the video file
                            videoPlayer.Visible = true;
                            hideVideoBtn.Visible = true;
                            videogroupBox.Visible = false;
                            videoPlayer.BringToFront();
                            
                            videoPlayer.URL = "C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Videos/" + table.Rows[0][2].ToString() + "";
                            videoPlayer.Ctlcontrols.play();
                        }
                        catch
                        {

                        }

                        ad.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Please Select the video to play");
                    }
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
            catch
            {
                MessageBox.Show("No video selected..!", "Alert", MessageBoxButtons.OK);
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
            subjectTextBox3.Text = "VIDEO REQUEST";
            videogroupBox.Visible = true;
            videoPlayer.Visible = false;
            hideVideoBtn.Visible = false;
            videoPlayer.Ctlcontrols.stop();
        }


        private void requestBook_Click(object sender, EventArgs e)
        {
            bookgroupBox.Visible = true;
            subjectTextBox1.Text = "BOOK REQUEST";
           
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
            subjectTextBox2.Text = "LECTURE REQUEST";
        }



        private void openBookBtn_Click(object sender, EventArgs e)
        {
            readerPdf rd = new readerPdf();
            try
            {
                MySqlDataAdapter ad;
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = login.dbConnection;
                string bookdetail = "select * from myclass where book_id = '" + book_id + "'";
                MySqlCommand com = new MySqlCommand(bookdetail, con);

                try
                {

                    con.Open();
                    if(Bcheck == true)
                    {
                        // MySqlDataReader reader;
                        ad = new MySqlDataAdapter(com);
                        // reader = com.ExecuteReader();
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        try
                        {
                            byte[] book = (byte[])table.Rows[0][2];

                            //wrinting a Pdf File C:/Users/"+currentComputerUserName+"/AppData/Roaming/UdoRead/Videos/
                            using (Stream file = File.Create("C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Books/book.pdf"))
                            {
                                file.Write(book, 0, book.Length);
                            }

                            //opening the pdf file
                            rd.axAcroPDF1.src = "C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Books/book.pdf";
                            rd.Show();
                        }
                        catch
                        {

                        }

                        ad.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Please Select the book to read");
                    }
                    
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
            flowLayoutPanel1.Controls.Clear();
            loadBookTimer.Stop();
            loadBooks();
        }

        private void classPage_Load(object sender, EventArgs e)
        {
            Lcheck = false;
            Bcheck = false;
            Vcheck = false;
            loadBookTimer.Start();
            loadLectureTimer.Start();
            loadVideoTimer.Start();
        }

        private void openLectureBtn_Click(object sender, EventArgs e)
        {
            readerPdf rd = new readerPdf();
            try
            {
                MySqlDataAdapter ad;
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = login.dbConnection;
                string bookdetail = "select * from lecture where lecture_id = '" + lect_id + "'";
                MySqlCommand com = new MySqlCommand(bookdetail, con);

                try
                {

                    con.Open();
                    if(Lcheck == true)
                    {
                        // MySqlDataReader reader;
                        ad = new MySqlDataAdapter(com);
                        // reader = com.ExecuteReader();
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        try
                        {
                            byte[] book = (byte[])table.Rows[0][2];

                            //wrinting a Pdf File
                            using (Stream file = File.Create("C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Lectures/Lecture.pdf"))
                            {
                                file.Write(book, 0, book.Length);
                            }

                            //opening the pdf file
                            rd.axAcroPDF1.src = "C:/Users/" + currentComputerUserName + "/AppData/Roaming/UdoRead/Lectures/Lecture.pdf";
                            rd.Show();
                        }
                        catch
                        {

                        }

                        ad.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Lecture to View");
                    }
                   
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
        private static string senderEmail;
        private static string emailLocation;
        private void lectSendBtn_Click(object sender, EventArgs e)
        {
            //for renaming the file on inserting in a directory
            int i = 0;


            //for the while loop
            Boolean check = true;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

            //getting the computer user name for identifying the app directory location
            string currentComputerUserrName = Environment.UserName;

            //checking if the filename exist to avoid overiding
            while (check == true)
            {
                if (!File.Exists("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox2.Text + " by " + login.txt.Text + "(" + i + ").txt"))
                {

                    //creating a text file in the app directory
                    StreamWriter email = new StreamWriter("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox2.Text + " by " + login.txt.Text + "(" + i + ").txt");
                    email.WriteLine(composetextBox2.Text);
                    email.Close();
                    emailLocation = "C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox2.Text + " by " + login.txt.Text + "(" + i + ").txt";
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
                composetextBox2.Text = "";
                MessageBox.Show("Sent.");


            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            inbonTab.check = true;
            dashBoard.check = true;

        }

        private void loadLectureTimer_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            loadLectureTimer.Stop();
            loadLectures();
        }

        private void loadVideoTimer_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
            loadVideoTimer.Stop();
            loadVideos();
        }
       
        //a function to request a lecture
        private void sendBtn1_Click(object sender, EventArgs e)
        {
            //for renaming the file on inserting in a directory
            int i = 0;


            //for the while loop
            Boolean check = true;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

            //getting the computer user name for identifying the app directory location
            string currentComputerUserrName = Environment.UserName;

            //checking if the filename exist to avoid overiding
            while (check == true)
            {
                if (!File.Exists("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1.Text + " by " + login.txt.Text + "(" + i + ").txt"))
                {

                    //creating a text file in the app directory
                    StreamWriter email = new StreamWriter("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox1.Text + " by " + login.txt.Text + "(" + i + ").txt");
                    email.WriteLine(composetextBox1.Text);
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
                string subject = subjectTextBox1.Text + "(By " + login.txt.Text + ")";
                string insert = "insert into sentmail (mailsubject,sentmsg,senderemail,receiveremail,status) values ('" + subject + "', @sentmsg,'" + senderEmail + "', '" + toTextBox1.Text + "','New')";


                byte[] mail = null;


                //fill the sent email to the byte for uploading it to the database

                mail = File.ReadAllBytes(emailLocation);
                //command for inseting email to the database
                MySqlCommand com1 = new MySqlCommand(insert, con);

                //inserting the email text file to the database
                com1.Parameters.AddWithValue("@sentmsg", mail);
                com1.ExecuteNonQuery();
                composetextBox1.Text = "";
                MessageBox.Show("Sent.");


            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            inbonTab.check = true;
            dashBoard.check = true;
        }

       
        //a function to request a video
        private void sendBtn3_Click(object sender, EventArgs e)
        {
            //for renaming the file on inserting in a directory
            int i = 0;


            //for the while loop
            Boolean check = true;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;

            //getting the computer user name for identifying the app directory location
            string currentComputerUserrName = Environment.UserName;

            //checking if the filename exist to avoid overiding
            while (check == true)
            {
                if (!File.Exists("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox3.Text + " by " + login.txt.Text + "(" + i + ").txt"))
                {

                    //creating a text file in the app directory
                    StreamWriter email = new StreamWriter("C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox3.Text + " by " + login.txt.Text + "(" + i + ").txt");
                    email.WriteLine(composetextBox3.Text);
                    email.Close();
                    emailLocation = "C:/Users/" + currentComputerUserrName + "/AppData/Roaming/UdoRead/Sent emails/" + subjectTextBox3.Text + " by " + login.txt.Text + "(" + i + ").txt";
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
                string subject = subjectTextBox3.Text + "(By " + login.txt.Text + ")";
                string insert = "insert into sentmail (mailsubject,sentmsg,senderemail,receiveremail,status) values ('" + subject + "', @sentmsg,'" + senderEmail + "', '" + toTextBox3.Text + "','New')";


                byte[] mail = null;


                //fill the sent email to the byte for uploading it to the database

                mail = File.ReadAllBytes(emailLocation);
                //command for inseting email to the database
                MySqlCommand com1 = new MySqlCommand(insert, con);

                //inserting the email text file to the database
                com1.Parameters.AddWithValue("@sentmsg", mail);
                com1.ExecuteNonQuery();
                composetextBox3.Text = "";
                MessageBox.Show("Sent.");


            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            inbonTab.check = true;
            dashBoard.check = true;

        }

        private void toTextBox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
