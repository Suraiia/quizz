using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_SarahBarakat
{
    public class Player
    {
        private int playerID;
        private string playerName;

        public int PlayerID { get => playerID; set => playerID = value; }
        public string PlayerName { get => playerName; set => playerName = value; }

        public Player(int PlayerID, string PlayerName)
        {
            playerID = PlayerID;
            playerName = PlayerName;
        }

    }
}
