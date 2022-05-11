namespace RaresAjutatOvi
{
    partial class Fundație
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fundație));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this._proiect__1_DataSet = new RaresAjutatOvi._proiect__1_DataSet();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiTableAdapter = new RaresAjutatOvi._proiect__1_DataSetTableAdapters.AngajatiTableAdapter();
            this.tableAdapterManager = new RaresAjutatOvi._proiect__1_DataSetTableAdapters.TableAdapterManager();
            this.serviciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciiTableAdapter = new RaresAjutatOvi._proiect__1_DataSetTableAdapters.ServiciiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._proiect__1_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1718, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(237, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fundație casă";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(696, 518);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(728, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(673, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "   Prețul pentru constructia unui șanț este de :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(1450, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(761, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(701, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Angajații care se ocupa de acest proiect sunt:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DataSource = this.angajatiBindingSource;
            this.listBox1.DisplayMember = "Nume";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 38;
            this.listBox1.Location = new System.Drawing.Point(735, 508);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(424, 190);
            this.listBox1.TabIndex = 11;
            this.listBox1.ValueMember = "IDA";
            // 
            // _proiect__1_DataSet
            // 
            this._proiect__1_DataSet.DataSetName = "_proiect__1_DataSet";
            this._proiect__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this._proiect__1_DataSet;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AngajatiTableAdapter = this.angajatiTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientiTableAdapter = null;
            this.tableAdapterManager.ContracteTableAdapter = null;
            this.tableAdapterManager.ServiciiTableAdapter = this.serviciiTableAdapter;
            this.tableAdapterManager.UpdateOrder = RaresAjutatOvi._proiect__1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serviciiBindingSource
            // 
            this.serviciiBindingSource.DataMember = "Servicii";
            this.serviciiBindingSource.DataSource = this._proiect__1_DataSet;
            // 
            // serviciiTableAdapter
            // 
            this.serviciiTableAdapter.ClearBeforeFill = true;
            // 
            // Fundație
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1718, 1102);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fundație";
            this.Text = "Fundație";
            this.Load += new System.EventHandler(this.Fundație_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._proiect__1_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private _proiect__1_DataSet _proiect__1_DataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private _proiect__1_DataSetTableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private _proiect__1_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _proiect__1_DataSetTableAdapters.ServiciiTableAdapter serviciiTableAdapter;
        private System.Windows.Forms.BindingSource serviciiBindingSource;
    }
}