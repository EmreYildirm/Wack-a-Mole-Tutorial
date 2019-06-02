using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace BLL
{
    public class Game
    {
        SoundPlayer myplayer = new SoundPlayer();
        //SoundPlayer Open = new SoundPlayer();
        //Thread Playmusic = new Thread(MusicPlayer);
        public event MoleGameHandler GameStart;
        public event MoleGameOverHandler GameOver;
        public Player Player { get; set; }
        public int level { get; private set; }

        public bool Level()
        {
            var result = false;
            level = 1;
            if (Player.Score == 2)
            {
                level++;
                return true;
            }
            return result;
        }

        public Game()
        {
            Player = new Player("Player");
        }

        public void StartGame()
        {
            MusicPlay();
            GameStart(this);
        }

        public void GameIsOver()
        {
            GameOver(this);
        }

        public void MusicPlay()
        {

            myplayer.Stream = Properties.Resources.Song;
            myplayer.Play();
        }

        public void MusicStop()
        {
            myplayer.Stop();
        }

        //public void OpenSound()
        //{
        //    Open.Stream = Properties.Resources.open;
        //    Open.Play();
        //}
        //public void OpenSoundStop()
        //{
        //    Open.Stop();
        //}
    }
}
