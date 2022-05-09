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
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
          ///  textBox1.BackColor = Color.FromArgb(0, Color.Black);
            
        }

        private void angajatiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.angajatiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._proiect__1_DataSet);

        }

        private void insert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_proiect__1_DataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this._proiect__1_DataSet.Angajati);

        }
        #region insert
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                string prenume = textBox3.Text;
                int ids = int.Parse(textBox4.Text);
                string salariu = textBox5.Text;
                angajatiTableAdapter.InsertQuery(id, name, prenume, ids, salariu);
                this.angajatiTableAdapter.Fill(this._proiect__1_DataSet.Angajati);
                MessageBox.Show(" Database updated ");
            }
            catch
            {
                MessageBox.Show(" You've written something wrong ");
            }
            


        }
        #endregion
    }
}
