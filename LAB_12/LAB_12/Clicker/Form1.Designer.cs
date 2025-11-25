namespace Clicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ResetBTN = new System.Windows.Forms.Button();
            this.ClickButton = new System.Windows.Forms.Button();
            this.TimerOP = new System.Windows.Forms.Label();
            this.Counter1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(406, 237);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(158, 105);
            this.ResetBTN.TabIndex = 0;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // ClickButton
            // 
            this.ClickButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClickButton.BackgroundImage")));
            this.ClickButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClickButton.Location = new System.Drawing.Point(372, 37);
            this.ClickButton.Name = "ClickButton";
            this.ClickButton.Size = new System.Drawing.Size(259, 136);
            this.ClickButton.TabIndex = 1;
            this.ClickButton.UseVisualStyleBackColor = true;
            this.ClickButton.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // TimerOP
            // 
            this.TimerOP.AutoSize = true;
            this.TimerOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerOP.Location = new System.Drawing.Point(78, 240);
            this.TimerOP.Name = "TimerOP";
            this.TimerOP.Size = new System.Drawing.Size(83, 20);
            this.TimerOP.TabIndex = 2;
            this.TimerOP.Text = "Время: 0";
            // 
            // Counter1
            // 
            this.Counter1.AutoSize = true;
            this.Counter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Counter1.Location = new System.Drawing.Point(78, 322);
            this.Counter1.Name = "Counter1";
            this.Counter1.Size = new System.Drawing.Size(109, 20);
            this.Counter1.TabIndex = 3;
            this.Counter1.Text = "Нажатий: 0 ";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 455);
            this.Controls.Add(this.Counter1);
            this.Controls.Add(this.TimerOP);
            this.Controls.Add(this.ClickButton);
            this.Controls.Add(this.ResetBTN);
            this.Name = "Form1";
            this.Text = "Кликер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Button ClickButton;
        private System.Windows.Forms.Label TimerOP;
        private System.Windows.Forms.Label Counter1;
        private System.Windows.Forms.Timer timer2;
    }
}

