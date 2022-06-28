using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Translator
{
    public partial class UserControl_HomePage : UserControl
    {
        private static UserControl_HomePage instance = null;

        public static UserControl_HomePage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserControl_HomePage();
                }
                return instance;
            }
        }

        public UserControl_HomePage()
        {
            InitializeComponent();
        }

        private void UserControl_HomePage_Load(object sender, EventArgs e)
        {

        }

        private void UserControl_HomePage_Enter(object sender, EventArgs e)
        {

        }
    }
}
