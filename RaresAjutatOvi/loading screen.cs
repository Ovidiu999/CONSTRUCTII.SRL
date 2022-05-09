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
        private string text;
        private int len = 0;
        public loading_screen()
        {
            InitializeComponent();
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            

        }

        #region going to another form
        private void timer1_Tick(object sender, EventArgs e)
        { 
                timer1.Stop();
                Hide();
                Form1 x = new Form1();
                x.ShowDialog();
                Close();
            
        }
        #endregion
        
      
        private void loading_screen_Load(object sender, EventArgs e)
        {
            text = label1.Text;
            label1.Text = "";
            timer2.Start();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                label1.Text = label1.Text + text.ElementAt(len);
                len++;
            }
            else
                timer2.Stop();
        }
              
     

        
    }
}
