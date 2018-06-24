namespace Gersof.Common.Logger.TestForm
{
    partial class FrmTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnerr = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnerr
            // 
            this.btnerr.Location = new System.Drawing.Point(61, 55);
            this.btnerr.Name = "btnerr";
            this.btnerr.Size = new System.Drawing.Size(75, 23);
            this.btnerr.TabIndex = 0;
            this.btnerr.Text = "Error";
            this.btnerr.UseVisualStyleBackColor = true;
            this.btnerr.Click += new System.EventHandler(this.btnerr_Click);
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(61, 113);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(75, 23);
            this.btninfo.TabIndex = 1;
            this.btninfo.Text = "Info";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.btnerr);
            this.Name = "FrmTest";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnerr;
        private System.Windows.Forms.Button btninfo;
    }
}

