using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMongo
{
    public partial class pics : UserControl
    {
        public pics()
        {
            InitializeComponent();
        }

        public void animateTH()
        {
            animate.Start();
            hideControl();
        }


        void showControl()
        {
            foreach (Control item in this.Controls)
            {
                animation.ShowSync(item);
                Application.DoEvents();
            }
        }

        void hideControl()
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = false;
                Application.DoEvents();
            }
        }

        private void animate_Tick_1(object sender, EventArgs e)
        {
            animate.Stop();
            showControl();
        }
    }
}
