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
   
    public partial class signUp : Form
    {
       login lgn = new login();
        public signUp()
        {
            InitializeComponent();
           
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // lgn.Show();
            dashBoard dsb = new dashBoard();
            dsb.Show();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            lgn.Show();

        }
    }
}
