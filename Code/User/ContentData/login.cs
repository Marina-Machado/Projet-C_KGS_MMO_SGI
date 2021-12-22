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

namespace ContentData
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool verify;
            User user = new User();
            verify = user.Login(textBox1.Text, textBox2.Text);
            if(verify== false)
            {
                textBox2.Text = "";
                MessageBox.Show("invalid username or password");
            }
            else
            {
                MessageBox.Show("Logged in !!");
            }

        }
    }
}
