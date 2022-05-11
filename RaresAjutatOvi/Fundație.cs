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
    public partial class Fundație : Form
    {
        public Fundație()
        {
            InitializeComponent();
        }
        private void serviciiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviciiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._proiect__1_DataSet);

        }
        private void Fundație_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_proiect__1_DataSet.Servicii' table. You can move, or remove it, as needed.
            this.serviciiTableAdapter.Fill(this._proiect__1_DataSet.Servicii);
            // TODO: This line of code loads data into the '_proiect__1_DataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this._proiect__1_DataSet.Angajati);

            _proiect__1_DataSet.EnforceConstraints = false;
            int i;
            label3.Text = serviciiTableAdapter.pret("Fundatie casa").ToString();
            try
            {
                this.angajatiTableAdapter.ceva(this._proiect__1_DataSet.Angajati, 2).ToString();
                DataTable dp = _proiect__1_DataSet.Angajati;
                for (i = 0; i < dp.Rows.Count; i++)
                     listBox1.Items.Add(dp.Rows[i]["Nume"] + "  " + dp.Rows[i]["Prenume"]);
            }
            catch
            {
                MessageBox.Show(" Something went wrong ");
            }

        }
    }
}
