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
    public partial class Form1 : Form
    {
        private bool close = false;
        private Form activeform = null;
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            
        }

        private void angajatiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.angajatiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._proiect__1_DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_proiect__1_DataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this._proiect__1_DataSet.Angajati);
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString(); ///timp real
            label2.Text = DateTime.Now.ToLongDateString(); /// data reala


            label3.Text = clientiTableAdapter1.nrClienti().ToString();
        }

        #region time and date
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        #endregion


        #region show/hide subMenu
        private void customizeDesign()
        {
            panel2.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

        #region buttons

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Height = button8.Height;
            panel3.Top = button8.Top;

            close = true;
            loadform(new Form1());
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Height = button9.Height;
            panel3.Top = button9.Top;

            
            loadform(new Form2());
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Height = button10.Height;
            panel3.Top = button10.Top;

            loadform(new despre_noi());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Șanț());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Fundație());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Transport());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Îndreptare());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new Modelare());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new Creare());
        }
        #endregion


        #region form in from

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
                pictureBox2.Visible = true;
            }
            else
            {
                activeform = f;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
                this.mainpanel.Tag = f;
                pictureBox2.Visible = false;
                f.BringToFront();
                f.Show();
            }
        }
        #endregion

        #region 
        private void Form2_Load(object sender, EventArgs e)
        {
            password x = new password();
            x.Show(); /// cand apas pe logo se intapla ceva
           

        }

        #endregion

      
    }
}
