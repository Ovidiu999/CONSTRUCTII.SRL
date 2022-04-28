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

            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Height = button9.Height;
            panel3.Top = button9.Top;

            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Height = button10.Height;
            panel3.Top = button10.Top;
        }
    }
}
