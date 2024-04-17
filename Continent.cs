using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_SarahBarakat
{
    public class Continent
    {
        private int continentID;
        private string continentName;

        public int ContinentID { get => continentID; set => continentID = value; }
        public string ContinentName { get => continentName; set => continentName = value; }

        public Continent(int ContinentID, string ContinentName)
        {
            continentID = ContinentID;
            continentName = ContinentName;
        }
    }
}
