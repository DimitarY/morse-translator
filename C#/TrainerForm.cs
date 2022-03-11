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
    public partial class TrainerForm : Form
    {
        private Translator Translator;
        private Trainer Trainer;

        public TrainerForm()
        {
            InitializeComponent();

            Translator = Translator.Instance;
            Trainer = Trainer.Instance;
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
