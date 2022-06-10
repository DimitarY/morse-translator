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
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.textBoxWords_Per_Minute = new System.Windows.Forms.TextBox();
            this.labelWords_Per_Minute = new System.Windows.Forms.Label();
            this.textBoxControl_Word = new System.Windows.Forms.TextBox();
            this.labelControl_Word = new System.Windows.Forms.Label();
            this.sountPanel = new System.Windows.Forms.Panel();
            this.updateSoundButton = new System.Windows.Forms.Button();
            this.sountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFrequency
            // 
            this.labelFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrequency.Location = new System.Drawing.Point(14, 18);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(71, 16);
            this.labelFrequency.TabIndex = 0;
            this.labelFrequency.Text = "Frequency";
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFrequency.Location = new System.Drawing.Point(133, 15);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(100, 22);
            this.textBoxFrequency.TabIndex = 0;
            this.textBoxFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnlytextBox_KeyPress);
            // 
            // textBoxWords_Per_Minute
            // 
            this.textBoxWords_Per_Minute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWords_Per_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWords_Per_Minute.Location = new System.Drawing.Point(133, 43);
            this.textBoxWords_Per_Minute.Name = "textBoxWords_Per_Minute";
            this.textBoxWords_Per_Minute.Size = new System.Drawing.Size(100, 22);
            this.textBoxWords_Per_Minute.TabIndex = 1;
            this.textBoxWords_Per_Minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnlytextBox_KeyPress);
            // 
            // labelWords_Per_Minute
            // 
            this.labelWords_Per_Minute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWords_Per_Minute.AutoSize = true;
            this.labelWords_Per_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWords_Per_Minute.Location = new System.Drawing.Point(14, 46);
            this.labelWords_Per_Minute.Name = "labelWords_Per_Minute";
            this.labelWords_Per_Minute.Size = new System.Drawing.Size(113, 16);
            this.labelWords_Per_Minute.TabIndex = 3;
            this.labelWords_Per_Minute.Text = "Words Per Minute";
            // 
            // textBoxControl_Word
            // 
            this.textBoxControl_Word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxControl_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxControl_Word.Location = new System.Drawing.Point(133, 71);
            this.textBoxControl_Word.Name = "textBoxControl_Word";
            this.textBoxControl_Word.Size = new System.Drawing.Size(100, 22);
            this.textBoxControl_Word.TabIndex = 2;
            // 
            // labelControl_Word
            // 
            this.labelControl_Word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl_Word.AutoSize = true;
            this.labelControl_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl_Word.Location = new System.Drawing.Point(14, 74);
            this.labelControl_Word.Name = "labelControl_Word";
            this.labelControl_Word.Size = new System.Drawing.Size(85, 16);
            this.labelControl_Word.TabIndex = 5;
            this.labelControl_Word.Text = "Control Word";
            // 
            // sountPanel
            // 
            this.sountPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sountPanel.Controls.Add(this.updateSoundButton);
            this.sountPanel.Controls.Add(this.labelFrequency);
            this.sountPanel.Controls.Add(this.textBoxControl_Word);
            this.sountPanel.Controls.Add(this.textBoxFrequency);
            this.sountPanel.Controls.Add(this.labelControl_Word);
            this.sountPanel.Controls.Add(this.labelWords_Per_Minute);
            this.sountPanel.Controls.Add(this.textBoxWords_Per_Minute);
            this.sountPanel.Location = new System.Drawing.Point(5, 5);
            this.sountPanel.Name = "sountPanel";
            this.sountPanel.Size = new System.Drawing.Size(246, 147);
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
            this.updateSoundButton.Location = new System.Drawing.Point(158, 109);
            this.updateSoundButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateSoundButton.Name = "updateSoundButton";
            this.updateSoundButton.Size = new System.Drawing.Size(75, 25);
            this.updateSoundButton.TabIndex = 8;
            this.updateSoundButton.Text = "Update";
            this.updateSoundButton.UseVisualStyleBackColor = false;
            this.updateSoundButton.Click += new System.EventHandler(this.updateSoundButton_Click);
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
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.TextBox textBoxWords_Per_Minute;
        private System.Windows.Forms.Label labelWords_Per_Minute;
        private System.Windows.Forms.TextBox textBoxControl_Word;
        private System.Windows.Forms.Label labelControl_Word;
        private System.Windows.Forms.Panel sountPanel;
        private System.Windows.Forms.Button updateSoundButton;
    }
}
