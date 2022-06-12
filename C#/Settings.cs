﻿using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Morse_Translator
{
    internal class Settings
    {
        private static Settings instance = null;
        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                }
                return instance;
            }
        }

        private Sound sound = Sound.Instance;

        private string settingsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Morse Translator/Settings";

        public void startUp() //TODO: да се провери дали може да се прави по по-добър начин
        {
            if (!Directory.Exists(settingsDirectory))
            {
                Directory.CreateDirectory(settingsDirectory);
            }
        }

        public void loadSound()
        {
            try
            {
                using (StreamReader r = File.OpenText(Path.Combine(this.settingsDirectory, "sound.json")))
                {
                    string json = r.ReadToEnd();
                    Sound newSound = JsonConvert.DeserializeObject<Sound>(json);
                    
                    sound.Frequency = newSound.Frequency;
                    sound.WPM = newSound.WPM;
                    sound.CodeWord = newSound.CodeWord;
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Необходимите файлове не можаха да бъдат намерени.", "Error");
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                MessageBox.Show("Проблем в четенето на JSON файловете.\nЛипстващ елемент.", "Error");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void saveSound()
        {
            using (StreamWriter file = File.CreateText(Path.Combine(this.settingsDirectory, "sound.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, sound);
            }
        }
    }
}
