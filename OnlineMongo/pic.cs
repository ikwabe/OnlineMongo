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
            pictures = new PictureBox[20];
        }
        private void createControl()
        {
            for (var i = 0; i < 20; i++)
            {
                var newPicturebox = new PictureBox();
                newPicturebox.Width = 150;
                newPicturebox.Height = 150;

                pictures[i] = SizeImage(newPicturebox, i);
            }
        }

        string[] names;
        private void getNames()
        {
            openFileDialog1.Filter = "(*.JPG)|*.JPG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                names = openFileDialog1.FileNames;
            }
        }
        private PictureBox SizeImage(PictureBox pb, int i)
        {



            try
            {
                Image img = Image.FromFile(names[i]);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = img;

            }
            catch
            {


            }
            return pb;
        }

        private void display()
        {
            for (var i = 0; i < 20; i++)
            {
                pictures[i].Left = (i * 160) + 100;
                pictures[i].Top = 50;
                if (i > 9)
                {

                    for (var j = 0; j <= i - (j + 10); j++)
                    {

                        pictures[i].Left = (j * 160) + 100;
                        pictures[i].Top = 200;
                       panel2.Controls.Add(pictures[i]);

                    }

                }
                else
                {
                    panel2.Controls.Add(pictures[i]);
                }

            }
        }

        private void addPic_Click(object sender, EventArgs e)
        {
            getNames();
            createControl();
            display();
        }

    }

   

    
   
}   

