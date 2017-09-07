using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMongo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp sgp = new signUp();
            sgp.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure you want to close?","Close",MessageBoxButtons.OKCancel) == DialogResult.OK){
                Application.Exit();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            
                    label3.Text = "You enterd a wrong Password or Username";
            
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resetPwd rsp = new resetPwd();
            rsp.Show();
            this.Hide();
        }
    }
}
