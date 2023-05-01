
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
            this.LblArticulo = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.BtnMarcas = new System.Windows.Forms.Button();
            this.BtnCategorias = new System.Windows.Forms.Button();
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(299, 46);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(169, 24);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Gestor de Articulos";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblArticulo
            // 
            this.LblArticulo.AutoSize = true;
            this.LblArticulo.Location = new System.Drawing.Point(202, 265);
            this.LblArticulo.Name = "LblArticulo";
            this.LblArticulo.Size = new System.Drawing.Size(47, 13);
            this.LblArticulo.TabIndex = 6;
            this.LblArticulo.Text = "Articulos";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(358, 265);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(57, 13);
            this.LblCategoria.TabIndex = 7;
            this.LblCategoria.Text = "Categorias";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(527, 265);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(42, 13);
            this.LblMarca.TabIndex = 8;
            this.LblMarca.Text = "Marcas";
            // 
            // BtnMarcas
            // 
            this.BtnMarcas.Image = global::Gestor_Articulos.Properties.Resources.marca;
            this.BtnMarcas.Location = new System.Drawing.Point(503, 162);
            this.BtnMarcas.Name = "BtnMarcas";
            this.BtnMarcas.Size = new System.Drawing.Size(83, 83);
            this.BtnMarcas.TabIndex = 5;
            this.BtnMarcas.UseVisualStyleBackColor = true;
            this.BtnMarcas.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.AccessibleDescription = "";
            this.BtnCategorias.Image = global::Gestor_Articulos.Properties.Resources._677299;
            this.BtnCategorias.Location = new System.Drawing.Point(332, 162);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(83, 83);
            this.BtnCategorias.TabIndex = 4;
            this.BtnCategorias.UseVisualStyleBackColor = true;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.AccessibleDescription = "";
            this.BtnArticulos.AutoSize = true;
            this.BtnArticulos.Image = global::Gestor_Articulos.Properties.Resources._929250;
            this.BtnArticulos.Location = new System.Drawing.Point(185, 162);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(83, 83);
            this.BtnArticulos.TabIndex = 3;
            this.BtnArticulos.Tag = "";
            this.BtnArticulos.UseVisualStyleBackColor = true;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblArticulo);
            this.Controls.Add(this.BtnMarcas);
            this.Controls.Add(this.BtnCategorias);
            this.Controls.Add(this.BtnArticulos);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnArticulos;
        private System.Windows.Forms.Button BtnCategorias;
        private System.Windows.Forms.Button BtnMarcas;
        private System.Windows.Forms.Label LblArticulo;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblMarca;
    }
}

