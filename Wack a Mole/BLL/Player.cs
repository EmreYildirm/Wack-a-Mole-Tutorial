using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Player
    {
        public int Score { get; private set; }
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
            this.Score = 0;
        }

        public void HitaMole()
        {
            this.Score++;
        }

        public void ResetScore()
        {
            this.Score = 0;
        }
    }
}
