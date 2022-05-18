namespace Delay_Sleep
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.threadSleep = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // threadSleep
            // 
            this.threadSleep.BackColor = System.Drawing.SystemColors.ControlDark;
            this.threadSleep.Location = new System.Drawing.Point(196, 70);
            this.threadSleep.Name = "threadSleep";
            this.threadSleep.Size = new System.Drawing.Size(272, 64);
            this.threadSleep.TabIndex = 0;
            this.threadSleep.Text = "threadSleep";
            this.threadSleep.UseVisualStyleBackColor = false;
            this.threadSleep.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(196, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "taskDelay";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "cancel delay";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.threadSleep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button threadSleep;
        private Button button2;
        private Button button3;
    }
}