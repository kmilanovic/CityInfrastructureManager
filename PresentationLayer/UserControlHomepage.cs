using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class UserControlHomepage : UserControl
    {

        private static UserControlHomepage _instance;
        public static UserControlHomepage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlHomepage();
                }
                return _instance;
            }
        }

        private UserControlHomepage()
        {
            InitializeComponent();
        }
    }
}
