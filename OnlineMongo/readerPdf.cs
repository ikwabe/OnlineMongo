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
    public partial class readerPdf : Form
    {
        public readerPdf()
        {
            InitializeComponent();
        }

        private void Headerpanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                CancelBtn.Location = new Point(1281, 725);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                CancelBtn.Location = new Point(841, 490);
            }
            
        }


        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
