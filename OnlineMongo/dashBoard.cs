﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
                timer1.Start();
                panel2.Visible = false;
                panel2.Width = 250;
                mnBtn.Location = new Point(222, mnBtn.Location.Y);
                panelAnimator.ShowSync(panel2);
                logo.Visible = true;
                panel4.Width = 810;
                pic.Instance.Width = 810;
                myProfile.Instance.Width = 810;
                hometb.Instance.Width = 810;
                aboutb.Instance.Width = 810;
                postb.Instance.Width = 810;
                classPage.Instance.Width = 810;
                friendtb.Instance.Width = 810;
                hometb.Instance.Dock = DockStyle.Fill;


            }
            else
            {
                panel2.Visible = false;
                panel2.Width = 50;
                logo.Visible = false;
                mnBtn.Location = new Point(12, mnBtn.Location.Y);
                panelAnimator.ShowSync(panel2);
                panel4.Width = 1015;
                pic.Instance.Width = 1015;
                myProfile.Instance.Width = 1015;
                hometb.Instance.Width = 1015;
                aboutb.Instance.Width = 1015;
                postb.Instance.Width = 1015;
                classPage.Instance.Width = 1015;
                friendtb.Instance.Width = 1015;
               


            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void photos_Click(object sender, EventArgs e)
        {
                line.Width = photos.Width;
                line.Left = photos.Left;
            line.Visible = true;
            classPage.Instance.Visible = false;
                aboutb.Instance.Visible = false;
                friendtb.Instance.Visible = false;
                postb.Instance.Visible = false;
                hometb.Instance.Visible = false;
                myProfile.Instance.Visible = false;
                composeMsg.Instance.Visible = false;
                inbonTab.Instance.Visible = false;
                draftTab.Instance.Visible = false;
                trashTab.Instance.Visible = false;
                settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            pic.Instance.BringToFront();
               
            if (panel2.Width == 50)
            {
                
                panel4.Controls.Add(pic.Instance);
                pic.Instance.Dock = DockStyle.Fill;
                picAnimation.ShowSync(pic.Instance);
            }
            else if(panel2.Width == 250)
            {
                panel4.Controls.Add(pic.Instance);
                pic.Instance.Dock = DockStyle.Fill;
                picAnimation.ShowSync(pic.Instance);
            }

            else
            {
                panel4.Controls.Add(pic.Instance);
                pic.Instance.Dock = DockStyle.Fill;
                picAnimation.ShowSync(pic.Instance);
            }
           
        }

        private void post_Click(object sender, EventArgs e)
        {
            line.Width = post.Width;
            line.Left = post.Left;
            line.Visible = true;
            pic.Instance.Visible = false;
            classPage.Instance.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            postb.Instance.BringToFront();
            panel4.Controls.Add(postb.Instance);
            postb.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(postb.Instance);

            if (panel2.Width == 50)
            {
                postb.Instance.Width = 1015;
                panel4.Controls.Add(postb.Instance);
                postb.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(postb.Instance);
            }

            else
            {
                panel4.Controls.Add(postb.Instance);
                postb.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(postb.Instance);
            }

        }

        private void friends_Click(object sender, EventArgs e)
        {
            line.Visible = true;
            line.Width = friends.Width;
            line.Left = friends.Left;
            pic.Instance.Visible = false;
            classPage.Instance.Visible = false;
            aboutb.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            friendtb.Instance.BringToFront();
            panel4.Controls.Add(friendtb.Instance);
            friendtb.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(friendtb.Instance);

            if (panel2.Width == 50)
            {
                friendtb.Instance.Width = 1015;
                panel4.Controls.Add(friendtb.Instance);
                friendtb.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(friendtb.Instance);
            }

            else
            {
                panel4.Controls.Add(friendtb.Instance);
                friendtb.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(friendtb.Instance);
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            line.Visible = true;
            line.Width = about.Width;
            line.Left = about.Left;
            pic.Instance.Visible = false;
            postb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            aboutb.Instance.BringToFront();
            panel4.Controls.Add(aboutb.Instance);
            aboutb.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(aboutb.Instance);

            if (panel2.Width == 50)
            {
                
                panel4.Controls.Add(aboutb.Instance);
                aboutb.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(aboutb.Instance);
            }

            else
            {
                panel4.Controls.Add(aboutb.Instance);
                aboutb.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(aboutb.Instance);

            }

            }

        private void home_Click(object sender, EventArgs e)
        {
            line.Visible = true;
            line.Width = home.Width;
            line.Left = home.Left;
            pic.Instance.Visible = false;
            postb.Instance.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            hometb.Instance.BringToFront();
            panel4.Controls.Add(hometb.Instance);
            hometb.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(hometb.Instance);

            if (panel2.Width == 50)
            {
                hometb.Instance.Width = 1015;
                panel4.Controls.Add(hometb.Instance);
                hometb.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(hometb.Instance);

            }

            else
            {
                panel4.Controls.Add(hometb.Instance);
                hometb.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(hometb.Instance);


            }

        }


        static void createDirectory()
        {
            string rootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\UdoRead";
           try
            {
                if (!Directory.Exists(rootDirectory)) { Directory.CreateDirectory(rootDirectory); }
                if (!Directory.Exists(rootDirectory + "\\Sent emails")) { Directory.CreateDirectory(rootDirectory + "\\Sent emails"); }
                if (!Directory.Exists(rootDirectory + "\\Videos")) { Directory.CreateDirectory(rootDirectory + "\\Videos"); }
                if (!Directory.Exists(rootDirectory + "\\Lectures")) { Directory.CreateDirectory(rootDirectory + "\\Lectures"); }
                if (!Directory.Exists(rootDirectory + "\\Books")) { Directory.CreateDirectory(rootDirectory + "\\Books"); }
                if (!Directory.Exists(rootDirectory + "\\Profile Photo(s)")) { Directory.CreateDirectory(rootDirectory + "\\Profile Photo(s)"); }
            }
            catch
            {

            }
               
           
        }
        private void dashBoard_Load_1(object sender, EventArgs e)
        {
            createDirectory();
            line.Visible = true;
            line.Width = home.Width;
            line.Left = home.Left;
            pic.Instance.Visible = false;
            postb.Instance.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            bunifuImageButton4.Visible = false;
            bunifuImageButton4.Location = new Point(1260, bunifuImageButton4.Location.Y);
            hometb.Instance.BringToFront();
            panel4.Controls.Add(hometb.Instance);
            hometb.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(hometb.Instance);
            panel2.Visible = true;
            panel2.Width = 50;
            panel4.Width = 1015;
            logo.Visible = false;
            mnBtn.Location = new Point(12, mnBtn.Location.Y);
            panelAnimator.ShowSync(panel2);
            hometb.Instance.Width = 1015;


        }

        private void myProfileBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            myProfile.Instance.BringToFront();
            panel4.Controls.Add(myProfile.Instance);
            myProfile.Instance.Dock = DockStyle.Fill;
            picAnimation.ShowSync(myProfile.Instance);

            if (panel2.Width == 50)
            {
                myProfile.Instance.Width = 1015;
                panel4.Controls.Add(myProfile.Instance);
                myProfile.Instance.Dock = DockStyle.Fill;
                picAnimation.ShowSync(myProfile.Instance);

            }

            else
            {
                panel4.Controls.Add(myProfile.Instance);
                myProfile.Instance.Dock = DockStyle.Fill;
                picAnimation.ShowSync(myProfile.Instance);

            }
        }

        private void myClassBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            classPage.Instance.BringToFront();
            panel4.Controls.Add(classPage.Instance);
            classPage.Instance.Dock = DockStyle.Fill;
            picAnimation.ShowSync(classPage.Instance);

            if (panel2.Width == 50)
            {
                classPage.Instance.Width = 1015;
                panel4.Controls.Add(classPage.Instance);
                classPage.Instance.Dock = DockStyle.Fill;
                picAnimation.ShowSync(classPage.Instance);

            }

            else
            {
                panel4.Controls.Add(classPage.Instance);
                classPage.Instance.Dock = DockStyle.Fill;
                picAnimation.ShowSync(classPage.Instance);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoTransition.ShowSync(logo);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            pinWindow pinwd = new pinWindow();
            pinwd.Show();
            pinwd.WindowState = FormWindowState.Minimized;
            this.Hide();
           
        }

        private void composeBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            composeMsg.Instance.BringToFront();
            panel4.Controls.Add(composeMsg.Instance);
            composeMsg.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(composeMsg.Instance);

            if (panel2.Width == 50)
            {
                composeMsg.Instance.Width = 1015;
                panel4.Controls.Add(composeMsg.Instance);
                composeMsg.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(composeMsg.Instance);

            }

            else
            {
                panel4.Controls.Add(composeMsg.Instance);
                composeMsg.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(composeMsg.Instance);
       
            }
        }

        private void inboxBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            inbonTab.Instance.BringToFront();
            panel4.Controls.Add(inbonTab.Instance);
            inbonTab.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(inbonTab.Instance);

            if (panel2.Width == 50)
            {
                inbonTab.Instance.Width = 1015;
                panel4.Controls.Add(inbonTab.Instance);
                inbonTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(inbonTab.Instance);

            }

            else
            {
                panel4.Controls.Add(inbonTab.Instance);
                inbonTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(inbonTab.Instance);

            }
        }

        private void draftBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            draftTab.Instance.BringToFront();
            panel4.Controls.Add(draftTab.Instance);
            draftTab.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(draftTab.Instance);

            if (panel2.Width == 50)
            {
                draftTab.Instance.Width = 1015;
                panel4.Controls.Add(draftTab.Instance);
                inbonTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(draftTab.Instance);

            }

            else
            {
                panel4.Controls.Add(draftTab.Instance);
                draftTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(draftTab.Instance);

            }
        }

        private void trashBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            trashTab.Instance.BringToFront();
            panel4.Controls.Add(trashTab.Instance);
            trashTab.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(trashTab.Instance);

            if (panel2.Width == 50)
            {
                trashTab.Instance.Width = 1015;
                panel4.Controls.Add(trashTab.Instance);
                trashTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(trashTab.Instance);

            }

            else
            {
                panel4.Controls.Add(trashTab.Instance);
                trashTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(trashTab.Instance);

            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            sentTab.Instance.Visible = false;
            settingTab.Instance.BringToFront();
            panel4.Controls.Add(settingTab.Instance);
            settingTab.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(settingTab.Instance);

            if (panel2.Width == 50)
            {
                settingTab.Instance.Width = 1015;
                panel4.Controls.Add(settingTab.Instance);
                settingTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(settingTab.Instance);

            }

            else
            {
                panel4.Controls.Add(settingTab.Instance);
                settingTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(settingTab.Instance);

            }

            
        }

        private void sentBtn_Click(object sender, EventArgs e)
        {
            pic.Instance.Visible = false;
            line.Visible = false;
            aboutb.Instance.Visible = false;
            friendtb.Instance.Visible = false;
            myProfile.Instance.Visible = false;
            postb.Instance.Visible = false;
            hometb.Instance.Visible = false;
            classPage.Instance.Visible = false;
            composeMsg.Instance.Visible = false;
            inbonTab.Instance.Visible = false;
            draftTab.Instance.Visible = false;
            trashTab.Instance.Visible = false;
            settingTab.Instance.Visible = false;
            sentTab.Instance.BringToFront();
            panel4.Controls.Add(sentTab.Instance);
            sentTab.Instance.Dock = DockStyle.Fill;
            tabAnimator.ShowSync(sentTab.Instance);

            if (panel2.Width == 50)
            {
                sentTab.Instance.Width = 1015;
                panel4.Controls.Add(sentTab.Instance);
                sentTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(sentTab.Instance);

            }

            else
            {
                panel4.Controls.Add(sentTab.Instance);
                sentTab.Instance.Dock = DockStyle.Fill;
                tabAnimator.ShowSync(sentTab.Instance);

            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panel4.Height = 600;
            bunifuImageButton4.Visible = true;
            bunifuImageButton3.Visible = false;
            bunifuImageButton1.Location = new Point(1320, bunifuImageButton1.Location.Y);
            bunifuImageButton2.Location = new Point(1260, bunifuImageButton2.Location.Y);
            bunifuImageButton3.Location = new Point(1290, bunifuImageButton3.Location.Y);
            bunifuImageButton4.Location = new Point(1290, bunifuImageButton4.Location.Y);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            panel4.Height = 336;
            this.WindowState = FormWindowState.Normal;
            bunifuImageButton3.Visible = true;
            bunifuImageButton4.Visible = false;
            bunifuImageButton1.Location = new Point(1063, bunifuImageButton1.Location.Y);
            bunifuImageButton2.Location = new Point(1003, bunifuImageButton2.Location.Y);
            bunifuImageButton3.Location = new Point(1033, bunifuImageButton3.Location.Y);
        }

        private void chooseQn_Click(object sender, EventArgs e)
        {
            secretWord sc = new secretWord();
            sc.Show();
        }
    }
}