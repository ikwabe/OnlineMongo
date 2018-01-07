using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OnlineMongo
{
    public partial class hometb : UserControl
    {
        public static hometb _instance;
        public static hometb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new hometb();
                return _instance;
            }

        }

       
        public hometb()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(searchTxt.Text);
        }

        private void fowardBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void facebookBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.facebook.com");
        }

        private void youTubeBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com");
        }

        private void googleBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void whatsappBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("web.whatsapp.com");
        }

        private void utorrentBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("extratorrents.ch");
        }

        private void alibabaBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.alibaba.com");
        }

        private void gmailBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("mail.google.com");
        }

        private void yahooBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.yahoo.com");
        }

        private void ebayBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.ebay.com");
        }

        private void amazonBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.amazon.com");
        }

        private void ymailBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("in.mail.yahoo.com");
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            searchTxt.Text = webBrowser1.Url.ToString();
           
        }

        private void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(this, new EventArgs());
            }
        }

        private void hometb_Load(object sender, EventArgs e)
        {

            webBrowser1.ScriptErrorsSuppressed = true;  
        }

       
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Increment(Convert.ToInt32(e.CurrentProgress));
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);

            }
            catch
            {

            }
        }
    }
}
