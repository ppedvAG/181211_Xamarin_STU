﻿namespace AsynchronesProgrammierenMitDerTPL
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
            this.buttonThread = new System.Windows.Forms.Button();
            this.progressBarLangsam = new System.Windows.Forms.ProgressBar();
            this.progressBarSchnell = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonThread
            // 
            this.buttonThread.Location = new System.Drawing.Point(12, 12);
            this.buttonThread.Name = "buttonThread";
            this.buttonThread.Size = new System.Drawing.Size(104, 34);
            this.buttonThread.TabIndex = 0;
            this.buttonThread.Text = "Threads";
            this.buttonThread.UseVisualStyleBackColor = true;
            this.buttonThread.Click += new System.EventHandler(this.buttonThread_Click);
            // 
            // progressBarLangsam
            // 
            this.progressBarLangsam.Location = new System.Drawing.Point(16, 52);
            this.progressBarLangsam.Name = "progressBarLangsam";
            this.progressBarLangsam.Size = new System.Drawing.Size(247, 23);
            this.progressBarLangsam.TabIndex = 1;
            // 
            // progressBarSchnell
            // 
            this.progressBarSchnell.Location = new System.Drawing.Point(16, 81);
            this.progressBarSchnell.Name = "progressBarSchnell";
            this.progressBarSchnell.Size = new System.Drawing.Size(247, 23);
            this.progressBarSchnell.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarSchnell);
            this.Controls.Add(this.progressBarLangsam);
            this.Controls.Add(this.buttonThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonThread;
        private System.Windows.Forms.ProgressBar progressBarLangsam;
        private System.Windows.Forms.ProgressBar progressBarSchnell;
    }
}

