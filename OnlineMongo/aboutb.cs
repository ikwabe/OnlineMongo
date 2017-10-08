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
    public partial class aboutb : UserControl
    {
        public static aboutb _instance;
        public static aboutb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new aboutb();
                return _instance;
            }
        }
        public aboutb()
        {
            InitializeComponent();
        }
    }
}
