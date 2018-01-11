using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnlineMongo
{
    public partial class settingTab : UserControl
    {
        public static settingTab _instance;
        public static settingTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new settingTab();
                return _instance;
            }
        }
        public settingTab()
        {
            InitializeComponent();
        }

       private static string username;
        private void load_name()
        {
            MySqlDataAdapter da;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string detail = "select * from users where username = '" + login.txt.Text + "'";
            MySqlCommand com = new MySqlCommand(detail, con);
            DataTable table = new DataTable();

            try
            {
                con.Open();

                //taking a username
                da = new MySqlDataAdapter(com);
                da.Fill(table);
                da.Dispose();

                //taking a username of a login user
                username = table.Rows[0][6].ToString();

                MySqlDataReader reader;
                reader = com.ExecuteReader();
                while (reader.Read())
                {

                    string fname = reader.GetString("fname");
                    string lname = reader.GetString("lname");
                    userPrflName.Text = fname + " " + lname;
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void settingTab_Load(object sender, EventArgs e)
        {

            load_name();
            aboutGrp.Visible = false;
            favoriteGrp.Visible = false;
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            editBtn.Visible = true;
            ageDate.MaxDate = DateTime.Today;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            aboutGrp.Visible = false;
            favoriteGrp.Visible = false;
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            editBtn.Visible = true;
            usernameTxt.Text = "";
            workTxt.Text = "";
            nationalityTxt.Text = "";
            educationTxt.Text = "";
            fromTxt.Text = "";
            musicTxt.Text = "";
            videoTxt.Text = "";
            actorTxt.Text = "";
            bookTxt.Text = "";
            seriesTxt.Text = "";
            gameTxt.Text = "";
            channelTxt.Text = "";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            aboutGrp.Visible = true;
            usernameTxt.Text = username;
            favoriteGrp.Visible = true;
            editBtn.Visible = false;
            cancelBtn.Visible = true;
            saveBtn.Visible = true;
        }

        private void changePINBtn_Click(object sender, EventArgs e)
        {
            pinWindow2 pn = new pinWindow2();
            pn.Show();
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
           
            changePwd chp = new changePwd();
            chp.Show();
        }
        private static string sex;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            if(maleRadioBtn.Checked == true)
            {
                sex = maleRadioBtn.Text;
            }
            else if(femaleRadioBtn.Checked == true)
            {
                sex = femaleRadioBtn.Text;
            }

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.dbConnection;
            string update = "update  users set username = '" + usernameTxt.Text + "', bday = '" + ageDate.Value.ToShortDateString() + "', sex = '" + sex + "', work = '" + workTxt.Text + "', nationality = '" + nationalityTxt.Text + "', education = '" + educationTxt.Text + "', home = '" + fromTxt.Text + "', music = '" + musicTxt.Text + "', video = '" + videoTxt.Text + "', actor = '" + actorTxt.Text + "', book = '" + bookTxt.Text + "', series = '" + seriesTxt.Text + "', game = '" + gameTxt.Text + "', channel =  '" + channelTxt.Text + "' where username = '" + login.txt.Text + "'";
           
            MySqlCommand com = new MySqlCommand(update, con);
           
            MySqlDataReader reader;
            try
            {
                con.Open();
                if (usernameTxt.Text == "" || workTxt.Text == "" || nationalityTxt.Text == "" || educationTxt.Text == "" || fromTxt.Text == "" || musicTxt.Text == "" || videoTxt.Text == "" ||actorTxt.Text == "" || bookTxt.Text == "" || seriesTxt.Text == "" || gameTxt.Text == "" || channelTxt.Text == "")
                    {
                        if (MessageBox.Show("Some of the fields are not well filled. Accepting edit will led to inconsistence in your profile Details. Make sure the Birthdate is correct. Are you sure you want to save the details?", "Verify", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if(usernameTxt.Text == "")
                            {
                            MessageBox.Show("Username can not be empty.");
                            }
                            else
                            {
                           
                                reader = com.ExecuteReader();
                                reader.Close();
                                usernameTxt.Text = "";
                                workTxt.Text = "";
                                nationalityTxt.Text = "";
                                educationTxt.Text = "";
                                fromTxt.Text = "";
                                musicTxt.Text = "";
                                videoTxt.Text = "";
                                actorTxt.Text = "";
                                bookTxt.Text = "";
                                seriesTxt.Text = "";
                                gameTxt.Text = "";
                                channelTxt.Text = "";
                                aboutGrp.Visible = false;
                                favoriteGrp.Visible = false;
                                saveBtn.Visible = false;
                                cancelBtn.Visible = false;
                                editBtn.Visible = true;
                            }
                           
                        }
                        else
                        {
                       
                        }

                    }
                    else
                    {
                    if (MessageBox.Show("Make sure the Birthdate is correct. Are you sure you want to save the details?", "Verify", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                            reader = com.ExecuteReader();
                            reader.Close();
                            usernameTxt.Text = "";
                            workTxt.Text = "";
                            nationalityTxt.Text = "";
                            educationTxt.Text = "";
                            fromTxt.Text = "";
                            musicTxt.Text = "";
                            videoTxt.Text = "";
                            actorTxt.Text = "";
                            bookTxt.Text = "";
                            seriesTxt.Text = "";
                            gameTxt.Text = "";
                            channelTxt.Text = "";
                            aboutGrp.Visible = false;
                            favoriteGrp.Visible = false;
                            saveBtn.Visible = false;
                            cancelBtn.Visible = false;
                            editBtn.Visible = true;
                        
                    }
                    else
                    {

                    }
                        
                    }
                   
                   
            }
            catch
            {
                MessageBox.Show("User "+usernameTxt.Text +" already exist. Please change the username");

            }
            con.Close();

           
        }

        private void usernameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

       
    }
}
