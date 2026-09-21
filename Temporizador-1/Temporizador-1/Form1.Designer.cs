namespace Temporizador_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblReloj = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEjecuccion = new System.Windows.Forms.Label();
            this.btnEncender = new System.Windows.Forms.Button();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(48, 9);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(63, 69);
            this.lblReloj.TabIndex = 0;
            this.lblReloj.Text = "0";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(48, 78);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 69);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "0";
            // 
            // lblEjecuccion
            // 
            this.lblEjecuccion.AutoSize = true;
            this.lblEjecuccion.Location = new System.Drawing.Point(12, 168);
            this.lblEjecuccion.Name = "lblEjecuccion";
            this.lblEjecuccion.Size = new System.Drawing.Size(156, 16);
            this.lblEjecuccion.TabIndex = 2;
            this.lblEjecuccion.Text = "Tiempo en ejecuccion : 0";
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(212, 162);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(88, 29);
            this.btnEncender.TabIndex = 3;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 204);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.lblEjecuccion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblReloj);
            this.Name = "Form1";
            this.Text = "Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEjecuccion;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Timer tmrReloj;
    }
}

