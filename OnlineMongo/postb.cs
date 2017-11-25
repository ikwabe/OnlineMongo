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
    public partial class postb : UserControl
    {
        public static postb _instance;
        public static postb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new postb();
                return _instance;
            }

        }
        public postb()
        {
            InitializeComponent();
        }

        private void photo_Click(object sender, EventArgs e)
        {
            line.Visible = true;
            line.Width = photo.Width;
            line.Left = photo.Left;

            //load photo upload form
            photoPost phP = new photoPost();
            phP.Show();

        }
    }
}
