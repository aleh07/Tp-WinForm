
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
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblCod = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblDesc = new System.Windows.Forms.Label();
            this.LblPre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.LblMarc = new System.Windows.Forms.Label();
            this.LblCat = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.PBoxImgArt = new System.Windows.Forms.PictureBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.GBArt = new System.Windows.Forms.GroupBox();
            this.Lblimg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.GBArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnCargarArt
            // 
            this.BtnCargarArt.Location = new System.Drawing.Point(31, 333);
            this.BtnCargarArt.Name = "BtnCargarArt";
            this.BtnCargarArt.Size = new System.Drawing.Size(125, 23);
            this.BtnCargarArt.TabIndex = 8;
            this.BtnCargarArt.Text = "Cargar Articulo";
            this.BtnCargarArt.UseVisualStyleBackColor = true;
            this.BtnCargarArt.Click += new System.EventHandler(this.BtnCargarArt_Click);
            // 
            // LblArticulos
            // 
            this.LblArticulos.AutoSize = true;
            this.LblArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArticulos.Location = new System.Drawing.Point(276, 54);
            this.LblArticulos.Name = "LblArticulos";
            this.LblArticulos.Size = new System.Drawing.Size(109, 16);
            this.LblArticulos.TabIndex = 0;
            this.LblArticulos.Text = "Nuevo Articulo";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(110, 132);
            this.TxtCodigo.MaxLength = 50;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 1;
            // 
            // LblCod
            // 
            this.LblCod.AutoSize = true;
            this.LblCod.Location = new System.Drawing.Point(47, 139);
            this.LblCod.Name = "LblCod";
            this.LblCod.Size = new System.Drawing.Size(40, 13);
            this.LblCod.TabIndex = 4;
            this.LblCod.Text = "Código";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(47, 175);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(44, 13);
            this.LblNom.TabIndex = 5;
            this.LblNom.Text = "Nombre";
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Location = new System.Drawing.Point(41, 208);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(63, 13);
            this.LblDesc.TabIndex = 6;
            this.LblDesc.Text = "Descripción";
            // 
            // LblPre
            // 
            this.LblPre.AutoSize = true;
            this.LblPre.Location = new System.Drawing.Point(247, 220);
            this.LblPre.Name = "LblPre";
            this.LblPre.Size = new System.Drawing.Size(37, 13);
            this.LblPre.TabIndex = 7;
            this.LblPre.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 168);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(110, 205);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // LblMarc
            // 
            this.LblMarc.AutoSize = true;
            this.LblMarc.Location = new System.Drawing.Point(247, 135);
            this.LblMarc.Name = "LblMarc";
            this.LblMarc.Size = new System.Drawing.Size(37, 13);
            this.LblMarc.TabIndex = 11;
            this.LblMarc.Text = "Marca";
            // 
            // LblCat
            // 
            this.LblCat.AutoSize = true;
            this.LblCat.Location = new System.Drawing.Point(247, 173);
            this.LblCat.Name = "LblCat";
            this.LblCat.Size = new System.Drawing.Size(52, 13);
            this.LblCat.TabIndex = 12;
            this.LblCat.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(310, 173);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(545, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(250, 263);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(55, 13);
            this.lblImagen.TabIndex = 16;
            this.lblImagen.Text = "UrlImagen";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(310, 260);
            this.txtImagen.MaxLength = 1000;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 7;
            this.txtImagen.TextChanged += new System.EventHandler(this.txtImagen_TextChanged);
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // PBoxImgArt
            // 
            this.PBoxImgArt.Location = new System.Drawing.Point(400, 80);
            this.PBoxImgArt.Name = "PBoxImgArt";
            this.PBoxImgArt.Size = new System.Drawing.Size(214, 105);
            this.PBoxImgArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxImgArt.TabIndex = 18;
            this.PBoxImgArt.TabStop = false;
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(310, 218);
            this.numPrecio.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(100, 20);
            this.numPrecio.TabIndex = 6;
            this.numPrecio.ThousandsSeparator = true;
            this.numPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(310, 132);
            this.comboBoxMarca.MaxDropDownItems = 5;
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMarca.TabIndex = 4;
            // 
            // GBArt
            // 
            this.GBArt.Controls.Add(this.Lblimg);
            this.GBArt.Controls.Add(this.PBoxImgArt);
            this.GBArt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GBArt.Location = new System.Drawing.Point(31, 95);
            this.GBArt.Name = "GBArt";
            this.GBArt.Size = new System.Drawing.Size(639, 218);
            this.GBArt.TabIndex = 19;
            this.GBArt.TabStop = false;
            // 
            // Lblimg
            // 
            this.Lblimg.AutoSize = true;
            this.Lblimg.Location = new System.Drawing.Point(478, 55);
            this.Lblimg.Name = "Lblimg";
            this.Lblimg.Size = new System.Drawing.Size(42, 13);
            this.Lblimg.TabIndex = 20;
            this.Lblimg.Text = "Imagen";
            // 
            // Nuevo_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(712, 384);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.LblCat);
            this.Controls.Add(this.LblMarc);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LblPre);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.LblCod);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblArticulos);
            this.Controls.Add(this.BtnCargarArt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GBArt);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nuevo_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Nuevo_Articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.GBArt.ResumeLayout(false);
            this.GBArt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BtnCargarArt;
        private System.Windows.Forms.Label LblArticulos;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblCod;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Label LblPre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label LblMarc;
        private System.Windows.Forms.Label LblCat;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.PictureBox PBoxImgArt;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.GroupBox GBArt;
        private System.Windows.Forms.Label Lblimg;
    }
}