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
    public partial class UserControl_Trainer : UserControl
    {
        private static UserControl_Trainer instance = null;

        public static UserControl_Trainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserControl_Trainer();
                }
                return instance;
            }
        }

        private Trainer trainer;

        public UserControl_Trainer()
        {
            InitializeComponent();

            trainer = Trainer.Instance;
        }

        private void UserControl_Trainer_Load(object sender, EventArgs e)
        {
            trainer.LoadData();
        }
    }
}
