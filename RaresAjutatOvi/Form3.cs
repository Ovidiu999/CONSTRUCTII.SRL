using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaresAjutatOvi
{
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Black;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent; /// imi face label ul transparent
            textBox1.PasswordChar = '*';

        }
        #region back-end password

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
                MessageBox.Show("Please enter the password");
            else
                if (textBox1.Text == "2003")
            {
                Home x = new Home();
                x.Show();

            }
            else
                MessageBox.Show("Wrong password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            this.Close();
        }

        #endregion

        #region show/un-show password
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                pictureBox3.BringToFront(); /// not necessary
                textBox1.PasswordChar = '\0';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                pictureBox3.BringToFront(); /// not necessary
                textBox1.PasswordChar = '*';
            }
        }



        #endregion

       
    }
}
