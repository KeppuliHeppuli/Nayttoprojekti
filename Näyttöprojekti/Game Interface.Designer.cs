﻿namespace Näyttöprojekti
{
    partial class GameMenu
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
            this.breakoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a game";
            // 
            // pongButton
            // 
            this.pongButton.BackColor = System.Drawing.Color.SeaShell;
            this.pongButton.FlatAppearance.BorderSize = 2;
            this.pongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pongButton.Location = new System.Drawing.Point(295, 279);
            this.pongButton.Name = "pongButton";
            this.pongButton.Size = new System.Drawing.Size(90, 47);
            this.pongButton.TabIndex = 1;
            this.pongButton.Text = "Pong";
            this.pongButton.UseVisualStyleBackColor = false;
            this.pongButton.Click += new System.EventHandler(this.pongButton_Click);
            // 
            // breakoutButton
            // 
            this.breakoutButton.BackColor = System.Drawing.Color.SeaShell;
            this.breakoutButton.FlatAppearance.BorderSize = 2;
            this.breakoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.breakoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakoutButton.Location = new System.Drawing.Point(403, 279);
            this.breakoutButton.Name = "breakoutButton";
            this.breakoutButton.Size = new System.Drawing.Size(90, 47);
            this.breakoutButton.TabIndex = 1;
            this.breakoutButton.Text = "Breakout";
            this.breakoutButton.UseVisualStyleBackColor = false;
            this.breakoutButton.Click += new System.EventHandler(this.breakoutButton_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.breakoutButton);
            this.Controls.Add(this.pongButton);
            this.Controls.Add(this.label1);
            this.Name = "GameMenu";
            this.Text = "Minigames";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pelivalikko_FormClosing);
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pongButton;
        private System.Windows.Forms.Button breakoutButton;
    }
}

