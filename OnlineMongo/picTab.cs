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
    public partial class picTab : UserControl
    {
        public picTab()
        {
            InitializeComponent();
        }

        public void AnimateTH()
        {
            animate.Start();
            hideControl();
        }

        private void animate_Tick(object sender, EventArgs e)
        {
            animate.Stop();
            showControl();

        }

        void showControl()
        {
            foreach(Control item in this.Controls)
            {
                animator.ShowSync(item);
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
    }
}
