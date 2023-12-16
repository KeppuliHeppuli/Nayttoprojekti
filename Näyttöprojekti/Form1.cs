﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Näyttöprojekti
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void pongButton_Click(object sender, EventArgs e)
        {
            Pong form2 = new Pong();
            form2.Show();
            this.Hide();
            
        }
        private void breakoutButton_Click(object sender, EventArgs e)
        {
            Breakout form3 = new Breakout();
            form3.Show();
            this.Hide();
        }

        private void Pelivalikko_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }
    }
}
