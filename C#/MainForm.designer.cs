namespace Morse_Translator
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.translateBtn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectionBox
            // 
            this.selectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectionBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectionBox.FormattingEnabled = true;
            this.selectionBox.ItemHeight = 17;
            this.selectionBox.Location = new System.Drawing.Point(441, 24);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(225, 25);
            this.selectionBox.TabIndex = 1;
            // 
            // translateBtn
            // 
            this.translateBtn.BackColor = System.Drawing.Color.White;
            this.translateBtn.FlatAppearance.BorderSize = 0;
            this.translateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translateBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translateBtn.Location = new System.Drawing.Point(672, 24);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(108, 25);
            this.translateBtn.TabIndex = 2;
            this.translateBtn.Text = "Translate";
            this.translateBtn.UseVisualStyleBackColor = false;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            this.translateBtn.Enter += new System.EventHandler(this.button_MouseEnter);
            this.translateBtn.Leave += new System.EventHandler(this.button_MouseLeave);
            this.translateBtn.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.translateBtn.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(12, 73);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(776, 96);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "";
            // 
            // outputBox
            // 
            this.outputBox.Enabled = false;
            this.outputBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(12, 223);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(776, 96);
            this.outputBox.TabIndex = 0;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.White;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playBtn.Location = new System.Drawing.Point(12, 24);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(108, 25);
            this.playBtn.TabIndex = 3;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playMorse);
            this.playBtn.Enter += new System.EventHandler(this.button_MouseEnter);
            this.playBtn.Leave += new System.EventHandler(this.button_MouseLeave);
            this.playBtn.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.playBtn.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.White;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBtn.Location = new System.Drawing.Point(126, 24);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(108, 25);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.playMorse);
            this.stopBtn.Enter += new System.EventHandler(this.button_MouseEnter);
            this.stopBtn.Leave += new System.EventHandler(this.button_MouseLeave);
            this.stopBtn.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.stopBtn.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.selectionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Morse Translator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MorseTranslator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectionBox;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button stopBtn;
    }
}

