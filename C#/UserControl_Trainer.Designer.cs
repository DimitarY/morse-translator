namespace Morse_Translator
{
    partial class UserControl_Trainer
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.checkBoxSymbols = new System.Windows.Forms.CheckBox();
            this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.decorationPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.loadButton);
            this.topPanel.Controls.Add(this.checkBoxSymbols);
            this.topPanel.Controls.Add(this.checkBoxNumbers);
            this.topPanel.Controls.Add(this.selectionBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(628, 70);
            this.topPanel.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.White;
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(542, 11);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(60, 25);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // checkBoxSymbols
            // 
            this.checkBoxSymbols.AutoSize = true;
            this.checkBoxSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSymbols.Location = new System.Drawing.Point(377, 44);
            this.checkBoxSymbols.Name = "checkBoxSymbols";
            this.checkBoxSymbols.Size = new System.Drawing.Size(79, 20);
            this.checkBoxSymbols.TabIndex = 6;
            this.checkBoxSymbols.Text = "Symbols";
            this.checkBoxSymbols.UseVisualStyleBackColor = true;
            this.checkBoxSymbols.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // checkBoxNumbers
            // 
            this.checkBoxNumbers.AutoSize = true;
            this.checkBoxNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxNumbers.Location = new System.Drawing.Point(157, 44);
            this.checkBoxNumbers.Name = "checkBoxNumbers";
            this.checkBoxNumbers.Size = new System.Drawing.Size(81, 20);
            this.checkBoxNumbers.TabIndex = 5;
            this.checkBoxNumbers.Text = "Numbers";
            this.checkBoxNumbers.UseVisualStyleBackColor = true;
            this.checkBoxNumbers.Click += new System.EventHandler(this.loadButton_Click);
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
            this.selectionBox.Location = new System.Drawing.Point(130, 11);
            this.selectionBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(376, 25);
            this.selectionBox.TabIndex = 3;
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoScroll = true;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bottomPanel.Location = new System.Drawing.Point(0, 70);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(628, 304);
            this.bottomPanel.TabIndex = 1;
            this.bottomPanel.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // decorationPanel
            // 
            this.decorationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.decorationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.decorationPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.decorationPanel.Location = new System.Drawing.Point(0, 70);
            this.decorationPanel.Name = "decorationPanel";
            this.decorationPanel.Size = new System.Drawing.Size(628, 2);
            this.decorationPanel.TabIndex = 2;
            // 
            // UserControl_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.decorationPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl_Trainer";
            this.Size = new System.Drawing.Size(628, 374);
            this.Load += new System.EventHandler(this.UserControl_Trainer_Load);
            this.Enter += new System.EventHandler(this.UserControl_Trainer_Enter);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.ComboBox selectionBox;
        private System.Windows.Forms.CheckBox checkBoxSymbols;
        private System.Windows.Forms.CheckBox checkBoxNumbers;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Panel decorationPanel;
    }
}
