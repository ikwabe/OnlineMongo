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
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }

        int count = 0;
        private void startup_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressB.animated = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count > 4)
            {
                timer1.Stop();
                this.Close();
            }
            else
            {
                count++;
            }
        }
    }
}
