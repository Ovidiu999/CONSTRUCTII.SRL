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
        }
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
               
                
                f.BringToFront();
                f.Show();
            }
        }
    }
}
