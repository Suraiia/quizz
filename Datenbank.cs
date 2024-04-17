using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quizz_SarahBarakat
{
    public class Datenbank
    {
        private MySqlConnection con = null;


        private void oeffnen()
        {
            try
            {
                con = new MySqlConnection("SERVER = localhost; UID=root; Password='';Database = quizz");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void schliessen()
        {
            if (con != null)
                con.Close();
        }

        public List<Continent> getContinents()
        {
            List<Continent> continents = new List<Continent>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * from continent;";

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Continent continent = new Continent(
                    reader.GetInt32(0),
                    reader.IsDBNull(1) ? "" : reader.GetString(1));
                
                continents.Add(continent);
            }
            reader.Close();
            schliessen();
            return continents;
        }

        public void createPlayer(Player p)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();

            {
                com.CommandText = "INSERT INTO player VALUES( NULL, '" +

             p.PlayerName+ "');";
            }
            com.ExecuteNonQuery();
            schliessen();
        }

         
    }
    
}

