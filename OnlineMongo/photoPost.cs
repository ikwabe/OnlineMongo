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
using System.IO;

namespace OnlineMongo
{
    public partial class photoPost : Form
    {
        public photoPost()
        {
            InitializeComponent();
        }
       
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            panelCont();
            openFileDialog1.Filter = "(*.JPG; *.PNG) | *.JPG; *.PNG ";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                timer1.Start();

            }
            else
            {
                MessageBox.Show("No photo Uploaded");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            animator.ShowSync(panel1);
        }

        //hidding panel and clear text function
        private void panelCont()
        {
            panel1.Visible = false;
            photoSttsTxt.Text = null;
            pictureBox1.Image = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            panelCont();
        }

        //the function to add a post
        private void addPostToDb()
        {
            DateTime pst_date = new DateTime();
            pst_date = DateTime.Today;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";
            string userId = "select * from users where username = '" + login.txt.Text + "'";



            try
            {
                con.Open();
               
                        byte[] images = null;
                        FileStream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);




                        MySqlDataAdapter ad;


                        //taking user id from the database
                        MySqlCommand com1 = new MySqlCommand(userId, con);
                        ad = new MySqlDataAdapter(com1);
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        string user_idc = table.Rows[0][0].ToString();
                        ad.Dispose();

                        int user_id = int.Parse(user_idc);
                        //
                        //string to insert data
                        string pic = "insert into post(image,status,user_id,pst_date) values(@image,'" + photoSttsTxt.Text + "','" + user_id + "', pst_date = '" + pst_date.ToLongDateString() + "')";

                        //command to insert photos
                        MySqlCommand com = new MySqlCommand(pic, con);
                        com.Parameters.Add(new MySqlParameter("@image", images));
                        com.ExecuteNonQuery();
                   

               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            if (photoSttsTxt.Text == "")
            {
                if(pictureBox1.Image == null)
                {
                    MessageBox.Show("Nothing To Post, Please Upload Photo");
                }
                else
                {
                    if(MessageBox.Show("Are you sure you want to post this photo without status","POST ALERT!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        addPostToDb();
                        panelCont();
                        postb pstb = new postb();
                        pstb.postTimer.Start();
                        MessageBox.Show("Posted");
                        

                    }
                    else
                    {

                    }

                }
               
            }
            else
            {
                addPostToDb();
                panelCont();
                postb pstb = new postb();
                pstb.postTimer.Start();
                MessageBox.Show("Posted");
               
            }

            
           
        }
    }
}
