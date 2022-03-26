namespace Morse_Translator
{
    partial class TranslatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorForm));
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topPanelLabel = new System.Windows.Forms.Label();
            this.inputboxLable = new System.Windows.Forms.Label();
            this.outputLable = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.translateBtn = new System.Windows.Forms.Button();
            this.exchangeBtn = new System.Windows.Forms.PictureBox();
            this.playBtn = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(10, 120);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(780, 100);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "";
            this.inputBox.VScroll += new System.EventHandler(this.inputBox_VScroll);
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // outputBox
            // 
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(10, 260);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(780, 100);
            this.outputBox.TabIndex = 0;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "";
            this.outputBox.VScroll += new System.EventHandler(this.outputBox_VScroll);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.topPanel.Controls.Add(this.topPanelLabel);
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 36);
            this.topPanel.TabIndex = 5;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // topPanelLabel
            // 
            this.topPanelLabel.AutoSize = true;
            this.topPanelLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.topPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topPanelLabel.Location = new System.Drawing.Point(0, 0);
            this.topPanelLabel.Name = "topPanelLabel";
            this.topPanelLabel.Size = new System.Drawing.Size(256, 36);
            this.topPanelLabel.TabIndex = 0;
            this.topPanelLabel.Text = "Morse Translator";
            this.topPanelLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // inputboxLable
            // 
            this.inputboxLable.AutoSize = true;
            this.inputboxLable.BackColor = System.Drawing.Color.Transparent;
            this.inputboxLable.Font = new System.Drawing.Font("Adobe Devanagari", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputboxLable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputboxLable.Location = new System.Drawing.Point(6, 88);
            this.inputboxLable.Name = "inputboxLable";
            this.inputboxLable.Size = new System.Drawing.Size(81, 38);
            this.inputboxLable.TabIndex = 4;
            this.inputboxLable.Text = "Input:";
            this.inputboxLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputLable
            // 
            this.outputLable.AutoSize = true;
            this.outputLable.BackColor = System.Drawing.Color.Transparent;
            this.outputLable.Font = new System.Drawing.Font("Adobe Devanagari", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outputLable.Location = new System.Drawing.Point(6, 228);
            this.outputLable.Name = "outputLable";
            this.outputLable.Size = new System.Drawing.Size(100, 38);
            this.outputLable.TabIndex = 5;
            this.outputLable.Text = "Output:";
            this.outputLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(710, 84);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(80, 30);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            this.clearBtn.Enter += new System.EventHandler(this.button_MouseEnter);
            this.clearBtn.Leave += new System.EventHandler(this.button_MouseLeave);
            this.clearBtn.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.clearBtn.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // selectionBox
            // 
            this.selectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionBox.DropDownWidth = 330;
            this.selectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectionBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectionBox.FormattingEnabled = true;
            this.selectionBox.ItemHeight = 19;
            this.selectionBox.Location = new System.Drawing.Point(337, 49);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(331, 27);
            this.selectionBox.TabIndex = 1;
            this.selectionBox.SelectedIndexChanged += new System.EventHandler(this.selectionBox_SelectedIndexChanged);
            // 
            // translateBtn
            // 
            this.translateBtn.BackColor = System.Drawing.Color.White;
            this.translateBtn.FlatAppearance.BorderSize = 0;
            this.translateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translateBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translateBtn.Location = new System.Drawing.Point(674, 49);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(108, 30);
            this.translateBtn.TabIndex = 2;
            this.translateBtn.Text = "Translate";
            this.translateBtn.UseVisualStyleBackColor = false;
            this.translateBtn.Enter += new System.EventHandler(this.button_MouseEnter);
            this.translateBtn.Leave += new System.EventHandler(this.button_MouseLeave);
            this.translateBtn.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.translateBtn.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // exchangeBtn
            // 
            this.exchangeBtn.Image = global::Morse_Translator.Properties.Resources.exchange;
            this.exchangeBtn.Location = new System.Drawing.Point(380, 220);
            this.exchangeBtn.Name = "exchangeBtn";
            this.exchangeBtn.Size = new System.Drawing.Size(40, 40);
            this.exchangeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exchangeBtn.TabIndex = 9;
            this.exchangeBtn.TabStop = false;
            this.exchangeBtn.Click += new System.EventHandler(this.exchangeBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Image = global::Morse_Translator.Properties.Resources.play_sign;
            this.playBtn.Location = new System.Drawing.Point(18, 39);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(44, 44);
            this.playBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playBtn.TabIndex = 8;
            this.playBtn.TabStop = false;
            this.playBtn.Click += new System.EventHandler(this.playMorse);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Image = global::Morse_Translator.Properties.Resources.minimize;
            this.minimizeBtn.Location = new System.Drawing.Point(725, 2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(32, 32);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::Morse_Translator.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(766, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 32);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // TranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.exchangeBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.selectionBox);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.outputLable);
            this.Controls.Add(this.inputboxLable);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TranslatorForm";
            this.Text = "Morse Translator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TranslatorForm_FormClosing);
            this.Load += new System.EventHandler(this.TranslatorForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.Label topPanelLabel;
        private System.Windows.Forms.Label inputboxLable;
        private System.Windows.Forms.Label outputLable;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox playBtn;
        private System.Windows.Forms.ComboBox selectionBox;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.PictureBox exchangeBtn;
    }
}

