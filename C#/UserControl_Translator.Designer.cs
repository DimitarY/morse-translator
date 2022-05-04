namespace Morse_Translator
{
    partial class UserControl_Translator
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
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.outputLable = new System.Windows.Forms.Label();
            this.inputboxLable = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exchangeButton = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.SuspendLayout();
            // 
            // selectionBox
            // 
            this.selectionBox.BackColor = System.Drawing.SystemColors.Control;
            this.selectionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectionBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.selectionBox.FormattingEnabled = true;
            this.selectionBox.Location = new System.Drawing.Point(177, 14);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(500, 27);
            this.selectionBox.TabIndex = 1;
            this.selectionBox.SelectedIndexChanged += new System.EventHandler(this.selectionBox_SelectedIndexChanged);
            // 
            // outputLable
            // 
            this.outputLable.AutoSize = true;
            this.outputLable.BackColor = System.Drawing.Color.Transparent;
            this.outputLable.Font = new System.Drawing.Font("Adobe Devanagari", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.outputLable.Location = new System.Drawing.Point(16, 259);
            this.outputLable.Name = "outputLable";
            this.outputLable.Size = new System.Drawing.Size(100, 38);
            this.outputLable.TabIndex = 9;
            this.outputLable.Text = "Output:";
            this.outputLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputboxLable
            // 
            this.inputboxLable.AutoSize = true;
            this.inputboxLable.BackColor = System.Drawing.Color.Transparent;
            this.inputboxLable.Font = new System.Drawing.Font("Adobe Devanagari", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputboxLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.inputboxLable.Location = new System.Drawing.Point(16, 90);
            this.inputboxLable.Name = "inputboxLable";
            this.inputboxLable.Size = new System.Drawing.Size(81, 38);
            this.inputboxLable.TabIndex = 8;
            this.inputboxLable.Text = "Input:";
            this.inputboxLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputBox
            // 
            this.outputBox.AcceptsTab = true;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(20, 291);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(780, 120);
            this.outputBox.TabIndex = 1;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "";
            this.outputBox.VScroll += new System.EventHandler(this.outputBox_VScroll);
            // 
            // inputBox
            // 
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(20, 122);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(780, 120);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "";
            this.inputBox.VScroll += new System.EventHandler(this.inputBox_VScroll);
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(720, 14);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 30);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            this.clearButton.Enter += new System.EventHandler(this.button_Enter);
            this.clearButton.Leave += new System.EventHandler(this.button_Leave);
            this.clearButton.MouseEnter += new System.EventHandler(this.button_Enter);
            this.clearButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // exchangeButton
            // 
            this.exchangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exchangeButton.Image = global::Morse_Translator.Properties.Resources.exchange;
            this.exchangeButton.Location = new System.Drawing.Point(393, 245);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(40, 40);
            this.exchangeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exchangeButton.TabIndex = 11;
            this.exchangeButton.TabStop = false;
            this.exchangeButton.Click += new System.EventHandler(this.exchangeButton_Click);
            // 
            // playButton
            // 
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Image = global::Morse_Translator.Properties.Resources.play_button;
            this.playButton.Location = new System.Drawing.Point(20, 14);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(44, 44);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playButton.TabIndex = 10;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // UserControl_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.exchangeButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputLable);
            this.Controls.Add(this.inputboxLable);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.selectionBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "UserControl_Translator";
            this.Size = new System.Drawing.Size(838, 460);
            this.Load += new System.EventHandler(this.UserControl_Translator_Load);
            this.Enter += new System.EventHandler(this.UserControl_Translator_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.exchangeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectionBox;
        private System.Windows.Forms.Label outputLable;
        private System.Windows.Forms.Label inputboxLable;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.PictureBox exchangeButton;
    }
}
