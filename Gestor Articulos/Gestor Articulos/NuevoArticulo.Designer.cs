
namespace Gestor_Articulos
{
    partial class Nuevo_Articulo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnCargarArt = new System.Windows.Forms.Button();
            this.LblArticulos = new System.Windows.Forms.Label();
            this.TxtArticulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnCargarArt
            // 
            this.BtnCargarArt.Location = new System.Drawing.Point(370, 169);
            this.BtnCargarArt.Name = "BtnCargarArt";
            this.BtnCargarArt.Size = new System.Drawing.Size(125, 23);
            this.BtnCargarArt.TabIndex = 1;
            this.BtnCargarArt.Text = "Cargar Articulo";
            this.BtnCargarArt.UseVisualStyleBackColor = true;
            // 
            // LblArticulos
            // 
            this.LblArticulos.AutoSize = true;
            this.LblArticulos.Location = new System.Drawing.Point(384, 78);
            this.LblArticulos.Name = "LblArticulos";
            this.LblArticulos.Size = new System.Drawing.Size(77, 13);
            this.LblArticulos.TabIndex = 2;
            this.LblArticulos.Text = "Nuevo Articulo";
            // 
            // TxtArticulo
            // 
            this.TxtArticulo.Location = new System.Drawing.Point(370, 109);
            this.TxtArticulo.Name = "TxtArticulo";
            this.TxtArticulo.Size = new System.Drawing.Size(100, 20);
            this.TxtArticulo.TabIndex = 3;
            // 
            // Nuevo_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtArticulo);
            this.Controls.Add(this.LblArticulos);
            this.Controls.Add(this.BtnCargarArt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Nuevo_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BtnCargarArt;
        private System.Windows.Forms.Label LblArticulos;
        private System.Windows.Forms.TextBox TxtArticulo;
    }
}