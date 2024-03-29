﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Näyttöprojekti
{
    public partial class Pong : Form
    {
        private const int initialBallLeft = 434;
        private const int initialBallTop = 239;
        private const int initialBallSpeedX = 5; 
        private const int initialBallSpeedY = 5;

        private const int initialplayerLeft = 12;
        private const int initialplayerTop = 186;

        bool goup;
        bool godown;

        int speed = 5;                                                                                                                                                                                                                   
        int ballx = 5;
        int bally=5;

        int score = 0;
        int cpupoint = 0;
        int wins = 0;
        int cpuwins = 0;

       private readonly string highscoreFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Highscore.txt");


        public Pong()
        {
            InitializeComponent();
            LoadHighScore();
        }
        private void SaveHighScore()
        {
            try
            {
                {
                    
                    Properties.Settings.Default.Wins = wins;
                    Properties.Settings.Default.CPUWins = cpuwins;

                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving high score: " + ex.Message);
            }
        }

        private void LoadHighScore()
        {
            try
            {
                wins = Properties.Settings.Default.Wins;
                cpuwins = Properties.Settings.Default.CPUWins;

                playerWins.Text = wins.ToString();
                cpuWins.Text = cpuwins.ToString();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading high score: " + ex.Message);
            }
        }

        private void ResetGame()
        {
            if (cpupoint > 9)
            {
                cpuwins++;
            }
            else
            {
                wins++;
            }
            ResetKeyStates();
            SaveHighScore();
            score = 0;
            cpupoint = 0;
            ball.Left = initialBallLeft; 
            ball.Top = initialBallTop;   
            ballx = initialBallSpeedX;   
            bally = initialBallSpeedY;
            playerPaddle.Left = initialplayerLeft;
            playerPaddle.Top = initialplayerTop;

           


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            gameTimer.Start();
           
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }
        private void ResetKeyStates()
        {
            goup = false;   //nämä estää keypressejä jäämästä "pohjaan" kun peli päättyy
            godown = false; 
            cpuPaddle.Top = Math.Max(0, Math.Min(ClientSize.Height - cpuPaddle.Height, ball.Top + 30)); //resetoi tietokoneen kapulan että ei jää jumiin
        }                                                                                               //pelin päätyttyä/resetoitua   



        private void Pong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cpuPaddlePB_Click(object sender, EventArgs e)
        {

        }

        private void playerPaddlePB_Click(object sender, EventArgs e)
        {

        }

        private void ballPB_Click(object sender, EventArgs e)
        {

        }

        private void ballPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
          
                playerScore.Text = "" + score;
                cpuScore.Text = "" + cpupoint;
                playerWins.Text = "" + wins;
                cpuWins.Text = "" + cpuwins;

                ball.Top -= bally;
                ball.Left -= ballx;

                cpuPaddle.Top += speed;

                if (score < 5)
                {
                    if (cpuPaddle.Top < 0 || cpuPaddle.Top > 455)
                    {
                        speed = -speed;
                    }
                }
                else
                {                                    //Jos pisteet on suurempi kuin 5
                    cpuPaddle.Top = ball.Top + 30;   // tekee pelistä vaikeamman 
                }                                    // TK nopeammin yrittää ampua pallon takaisin


                if (ball.Left < 0)            //Tarkistaa onko pallo mennyt pelaajan "maaliin" 
                {
                    ball.Left = 434;  //resetoi pallon keskelle kenttää
                    ballx = -ballx;    //vaihtaa pallon suunnan
                    ballx -= 2;         // nostaa pallon nopeautta
                    cpupoint++;          // lisää TK pisteitä
                }

                if (ball.Left + ball.Width > ClientSize.Width)
                {
                    ball.Left = 434; //resetoi pallon keskelle kenttää
                    ballx = -ballx;  //vaihtaa pallon suunnan
                    ballx += 2;      //nostaa nopeutta
                    score++;         //lisää pelaajan pisteitä
                }

                //pallon ohjaus
                //jos pallo koskee näytön ylä tai alaosaa
                if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
                {
                    bally = -bally; // Lyö pallon takaisin että se pysyy näytöllä
                }
                //jos pallo osuu pelaajaan tai tk mailaan
                if (ball.Bounds.IntersectsWith(playerPaddle.Bounds) || ball.Bounds.IntersectsWith(cpuPaddle.Bounds))
                {
                    ballx = -ballx; //lyö pallon takaisin
                
                if (ball.Bounds.IntersectsWith(playerPaddle.Bounds))  //Jos pallo osuu mailaan, estää palloa jäämästä jumiin pelaajan mailaan
                {
                    ball.Left = playerPaddle.Right + 1;
                }
                else if (ball.Bounds.IntersectsWith(cpuPaddle.Bounds)) //jos pallo osuu TK mailaan, estää palloa jäämästä jumiin TK mailaan
                {
                    ball.Left = cpuPaddle.Left - ball.Width - 1;
                }
            }

                //pelaajan ohjaus

                //jos goup on true niin pelaaja on pelin ylärajan sisäpuolella
                if (goup == true && playerPaddle.Top > 0)
                {
                    playerPaddle.Top -= 8; //liikuttaa pelaajaa ylöspäin
                }

                if (godown == true && playerPaddle.Top < 455)
                {
                    playerPaddle.Top += 8; //liikuttaa pelajaa alaspäin
                }

                if (score > 10 || cpupoint > 10)
           {
                gameTimer.Stop();

                DialogResult result = MessageBox.Show("Do you want to start a new game?", "Game Over", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ResetGame();
                    gameTimer.Start();
                }
                else if (result == DialogResult.No)
                {
                    ResetGame();
                    this.Close(); 
                }
            }
                
            

        }

        private void Pong_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameMenu form2 = new GameMenu();
            form2.Show();
           
           
            if (e.Cancel)
            {
                return;
            }

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }
    }
}
