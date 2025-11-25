namespace Word1
{
    partial class Form1
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
            this.WordLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.CorrectLabel = new System.Windows.Forms.Label();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLabel.Location = new System.Drawing.Point(20, 20);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(48, 25);
            this.WordLabel.TabIndex = 0;
            this.WordLabel.Text = "кот";
            this.WordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(20, 60);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyDown);
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.AutoSize = true;
            this.CorrectLabel.Location = new System.Drawing.Point(20, 90);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(82, 13);
            this.CorrectLabel.TabIndex = 2;
            this.CorrectLabel.Text = "Правильных: 0";
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.Location = new System.Drawing.Point(20, 120);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(94, 13);
            this.WrongLabel.TabIndex = 3;
            this.WrongLabel.Text = "Неправильных: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 254);
            this.Controls.Add(this.WrongLabel);
            this.Controls.Add(this.CorrectLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.WordLabel);
            this.Name = "Form1";
            this.Text = "Набор слов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label CorrectLabel;
        private System.Windows.Forms.Label WrongLabel;
    }
}

