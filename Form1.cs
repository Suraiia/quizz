using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz_SarahBarakat
{
    public partial class Form1 : Form
    {
        Datenbank db = new Datenbank();

        private List<Country> countries = new List<Country>();
        private List<Continent> continents = new List<Continent>();
        private List<Player> players = new List<Player>();
        private List<Game> games = new List<Game>();

        public Form1()
        {
            InitializeComponent();

            displayContinent();
            displayPicture();
        }

        public void displayContinent()
        {
            continents = db.getContinents();
            comboBoxContinent.Items.Clear();

            foreach (Continent c in continents)
            {
                comboBoxContinent.Items.Add(c.ContinentName);
            }

        }

        private void comboBoxContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panelCCF.Visible = true;


            string dateiname = string.Format("{1}\\{0}.png", comboBoxContinent.SelectedItem.ToString(), @"C:\Users\tn\Desktop\Quizz_Abschlussprojekt_Doku\pictures\");
            pictureBoxContinent.Image = Image.FromFile(dateiname);
        }

        private void buttonSaveMe_Click(object sender, EventArgs e)
        {
            Player player = new Player(-1, textBoxPlayer.Text);
            db.createPlayer(player);
            

            panelChoice1.Visible = true;

            //panelWWvsCont.Visible

        }

        private void radioButtonWW_CheckedChanged(object sender, EventArgs e)
        {
            panelContinent.Visible = false;
            //if (radioButtonWW.Checked == true)
            //{
            //    panelCCF.Visible = true;
            //    panelContinent.Visible = false; 
            //}
            //else
            //{
            //    panelContinent.Visible = true;
            //    panelCCF.Visible = false;
            //}
        }

        private void radioButtonContinent_CheckedChanged(object sender, EventArgs e)
        {
            panelContinent.Visible = true;
        }

        public void displayPicture()
        {
            pictureBoxStart.Image = Image.FromFile(@"C:\Users\tn\Desktop\Quizz_Abschlussprojekt_Doku\pictures\worldmap.jpg");
        }

        //public void chooseGuess()
        //{

        //    if(checkBoxChooseCountry.Checked == true || checkBoxChooseCountry.Checked == true || checkBoxChooseFlag.Checked == true)
        //    {
        //        panelWWvsCont.Visible = true; 
        //    }

        //}

        private void checkBoxChooseCountry_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxChooseCountry.Checked == true || checkBoxChooseCapital.Checked == true || checkBoxChooseFlag.Checked == true)
            //{
            //    panelWWvsCont.Visible = true;
            //}

        }

        private void btnLetsPlay_Click(object sender, EventArgs e)
        {
            GamePlay gp = new GamePlay();
            gp.ShowDialog();
        }

        private void rBCountry_CheckedChanged(object sender, EventArgs e)
        {
            int countryQ = 1;
            int capitalQ = 2;
            int flagQ = 4;

            int question;




        }
    }
}


