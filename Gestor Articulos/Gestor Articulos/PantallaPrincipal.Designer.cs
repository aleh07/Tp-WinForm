
namespace Gestor_Articulos
{
    partial class FrmPrincipal
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(286, 101);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(169, 24);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Gestor de Articulos";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.AutoSize = true;
            this.BtnArticulos.Image = global::Gestor_Articulos.Properties.Resources.registro_detalle;
            this.BtnArticulos.Location = new System.Drawing.Point(185, 162);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(83, 83);
            this.BtnArticulos.TabIndex = 3;
            this.BtnArticulos.UseVisualStyleBackColor = true;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Gestor_Articulos.Properties.Resources._1587795;
            this.button2.Location = new System.Drawing.Point(332, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 83);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Gestor_Articulos.Properties.Resources.marca;
            this.button3.Location = new System.Drawing.Point(503, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 83);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnArticulos);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnArticulos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

