using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        private Game molegame;
        private PictureBox openButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void game_Start(Game game)
        {
            molegame = new Game();
            molegame.GameStart += new MoleGameHandler(game_Start);
            molegame.GameOver += new MoleGameOverHandler(game_IsOver);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox btn = new PictureBox();
                    btn.Size = new Size(100, 100);
                    btn.Location = new Point(105 * j + 10, 105 * i + 10);
                    btn.Tag = 4 * i + j;
                    btn.Image = Properties.Resources.poke;
                    btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    btn.Name = $"btn{i * 4 + j + 1}";
                    btn.Click += new EventHandler(Btn_Click);
                    this.game_field.Controls.Add(btn);
                }
            }
            molegame.Player.ResetScore();
            lbl_player.Text = molegame.Player.Name + " " + "Score: " + molegame.Player.Score;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            molegame = new Game();
            molegame.GameStart += new MoleGameHandler(game_Start);
            molegame.GameOver += new MoleGameOverHandler(game_IsOver);
            molegame.StartGame();
            Game_Timer.Interval = 30000;
            Game_Timer.Start();
            tmr_Open.Start();
            btn_Start.Enabled = false;
        }

        private void game_IsOver(Game game)
        {
            Game_Timer.Stop();
            molegame.MusicStop();
            var result = MessageBox.Show($"Game over. Score = {molegame.Player.Score}", " Make your choice ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
                btn_Start.Enabled = true;
                RestardGame();
            }
            else if (result == DialogResult.No)
            {
                Environment.Exit(1);
            }
        }



        private void Btn_Click(object sender, EventArgs e)
        {
            //molegame.OpenSound();
            var btn = sender as PictureBox;
            btn.Image = Properties.Resources.Hit;
            molegame.Player.HitaMole();
            lbl_player.Text = molegame.Player.Name + " " + "Score: " + molegame.Player.Score;
        }

        private void RandomButton()
        {
            tmr_Open.Interval = 2000;
            Random rnd = new Random();
            var rndButton = rnd.Next(0, 17);
            for (int i = 1; i <= 16; i++)
            {
                if (Convert.ToInt32(game_field.Controls[$"btn{i}"].Tag) == rndButton)
                {
                    openButton = (PictureBox)game_field.Controls[$"btn{i}"];
                    openButton.Enabled = true;
                    openButton.Image = Properties.Resources.Rat;
                }
            }
            tmr_Close.Start();
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void RestardGame()
        {
            game_field.Controls.Clear();
            game_Start(molegame);
        }

        private void Game_Timer_Tick(object sender, EventArgs e)
        {
            tmr_Open.Stop();
            game_IsOver(molegame);
        }

        private void tmr_Open_Tick(object sender, EventArgs e)
        {
            RandomButton();
        }

        private void tmr_Close_Tick(object sender, EventArgs e)
        {
            if (openButton != null)
            {
                foreach (var item in game_field.Controls)
                {
                    if (item is PictureBox)
                    {
                        var btn = item as PictureBox;
                        btn.Enabled = false;
                        openButton.Image = Properties.Resources.poke;
                    }
                }
            }
        }
    }
}
