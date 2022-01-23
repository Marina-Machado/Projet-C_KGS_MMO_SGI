using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prospopedia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool verify;
            User user = new User();
            verify = user.Login(textBox1.Text, textBox2.Text);
            if (verify == false)
            {
                textBox2.Text = "";
                MessageBox.Show("invalid username or password");
            }
            else
            {
                this.Hide();
                
                MainMenu mainMenu = new();
                mainMenu.Show();
            }
        }
    }
}