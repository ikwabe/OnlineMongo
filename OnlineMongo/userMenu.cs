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
    public partial class userMenu : Form
    {
        public userMenu()
        {
            InitializeComponent();
        }

        public static bool reply = false;
        private void openBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userInfo uInf = new userInfo();
            uInf.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void messageBtn_Click(object sender, EventArgs e)
        {
            reply = true;
            inbonTab.reply = false;
            userInfo.reply = false;
            instantMessage insMs = new instantMessage();
            insMs.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Function will be activated soon. Thank you");

        }
    }
}
