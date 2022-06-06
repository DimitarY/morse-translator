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
            this.exchangeButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
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
            this.selectionBox.Location = new System.Drawing.Point(133, 11);
            this.selectionBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(376, 25);
            this.selectionBox.TabIndex = 1;
            this.selectionBox.SelectedIndexChanged += new System.EventHandler(this.selectionBox_SelectedIndexChanged);
            // 
            // outputLable
            // 
            this.outputLable.AutoSize = true;
            this.outputLable.BackColor = System.Drawing.Color.Transparent;
            this.outputLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.outputLable.Location = new System.Drawing.Point(12, 210);
            this.outputLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLable.Name = "outputLable";
            this.outputLable.Size = new System.Drawing.Size(83, 26);
            this.outputLable.TabIndex = 9;
            this.outputLable.Text = "Output:";
            this.outputLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputboxLable
            // 
            this.inputboxLable.AutoSize = true;
            this.inputboxLable.BackColor = System.Drawing.Color.Transparent;
            this.inputboxLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputboxLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.inputboxLable.Location = new System.Drawing.Point(12, 73);
            this.inputboxLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputboxLable.Name = "inputboxLable";
            this.inputboxLable.Size = new System.Drawing.Size(66, 26);
            this.inputboxLable.TabIndex = 8;
            this.inputboxLable.Text = "Input:";
            this.inputboxLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputBox
            // 
            this.outputBox.AcceptsTab = true;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(15, 236);
            this.outputBox.Margin = new System.Windows.Forms.Padding(2);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(586, 98);
            this.outputBox.TabIndex = 1;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "";
            this.outputBox.VScroll += new System.EventHandler(this.outputBox_VScroll);
            // 
            // inputBox
            // 
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(15, 99);
            this.inputBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(586, 98);
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
            this.clearButton.Location = new System.Drawing.Point(540, 11);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 24);
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
            this.exchangeButton.BackgroundImage = global::Morse_Translator.Properties.Resources.exchange;
            this.exchangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exchangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exchangeButton.FlatAppearance.BorderSize = 0;
            this.exchangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exchangeButton.Location = new System.Drawing.Point(293, 202);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(30, 30);
            this.exchangeButton.TabIndex = 4;
            this.exchangeButton.UseVisualStyleBackColor = true;
            this.exchangeButton.Click += new System.EventHandler(this.exchangeButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::Morse_Translator.Properties.Resources.play_button;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(15, 11);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(30, 30);
            this.playButton.TabIndex = 3;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // UserControl_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.exchangeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputLable);
            this.Controls.Add(this.inputboxLable);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.selectionBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl_Translator";
            this.Size = new System.Drawing.Size(628, 374);
            this.Load += new System.EventHandler(this.UserControl_Translator_Load);
            this.Enter += new System.EventHandler(this.UserControl_Translator_Enter);
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
        private System.Windows.Forms.Button exchangeButton;
        private System.Windows.Forms.Button playButton;
    }
}
