using NAudio.Wave;
using System;
using System.Threading;

namespace Morse_Translator
{
    internal class Sound
    {
        private static Sound instance = null;
        public static Sound Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sound();
                }
                return instance;
            }
        }

        private WaveOut waveOut = new WaveOut();
        private SineWaveProvider32 sineWaveProvider = new SineWaveProvider32();

        private Translator translator = Translator.Instance;

        private ushort frequency = 550;
        private ushort wpm = 20;
        private string codeWord = "PARIS";

        public ushort Frequency { get { return this.frequency; } set { this.frequency = value; } }
        public ushort WPM { get { return this.wpm; } set { this.wpm = value; } }
        public string CodeWord { get { return this.codeWord; } set { this.codeWord = value; } }


        public void setWaveOut()
        {
            this.sineWaveProvider.Frequency = this.frequency;
            this.sineWaveProvider.SetWaveFormat(16000, 1); // 16kHz mono

            this.waveOut.Dispose();
            this.waveOut.Init(sineWaveProvider);
        }

        public void playMorseAsSound(string text)
        {
            try
            {
                ushort delay = (ushort)(((double)(60 / this.wpm) / translator.languageToMorse(this.codeWord + " ").Length) * 700); // 50ms = ~0,3 sec

                if (this.frequency != 550) setWaveOut();

                foreach (var item in text)
                {
                    if (item == '.')
                    {
                        this.waveOut.Play();
                        Thread.Sleep(delay);
                    }
                    else if (item == '-')
                    {
                        this.waveOut.Play();
                        Thread.Sleep(delay * 3);
                    }
                    else Thread.Sleep(delay);

                    this.waveOut.Stop();
                }

                System.GC.Collect();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
