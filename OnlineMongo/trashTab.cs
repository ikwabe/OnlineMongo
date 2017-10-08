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
    public partial class trashTab : UserControl
    {
        public static trashTab _instance;
        public static trashTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new trashTab();
                return _instance;
            }
        }
        public trashTab()
        {
            InitializeComponent();
        }
    }
}
