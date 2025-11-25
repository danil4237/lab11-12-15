namespace StopWatch
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            this.stopBTN = new System.Windows.Forms.Button();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 60F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartBTN
            // 
            this.StartBTN.BackColor = System.Drawing.Color.YellowGreen;
            this.StartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBTN.ForeColor = System.Drawing.Color.White;
            this.StartBTN.Location = new System.Drawing.Point(97, 227);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(105, 38);
            this.StartBTN.TabIndex = 1;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = false;
            this.StartBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.BackColor = System.Drawing.Color.Red;
            this.stopBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBTN.ForeColor = System.Drawing.Color.White;
            this.stopBTN.Location = new System.Drawing.Point(265, 225);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(101, 40);
            this.stopBTN.TabIndex = 2;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseVisualStyleBackColor = false;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // ResetBTN
            // 
            this.ResetBTN.BackColor = System.Drawing.Color.Blue;
            this.ResetBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBTN.ForeColor = System.Drawing.Color.White;
            this.ResetBTN.Location = new System.Drawing.Point(437, 228);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(106, 37);
            this.ResetBTN.TabIndex = 3;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.UseVisualStyleBackColor = false;
            this.ResetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(642, 349);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Timer timer1;
    }
}

