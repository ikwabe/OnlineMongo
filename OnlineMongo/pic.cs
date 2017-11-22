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
    public partial class pic : UserControl
    {
        private PictureBox[] pictures;
        //creating instance to access this control
        public static pic _instance;
        public static pic Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new pic();
                return _instance;
            }

        }
        public pic()
        {
            InitializeComponent();
           
        }

        int i = 0 ;
        string[] name;
        PictureBox phot;
        private PictureBox photo()
        {
            openFileDialog1.Filter = "(*.JPG ; *.PNG)|*.JPG; *.PNG";
            MessageBox.Show("Please, Select Maximum of 20 images");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileNames;
                for (int j = 0; j < name.Length; j++)
                {
                    i++;
                    PictureBox phot = new PictureBox();
                    phot.Width = 300;
                    phot.Height = 172;
                    phot.Name = "pic" + i;
                    phot.SizeMode = PictureBoxSizeMode.Zoom;
                    phot.Cursor = Cursors.Hand;
                   

                    phot.Image = Image.FromFile(name[j]);

                    flowLayoutPanel1.Controls.Add(phot);

                }
               
            }
            

            return phot;
        }
      

        private void addPic_Click(object sender, EventArgs e)
        {
            photo();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dlg = sender as OpenFileDialog;
            if (20 < dlg.FileNames.Length)
            {
                MessageBox.Show("Please, Select Maximum of 20 images");
                e.Cancel = true;
            }
        }

       
    }

   

    
   
}   

