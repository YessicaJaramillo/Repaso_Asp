namespace Repaso_Asp
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
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(354, 206);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(75, 23);
            this.btnIncrementar.TabIndex = 3;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(300, 129);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(166, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.TextBox txtNumero;
    }
}

