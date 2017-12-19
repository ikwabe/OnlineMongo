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

namespace OnlineMongo
{
    public partial class secretWord : Form
    {
        public secretWord()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void chooseQn_Click(object sender, EventArgs e)
        {
            cusSecQn.Visible = false;
            chooseQn.Visible = false;
            seComboBox.Visible = true;
            changeQn.Visible = true;
        }

        private void changeQn_Click(object sender, EventArgs e)
        {
            cusSecQn.Visible = true;
            chooseQn.Visible = true;
            seComboBox.Visible = false;
            changeQn.Visible = false;
        }

        public static string secQnC;
        private void setSecBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = udoread;";

            

            string secQnT = "update  users set secqn = '" + cusSecQn.Text + "' where username = '" + login.txt.Text + "'";
            try
            {
                secQnC = "update  users set secqn = '" + seComboBox.SelectedItem.ToString() + "' where username = '" + login.txt.Text + "'";
            }
            catch
            {
                
            }
             
            string secAnsw = "update  users set secword = '" + secword.Text + "' where username = '" + login.txt.Text + "'";

            MySqlCommand com = new MySqlCommand(secQnT, con);
            MySqlCommand com1 = new MySqlCommand(secQnC, con);
            MySqlCommand com2 = new MySqlCommand(secAnsw, con);

            MySqlDataReader reader;
            MySqlDataReader reader2;

            try
            {
                con.Open();
                if(seComboBox.Visible == true && cusSecQn.Visible == false)
                {
                    
                    try
                    {
                        if(seComboBox.Text != "Choose the question...")
                        {
                            if(secword.Text != "")
                            {
                                //inserting the question from combobox
                                reader = com1.ExecuteReader();
                                reader.Close();


                                //inserting the secret word`s answer
                                reader2 = com2.ExecuteReader();
                                reader2.Close();
                                MessageBox.Show("Your secret word is " + secword.Text + ", and it is successiful saved.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Please set an Answer for The Question.");
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Please Select the Queston");
                        }
                       
                    }
                    catch
                    {
                        MessageBox.Show("Please select the Question.");
                    }
                    
                }
                else if(cusSecQn.Visible == true && seComboBox.Visible == false)
                {
                    if (cusSecQn.Text != "")
                    {
                        if(secword.Text != "")
                        {
                            //inserting the question from textBox
                            reader = com.ExecuteReader();
                            reader.Close();

                            //inserting the secret word`s answer
                            reader2 = com2.ExecuteReader();
                            reader2.Close();
                            MessageBox.Show("Your secret word is " + secword.Text + ", and it is successiful saved.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please set an Answer for The Question.");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please Write Your Question.");
                    }
                }
                else
                {
                    MessageBox.Show("Both are Visible");
                }

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }
    }
}
