﻿namespace Näyttöprojekti
{
    partial class Pelivalikko
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
            this.label1 = new System.Windows.Forms.Label();
            this.pongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse peli";
            // 
            // pongButton
            // 
            this.pongButton.BackColor = System.Drawing.Color.SeaShell;
            this.pongButton.FlatAppearance.BorderSize = 2;
            this.pongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pongButton.Location = new System.Drawing.Point(328, 279);
            this.pongButton.Name = "pongButton";
            this.pongButton.Size = new System.Drawing.Size(90, 47);
            this.pongButton.TabIndex = 1;
            this.pongButton.Text = "Pong";
            this.pongButton.UseVisualStyleBackColor = false;
            this.pongButton.Click += new System.EventHandler(this.pongButton_Click);
            // 
            // Pelivalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pongButton);
            this.Controls.Add(this.label1);
            this.Name = "Pelivalikko";
            this.Text = "Minipelejä";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pelivalikko_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pongButton;
    }
}

