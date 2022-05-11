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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            loadform(new insert());
        }
        #region form in form
        private bool close = false;
        private Form activeform = null;
        public void loadform(Form f)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            if (close == true)
            {
                f.Close();
                close = false;
               
            }
            else
            {
                activeform = f;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
               
                Controls.Add(f);
                f.BringToFront();
                f.Show();
            }
        }
        #endregion
        #region buttons
        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new insert());
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new stergere());
        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
