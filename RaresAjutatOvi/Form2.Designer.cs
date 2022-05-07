namespace RaresAjutatOvi
{
    partial class Form2
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
            this.FormGalerie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormGalerie
            // 
            this.FormGalerie.AutoSize = true;
            this.FormGalerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormGalerie.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormGalerie.Location = new System.Drawing.Point(296, 332);
            this.FormGalerie.Name = "FormGalerie";
            this.FormGalerie.Size = new System.Drawing.Size(404, 95);
            this.FormGalerie.TabIndex = 1;
            this.FormGalerie.Text = "GALERIE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(936, 601);
            this.Controls.Add(this.FormGalerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormGalerie;
    }
}