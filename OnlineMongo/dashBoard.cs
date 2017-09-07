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
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }

        private void mnBtn_Click(object sender, EventArgs e)
        {
            if(panel2.Width == 50)
            {
                panel2.Visible = false;
                panel2.Width = 250;
                mnBtn.Location = new Point(222, mnBtn.Location.Y);
                panelAnimator.ShowSync(panel2);
               


            }
            else
            {
                panel2.Visible = false;
                panel2.Width = 50;
                mnBtn.Location = new Point(12, mnBtn.Location.Y);
                panelAnimator.ShowSync(panel2);
        

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            login lgn = new login();
            lgn.Show();
        }

        private void photos_Click(object sender, EventArgs e)
        {
            line.Width = photos.Width;
            line.Left = photos.Left;
        }

        private void post_Click(object sender, EventArgs e)
        {
            line.Width = post.Width;
            line.Left = post.Left;
        }

        private void friends_Click(object sender, EventArgs e)
        {
            line.Width = friends.Width;
            line.Left = friends.Left;
        }

        private void about_Click(object sender, EventArgs e)
        {
            line.Width = about.Width;
            line.Left = about.Left;
        }
    }
}
