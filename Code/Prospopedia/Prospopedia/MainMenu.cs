using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prospopedia;
using System.IO;

/*
 *Auteur : KGS, SGI
* Date : 23 / 01 / 2022
* Version : 1.0
* Description : Interface principale où l'on pourra voir les ajout récent ainsi que les tops des shows et des personnages.
 */


namespace Prospopedia
{
    public partial class MainMenu : Form
    {
        private List<DataHandler> _allSeriesMM;
        private List<DataHandler>_allMoviesMM;
        private List<DataHandler> _allShowsMM;
        private List<DataHandler> _allGenresMM;
        /*
         * made by Shanshe Gundishvili 
         * date: 23.01.2022
         * desc: this is constructor of main menu, it gets all the information present on main menu
         */
        public MainMenu()
        {
            InitializeComponent();

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\";

            DbConnector dbConnector = new DbConnector();
            string query = "SELECT shows.id, shows.title, images.placement FROM shows INNER JOIN shows_has_images ON shows.id = shows_has_images.shows_id INNER JOIN images ON shows_has_images.images_id = images.id WHERE shows.type = 'show' ORDER BY shows.ranking LIMIT 3;";
            List<DataHandler> allSeriesMM = dbConnector.Select(query, 3);



            query = "SELECT shows.id, shows.title, images.placement FROM shows INNER JOIN shows_has_images ON shows.id = shows_has_images.shows_id INNER JOIN images ON shows_has_images.images_id = images.id WHERE shows.type = 'movie' ORDER BY shows.ranking LIMIT 3;";
            List<DataHandler> allMoviesMM = dbConnector.Select(query, 3);

            query = "SELECT shows.id, shows.title, images.placement FROM shows INNER JOIN shows_has_images ON shows.id = shows_has_images.shows_id inner JOIN images ON shows_has_images.images_id = images.id ORDER BY shows.id DESC LIMIT 5";
            List<DataHandler> allShowsMM = dbConnector.Select(query, 3);

            query = "SELECT genre FROM genres";
            List<DataHandler> allGenresMM = dbConnector.Select(query, 1);

            _allGenresMM = allGenresMM;
            _allMoviesMM = allMoviesMM;
            _allSeriesMM = allSeriesMM;
            _allShowsMM = allShowsMM;

            //genres
            
            label23.Text = allGenresMM[0].I1;
            label24.Text = allGenresMM[1].I1;
            label25.Text = allGenresMM[2].I1;
            label26.Text = allGenresMM[3].I1;
            label27.Text = allGenresMM[4].I1;
            label28.Text = allGenresMM[5].I1;
            label29.Text = allGenresMM[6].I1;
            label30.Text = allGenresMM[7].I1;
            label31.Text = allGenresMM[8].I1;
            label32.Text = allGenresMM[9].I1;
            label33.Text = allGenresMM[10].I1;
            label34.Text = allGenresMM[11].I1;




            //1
            label12.Text = allShowsMM[0].I2;
            pictureBox1.Image = Image.FromFile(path + allShowsMM[0].I3);
            //2
            label13.Text = allShowsMM[1].I2;
            pictureBox2.Image = Image.FromFile(path + allShowsMM[1].I3);
            //3
            label14.Text = allShowsMM[2].I2;
            pictureBox3.Image = Image.FromFile(path + allShowsMM[2].I3);
            //4
            label15.Text = allShowsMM[3].I2;
            pictureBox4.Image = Image.FromFile(path + allShowsMM[3].I3);
            //5
            label16.Text = allShowsMM[4].I2;
            pictureBox5.Image = Image.FromFile(path + allShowsMM[4].I3);

            //top series
            label17.Text = allSeriesMM[0].I2;
            pictureBox6.Image = Image.FromFile(path + allSeriesMM[0].I3);

            label18.Text = allSeriesMM[1].I2;
            pictureBox7.Image = Image.FromFile(path + allSeriesMM[1].I3);

            label19.Text = allSeriesMM[2].I2;
            pictureBox8.Image = Image.FromFile(path + allSeriesMM[2].I3);



            //top movies
            label20.Text = allMoviesMM[0].I2;
            pictureBox9.Image = Image.FromFile(path + allMoviesMM[0].I3);

            label21.Text = allMoviesMM[1].I2;
            pictureBox10.Image = Image.FromFile(path + allMoviesMM[1].I3);

            label22.Text = allMoviesMM[2].I2;
            pictureBox11.Image = Image.FromFile(path + allMoviesMM[2].I3);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new NotImplementedException();
        }



        public void label12_Click(object sender, EventArgs e)
        {
            new NotImplementedException();
        }
        /*
         * made by Shanshe Gundishvili 
         * date: 23.01.2022
         * desc: this methode makes so the application actually closes when clicking on exit
         */
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl1Det = new ShowDetail(_allShowsMM[0].I1);
            lbl1Det.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl2Det = new ShowDetail(_allShowsMM[1].I1);
            lbl2Det.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl3Det = new ShowDetail(_allShowsMM[2].I1);
            lbl3Det.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl4Det = new ShowDetail(_allShowsMM[3].I1);
            lbl4Det.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl5Det = new ShowDetail(_allShowsMM[4].I1);
            lbl5Det.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl6Det = new ShowDetail(_allSeriesMM[0].I1);
            lbl6Det.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl7Det = new ShowDetail(_allSeriesMM[1].I1);
            lbl7Det.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl8Det = new ShowDetail(_allSeriesMM[2].I1);
            lbl8Det.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl9Det = new ShowDetail(_allMoviesMM[0].I1);
            lbl9Det.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl10Det = new ShowDetail(_allMoviesMM[1].I1);
            lbl10Det.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowDetail lbl11Det = new ShowDetail(_allMoviesMM[2].I1);
            lbl11Det.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            TopShowPage TCP = new();
            TCP.Show();
        }
    }
}
