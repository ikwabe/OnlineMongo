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
    public partial class friendtb : UserControl
    {
        public static friendtb _instance;
        public static friendtb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new friendtb();
                return _instance;
            }

        }
        public friendtb()
        {
            InitializeComponent();
        }
    }
}
