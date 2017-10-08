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
    public partial class draftTab : UserControl
    {
        public static draftTab _instance;
        public static draftTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new draftTab();
                return _instance;
            }
        }
        public draftTab()
        {
            InitializeComponent();
        }
    }
}
