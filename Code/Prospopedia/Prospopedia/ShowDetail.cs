using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 *Auteur : KGS, SGI
* Date : 23 / 01 / 2022
* Version : 1.0
* Description : Interface d'un film/une série où l'on pourra voir son nom, studio, realisateur, sa date de sorties, nombre de saison/episode si c'est une serie etc..
 */

namespace Prospopedia
{
    public partial class ShowDetail : Form
    {
        private string _id;
        public ShowDetail(string id)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\";

            InitializeComponent();
            _id = id;
            DbConnector dbConnector = new DbConnector();
            string query = "SELECT shows.id, shows.title, images.placement, shows.`type`, shows.studio, shows.director, shows.realisator, shows.releaseDate, shows.nationality, shows.lenght, shows.ranking, shows.numberOfSeason, shows.numberOfEpisode  FROM shows INNER JOIN shows_has_images ON shows.id = shows_has_images.shows_id INNER JOIN images ON shows_has_images.images_id = images.id WHERE shows.id = "+_id+" ORDER BY shows.ranking LIMIT 1;";
            List<DataHandler> allSeriesMM = dbConnector.Select(query, 13);

            label6.Text = allSeriesMM[0].I2;
            label8.Text = allSeriesMM[0].I4;
            label10.Text = allSeriesMM[0].I5;
            label12.Text = allSeriesMM[0].I6;
            label17.Text = allSeriesMM[0].I7;
            label15.Text = allSeriesMM[0].I8;
            label23.Text = allSeriesMM[0].I9;
            label13.Text = allSeriesMM[0].I10;
            label19.Text = allSeriesMM[0].I11;
            label15.Text = allSeriesMM[0].I12;
            label21.Text = allSeriesMM[0].I13;

            pictureBox1.Image = Image.FromFile(path + allSeriesMM[0].I3);



        }

        private void ShowDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new();
            mainMenu.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            TopShowPage TCP = new();
            TCP.Show();
        }
    }
}
