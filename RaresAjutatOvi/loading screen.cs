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
    public partial class loading_screen : Form
    {
        public loading_screen()
        {
            InitializeComponent();
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        { 
                timer1.Stop();
                Hide();
                Form1 x = new Form1();
                x.ShowDialog();
                Close();
            
        }
    }
}
