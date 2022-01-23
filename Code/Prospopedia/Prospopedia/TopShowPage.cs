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
* Description : Interface où l'on pourra voir les films/séries qui ont les plus de favoris ainsi qu'un bouton pour le rajouter
 */

namespace Prospopedia
{
    public partial class TopShowPage : Form
    {
        public TopShowPage()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\";
            InitializeComponent();
            string query;
            DbConnector dbConnector = new DbConnector();

            query = "SELECT shows.id, shows.title, images.placement FROM shows INNER JOIN shows_has_images ON shows.id = shows_has_images.shows_id INNER JOIN images ON shows_has_images.images_id = images.id ORDER BY shows.ranking LIMIT 3;";
            List<DataHandler> allShowsMM = dbConnector.Select(query, 3);

            query = "SELECT count(shows_id) FROM users_has_favorite_shows where shows_id = " + allShowsMM[0].I1 + ";";
            List<DataHandler> fav1 = dbConnector.Select(query, 1);

            query = "SELECT count(shows_id) FROM users_has_favorite_shows where shows_id = " + allShowsMM[1].I1 + ";";
            List<DataHandler> fav2 = dbConnector.Select(query, 1);

            query = "SELECT count(shows_id) FROM users_has_favorite_shows where shows_id = " + allShowsMM[2].I1 + ";";
            List<DataHandler> fav3 = dbConnector.Select(query, 1);

            pictureBox1.Image = Image.FromFile(path + allShowsMM[0].I3);
            pictureBox2.Image = Image.FromFile(path + allShowsMM[1].I3);
            pictureBox3.Image = Image.FromFile(path + allShowsMM[2].I3);

            label10.Text = allShowsMM[0].I2;
            label11.Text = allShowsMM[1].I2;
            label12.Text = allShowsMM[2].I2;

            label13.Text = fav1[0].I1;
            label14.Text = fav2[0].I1;
            label15.Text = fav2[0].I1;

        }

        private void TopShowPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new();
            mainMenu.Show();
        }
    }
}
