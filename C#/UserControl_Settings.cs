using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Morse_Translator
{
    public partial class UserControl_Settings : UserControl
    {
        private static UserControl_Settings instance = null;

        public static UserControl_Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserControl_Settings();
                }
                return instance;
            }
        }

        private Sound sound;

        public UserControl_Settings()
        {
            InitializeComponent();
            
            sound = Sound.Instance;
        }

        private void UserControl_Trainer_Load(object sender, EventArgs e)
        {
            
        }

        private void UserControl_Trainer_Enter(object sender, EventArgs e)
        {
            textBoxFrequency.Text = sound.Frequency.ToString();
            textBoxWords_Per_Minute.Text = sound.WPM.ToString();
            textBoxControl_Word.Text = sound.CodeWord.ToString();
        }

        private void NumbersOnlytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void updateSoundButton_Click(object sender, EventArgs e)
        {
            sound.Frequency = ushort.Parse(textBoxFrequency.Text);
            sound.WPM = ushort.Parse(textBoxWords_Per_Minute.Text);
            sound.CodeWord = textBoxControl_Word.Text;
        }
    }
}
