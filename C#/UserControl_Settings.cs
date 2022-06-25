using System;
using System.Collections.Generic;
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
        private Settings settings;
        private API_Worker api;

        public UserControl_Settings()
        {
            InitializeComponent();

            sound = Sound.Instance;
            settings = Settings.Instance;
            api = API_Worker.Instance;
        }

        private void UserControl_Trainer_Load(object sender, EventArgs e)
        {

        }

        private void UserControl_Trainer_Enter(object sender, EventArgs e)
        {
            comboBoxFrequency.Text = sound.Frequency.ToString();
            comboBoxWords_Per_Minute.Text = sound.WPM.ToString();
            textBoxControl_Word.Text = sound.CodeWord.ToString();
            this.updateLanguageList();
        }

        //TODO: не работи
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Return && e.KeyChar == (char)Keys.Back) e.Handled = true;
        }

        private void updateSoundButton_Click(object sender, EventArgs e) //TODO: при отваряне на падащото меню, автоматично се попълва стойност с написаното начално шисло
        {

            if (!String.IsNullOrEmpty(comboBoxFrequency.Text) &&
                !String.IsNullOrEmpty(comboBoxWords_Per_Minute.Text) &&
                !String.IsNullOrEmpty(textBoxControl_Word.Text))
            {
                if (ushort.Parse(comboBoxFrequency.Text) >= 200 && ushort.Parse(comboBoxFrequency.Text) <= 44000 &&
                    ushort.Parse(comboBoxWords_Per_Minute.Text) >= 1 && ushort.Parse(comboBoxWords_Per_Minute.Text) <= 60)
                {
                    sound.Frequency = ushort.Parse(comboBoxFrequency.Text);
                    sound.WPM = ushort.Parse(comboBoxWords_Per_Minute.Text);
                    sound.CodeWord = textBoxControl_Word.Text;

                    settings.saveSound();
                    sound.setWaveOut();

                    if ((sender as Button).Name == updateSoundButton.Name) MessageBox.Show("Sound settings updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Frequency must be between 200 and 44000 Hz and Words Per Minute must be greater than 1 and less than 60.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please enter all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void resetSoundButton_Click(object sender, EventArgs e)
        {
            comboBoxFrequency.SelectedIndex = 1;
            comboBoxWords_Per_Minute.SelectedIndex = 1;
            textBoxControl_Word.Text = "PARIS";

            this.updateSoundButton_Click(sender, e);

            MessageBox.Show("Sound settings reset to default.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateLanguageList()
        {
            languagesListBox.Items.Clear();
            List<String> apiLanguages = api.getLanguages();


            //TODO: има лек лаг докато проверява дали може да свали данни от сървъра (когато сървъра не е онлайн или не може да се дотъпи)
            if (apiLanguages != null)
            {
                foreach (var item in apiLanguages)
                {
                    if (Language.getLanguages().Contains(item)) languagesListBox.Items.Add(item, true);
                    else languagesListBox.Items.Add(item);
                }
                languagesListBox.Enabled = true;
            }
            else
            {
                foreach (var item in Language.getLanguages())
                {
                    languagesListBox.Items.Add(item, true);
                }

                languagesListBox.Enabled = false;
            }
        }

        private void updateLanguagesButton_Click(object sender, EventArgs e)
        {
            List<String> languages = new List<String>();
            foreach (var item in languagesListBox.CheckedItems)
            {
                languages.Add(item.ToString());
            }

            api.downloadLanguages(languages);
            this.updateLanguageList();
        }

        private void downloadAllLanguagesButton_Click(object sender, EventArgs e)
        {
            api.downloadLanguages(null);
            this.updateLanguageList();
        }
    }
}
