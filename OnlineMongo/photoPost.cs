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
    public partial class photoPost : Form
    {
        public photoPost()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            panelCont();
            openFileDialog1.Filter = "(*.JPG; *.PNG) | *.JPG; *.PNG ";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                timer1.Start();

            }
            else
            {
                MessageBox.Show("No photo Uploaded");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            animator.ShowSync(panel1);
        }

        private void panelCont()
        {
            panel1.Visible = false;
            photoSttsTxt.Text = null;
            pictureBox1.Image = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            panelCont();
        }
    }
}
