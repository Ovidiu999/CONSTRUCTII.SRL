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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        #region lista_de_poze
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 8)
            {
                pictureBox1.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count=0;
            }
                
        }
        #endregion
    }
}
