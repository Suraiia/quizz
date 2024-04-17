using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_SarahBarakat
{
    public class Country
    {
        private int countryID;
        private string countryName;
        private string capital;
        private int countryCode;

        public int CountryID { get => countryID; set => countryID = value; }
        public string CountryName { get => countryName; set => countryName = value; }
        public string Capital { get => capital; set => capital = value; }
        public int CountryCode { get => countryCode; set => countryCode = value; }

        public Country(int CountryID, string CountryName, string Capital, int countryCode)
        {
            countryID = CountryID;
            countryName = CountryName;
            capital = Capital;
            countryCode = CountryCode;
        }
    }
}
