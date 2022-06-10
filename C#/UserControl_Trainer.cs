using System;
using System.Drawing;
using System.Linq;
using System.Threading;
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
        private Sound sound;
        private Thread playThread = new Thread(() =>
        {
            Thread.CurrentThread.IsBackground = true;
        });

        private int panelX, panelY, panelSizeW, panelSizeH, num, space;

        public UserControl_Trainer()
        {
            InitializeComponent();

            trainer = Trainer.Instance;
            sound = Sound.Instance;
        }

        private void UserControl_Trainer_Load(object sender, EventArgs e)
        {
            
        }

        private void UserControl_Trainer_Enter(object sender, EventArgs e)
        {
            selectionBox.Items.Clear();

            foreach (var item in Language.getLanguages()) selectionBox.Items.Add(item);

            bottomPanel.Controls.Clear();
        }

        private void LoadPanelsSizeAndData(string s_language)
        {
            bottomPanel.Controls.Clear();

            trainer.LoadData(s_language, checkBoxNumbers.Checked, checkBoxSymbols.Checked);
            this.panelX = 10; this.panelY = 10; this.panelSizeW = trainer.MaxLength * 13; this.panelSizeH = 60; this.num = 1;

            while ((this.panelX + this.panelSizeW) < bottomPanel.Width)
            {
                this.num++;
                this.panelX += this.panelSizeW;
            }

            if (trainer.Codes.Count < num - 1) this.panelX = (bottomPanel.Width - (this.panelSizeW * trainer.Codes.Count)) / (trainer.Codes.Count + 1);
            else this.panelX = ((bottomPanel.Width - this.panelX) - (trainer.Codes.Count < (this.num - 1) * 4 ? 0 : 10)) / this.num;

            this.space = this.panelX;
        }

        private void AddPanel(int panelNumber, string text1, string text2, bool isVisible = true)
        {
            Panel p = new Panel();
            p.Name = "p" + panelNumber;
            p.Parent = bottomPanel;
            p.Visible = isVisible;
            p.Location = new Point(this.panelX, this.panelY);
            p.Size = new Size(this.panelSizeW, this.panelSizeH);
            p.BackColor = Color.White;

            Label lbl1 = new Label();
            lbl1.Name = "lbl1";
            lbl1.Parent = p;
            lbl1.Location = new Point(0, 0);
            lbl1.Size = new Size(this.panelSizeW, this.panelSizeH / 2);
            lbl1.Text = text1;
            lbl1.TextAlign = ContentAlignment.MiddleCenter;

            Label lbl2 = new Label();
            lbl2.Name = "lbl2";
            lbl2.Parent = p;
            lbl2.Location = new Point(0, lbl1.Height);
            lbl2.Size = new Size(this.panelSizeW, this.panelSizeH / 2);
            lbl2.Text = text2;
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            lbl2.Cursor = Cursors.Hand;
            lbl2.Click += new EventHandler(code_Click);

            this.panelX += this.panelSizeW + this.space;
            if (this.panelX + this.panelSizeW > bottomPanel.Width)
            {
                this.panelX = this.space;
                this.panelY += this.panelSizeH + 10;
            }
        }

        private void code_Click(object sender, EventArgs e)
        {
            playThread = new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                sound.playMorseAsSound((sender as Label).Text);
            });
            playThread.Start();
        }

        private void ChangeData(string s_language)
        {
            LoadPanelsSizeAndData(s_language);

            bottomPanel.Visible = false;

            for (int i = 0; i < trainer.Codes.Count; i++)
            {
                AddPanel(i, trainer.Symbols[i].ToString(), trainer.Codes[i].ToString());
            }

            bottomPanel.Visible = false ? bottomPanel.Visible = true : bottomPanel.Visible = true;

            System.GC.Collect();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (sender is CheckBox && selectionBox.SelectedIndex < 0)
            {
                (sender as CheckBox).Checked = false;
                MessageBox.Show("Please select a language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectionBox.Select();
            }
            else
            {
                if (selectionBox.SelectedIndex >= 0) ChangeData(selectionBox.SelectedItem.ToString());
                else
                {
                    MessageBox.Show("Please select a language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selectionBox.Select();
                }
            }
        }
    }
}
