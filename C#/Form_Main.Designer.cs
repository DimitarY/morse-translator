namespace Morse_Translator
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.topPanel = new System.Windows.Forms.Panel();
            this.topPanelLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.trainerButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.translatorButton = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.decorationPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Controls.Add(this.topPanelLabel);
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(750, 32);
            this.topPanel.TabIndex = 3;
            this.topPanel.TabStop = true;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // topPanelLabel
            // 
            this.topPanelLabel.AutoSize = true;
            this.topPanelLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.topPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topPanelLabel.Location = new System.Drawing.Point(0, 0);
            this.topPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topPanelLabel.Name = "topPanelLabel";
            this.topPanelLabel.Size = new System.Drawing.Size(212, 29);
            this.topPanelLabel.TabIndex = 2;
            this.topPanelLabel.Text = "Morse Translator";
            this.topPanelLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.trainerButton);
            this.leftPanel.Controls.Add(this.button3);
            this.leftPanel.Controls.Add(this.button4);
            this.leftPanel.Controls.Add(this.translatorButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 32);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(120, 374);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.TabStop = true;
            // 
            // trainerButton
            // 
            this.trainerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trainerButton.FlatAppearance.BorderSize = 0;
            this.trainerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainerButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerButton.ForeColor = System.Drawing.Color.White;
            this.trainerButton.Location = new System.Drawing.Point(0, 130);
            this.trainerButton.Margin = new System.Windows.Forms.Padding(2);
            this.trainerButton.Name = "trainerButton";
            this.trainerButton.Size = new System.Drawing.Size(120, 65);
            this.trainerButton.TabIndex = 2;
            this.trainerButton.Text = "Trainer";
            this.trainerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.trainerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.trainerButton.UseVisualStyleBackColor = true;
            this.trainerButton.Click += new System.EventHandler(this.trainerButton_Click);
            this.trainerButton.Enter += new System.EventHandler(this.Button_Enter);
            this.trainerButton.Leave += new System.EventHandler(this.Button_Leave);
            this.trainerButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.trainerButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 65);
            this.button3.TabIndex = 0;
            this.button3.Text = "BUTTON3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Enter += new System.EventHandler(this.Button_Enter);
            this.button3.Leave += new System.EventHandler(this.Button_Leave);
            this.button3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.button3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 195);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "BUTTON4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Enter += new System.EventHandler(this.Button_Enter);
            this.button4.Leave += new System.EventHandler(this.Button_Leave);
            this.button4.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.button4.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // translatorButton
            // 
            this.translatorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.translatorButton.FlatAppearance.BorderSize = 0;
            this.translatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translatorButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translatorButton.ForeColor = System.Drawing.Color.White;
            this.translatorButton.Location = new System.Drawing.Point(0, 65);
            this.translatorButton.Margin = new System.Windows.Forms.Padding(2);
            this.translatorButton.Name = "translatorButton";
            this.translatorButton.Size = new System.Drawing.Size(120, 65);
            this.translatorButton.TabIndex = 1;
            this.translatorButton.Text = "Translator";
            this.translatorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.translatorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.translatorButton.UseVisualStyleBackColor = true;
            this.translatorButton.Click += new System.EventHandler(this.translaorButton_Click);
            this.translatorButton.Enter += new System.EventHandler(this.Button_Enter);
            this.translatorButton.Leave += new System.EventHandler(this.Button_Leave);
            this.translatorButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.translatorButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // centerPanel
            // 
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.centerPanel.Location = new System.Drawing.Point(122, 32);
            this.centerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(628, 374);
            this.centerPanel.TabIndex = 1;
            this.centerPanel.TabStop = true;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::Morse_Translator.Properties.Resources.close;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(720, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackgroundImage = global::Morse_Translator.Properties.Resources.minimize;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Location = new System.Drawing.Point(687, 1);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(27, 29);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // decorationPanel
            // 
            this.decorationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.decorationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.decorationPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.decorationPanel.Location = new System.Drawing.Point(120, 32);
            this.decorationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.decorationPanel.Name = "decorationPanel";
            this.decorationPanel.Size = new System.Drawing.Size(2, 374);
            this.decorationPanel.TabIndex = 9;
            this.decorationPanel.TabStop = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(750, 406);
            this.Controls.Add(this.decorationPanel);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morse Translator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topPanelLabel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button trainerButton;
        private System.Windows.Forms.Button translatorButton;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel decorationPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeBtn;
    }
}