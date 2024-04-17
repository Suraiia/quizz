using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_SarahBarakat
{
    public class Game
    {
        private int gameID;
        private int points;
        private string date;
        private string time;

        public int GameID { get => gameID; set => gameID = value; }
        public int Points { get => points; set => points = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }

        public Game ( int GameID, int Points, string Date, string Time)
        {
            gameID = GameID;
            points = Points;
            date = Date;
            time = Time;
        }
    }
}
