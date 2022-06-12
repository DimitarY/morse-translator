namespace Morse_Translator
{
    partial class UserControl_Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelWords_Per_Minute = new System.Windows.Forms.Label();
            this.textBoxControl_Word = new System.Windows.Forms.TextBox();
            this.labelControl_Word = new System.Windows.Forms.Label();
            this.sountPanel = new System.Windows.Forms.Panel();
            this.updateSoundButton = new System.Windows.Forms.Button();
            this.resetSoundButton = new System.Windows.Forms.Button();
            this.soundPanelLabel = new System.Windows.Forms.Label();
            this.comboBoxFrequency = new System.Windows.Forms.ComboBox();
            this.comboBoxWords_Per_Minute = new System.Windows.Forms.ComboBox();
            this.sountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFrequency
            // 
            this.labelFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrequency.Location = new System.Drawing.Point(18, 31);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(71, 16);
            this.labelFrequency.TabIndex = 2;
            this.labelFrequency.Text = "Frequency";
            // 
            // labelWords_Per_Minute
            // 
            this.labelWords_Per_Minute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWords_Per_Minute.AutoSize = true;
            this.labelWords_Per_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWords_Per_Minute.Location = new System.Drawing.Point(18, 60);
            this.labelWords_Per_Minute.Name = "labelWords_Per_Minute";
            this.labelWords_Per_Minute.Size = new System.Drawing.Size(113, 16);
            this.labelWords_Per_Minute.TabIndex = 4;
            this.labelWords_Per_Minute.Text = "Words Per Minute";
            // 
            // textBoxControl_Word
            // 
            this.textBoxControl_Word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxControl_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxControl_Word.Location = new System.Drawing.Point(137, 86);
            this.textBoxControl_Word.Name = "textBoxControl_Word";
            this.textBoxControl_Word.Size = new System.Drawing.Size(100, 22);
            this.textBoxControl_Word.TabIndex = 7;
            // 
            // labelControl_Word
            // 
            this.labelControl_Word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl_Word.AutoSize = true;
            this.labelControl_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl_Word.Location = new System.Drawing.Point(18, 89);
            this.labelControl_Word.Name = "labelControl_Word";
            this.labelControl_Word.Size = new System.Drawing.Size(85, 16);
            this.labelControl_Word.TabIndex = 6;
            this.labelControl_Word.Text = "Control Word";
            // 
            // sountPanel
            // 
            this.sountPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sountPanel.Controls.Add(this.comboBoxWords_Per_Minute);
            this.sountPanel.Controls.Add(this.labelWords_Per_Minute);
            this.sountPanel.Controls.Add(this.comboBoxFrequency);
            this.sountPanel.Controls.Add(this.textBoxControl_Word);
            this.sountPanel.Controls.Add(this.soundPanelLabel);
            this.sountPanel.Controls.Add(this.resetSoundButton);
            this.sountPanel.Controls.Add(this.updateSoundButton);
            this.sountPanel.Controls.Add(this.labelFrequency);
            this.sountPanel.Controls.Add(this.labelControl_Word);
            this.sountPanel.Location = new System.Drawing.Point(5, 5);
            this.sountPanel.Name = "sountPanel";
            this.sountPanel.Size = new System.Drawing.Size(250, 160);
            this.sountPanel.TabIndex = 0;
            // 
            // updateSoundButton
            // 
            this.updateSoundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateSoundButton.BackColor = System.Drawing.Color.White;
            this.updateSoundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateSoundButton.FlatAppearance.BorderSize = 0;
            this.updateSoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSoundButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateSoundButton.Location = new System.Drawing.Point(162, 122);
            this.updateSoundButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateSoundButton.Name = "updateSoundButton";
            this.updateSoundButton.Size = new System.Drawing.Size(75, 25);
            this.updateSoundButton.TabIndex = 1;
            this.updateSoundButton.Text = "Update";
            this.updateSoundButton.UseVisualStyleBackColor = false;
            this.updateSoundButton.Click += new System.EventHandler(this.updateSoundButton_Click);
            // 
            // resetSoundButton
            // 
            this.resetSoundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetSoundButton.BackColor = System.Drawing.Color.White;
            this.resetSoundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetSoundButton.FlatAppearance.BorderSize = 0;
            this.resetSoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetSoundButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetSoundButton.Location = new System.Drawing.Point(21, 122);
            this.resetSoundButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetSoundButton.Name = "resetSoundButton";
            this.resetSoundButton.Size = new System.Drawing.Size(75, 25);
            this.resetSoundButton.TabIndex = 0;
            this.resetSoundButton.Text = "Reset";
            this.resetSoundButton.UseVisualStyleBackColor = false;
            this.resetSoundButton.Click += new System.EventHandler(this.resetSoundButton_Click);
            // 
            // soundPanelLabel
            // 
            this.soundPanelLabel.AutoSize = true;
            this.soundPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soundPanelLabel.ForeColor = System.Drawing.Color.Gray;
            this.soundPanelLabel.Location = new System.Drawing.Point(0, 0);
            this.soundPanelLabel.Name = "soundPanelLabel";
            this.soundPanelLabel.Size = new System.Drawing.Size(95, 16);
            this.soundPanelLabel.TabIndex = 8;
            this.soundPanelLabel.Text = "Sound settings";
            // 
            // comboBoxFrequency
            // 
            this.comboBoxFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFrequency.FormattingEnabled = true;
            this.comboBoxFrequency.Items.AddRange(new object[] {
            "200",
            "550",
            "1000"});
            this.comboBoxFrequency.Location = new System.Drawing.Point(137, 28);
            this.comboBoxFrequency.Name = "comboBoxFrequency";
            this.comboBoxFrequency.Size = new System.Drawing.Size(100, 23);
            this.comboBoxFrequency.TabIndex = 4;
            // 
            // comboBoxWords_Per_Minute
            // 
            this.comboBoxWords_Per_Minute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWords_Per_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWords_Per_Minute.FormattingEnabled = true;
            this.comboBoxWords_Per_Minute.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.comboBoxWords_Per_Minute.Location = new System.Drawing.Point(137, 57);
            this.comboBoxWords_Per_Minute.Name = "comboBoxWords_Per_Minute";
            this.comboBoxWords_Per_Minute.Size = new System.Drawing.Size(100, 23);
            this.comboBoxWords_Per_Minute.TabIndex = 9;
            // 
            // UserControl_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.sountPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl_Settings";
            this.Size = new System.Drawing.Size(628, 374);
            this.Load += new System.EventHandler(this.UserControl_Trainer_Load);
            this.Enter += new System.EventHandler(this.UserControl_Trainer_Enter);
            this.sountPanel.ResumeLayout(false);
            this.sountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelWords_Per_Minute;
        private System.Windows.Forms.TextBox textBoxControl_Word;
        private System.Windows.Forms.Label labelControl_Word;
        private System.Windows.Forms.Panel sountPanel;
        private System.Windows.Forms.Button updateSoundButton;
        private System.Windows.Forms.Button resetSoundButton;
        private System.Windows.Forms.Label soundPanelLabel;
        private System.Windows.Forms.ComboBox comboBoxFrequency;
        private System.Windows.Forms.ComboBox comboBoxWords_Per_Minute;
    }
}
