
namespace Gestor_Articulos
{
    partial class Articulos
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.DgvImagenes = new System.Windows.Forms.DataGridView();
            this.PBoxImgArt = new System.Windows.Forms.PictureBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblModificar = new System.Windows.Forms.Label();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.marcasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.nuevoToolStripMenuItem.Text = "Ges&tionar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::Gestor_Articulos.Properties.Resources.agregar_registro;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.eliminarToolStripMenuItem.Text = "Nuevo";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.NuevoToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodasToolStripMenuItem,
            this.nuevoToolStripMenuItem1});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Cat&egorias";
            // 
            // verTodasToolStripMenuItem
            // 
            this.verTodasToolStripMenuItem.Image = global::Gestor_Articulos.Properties.Resources.lupa_registro;
            this.verTodasToolStripMenuItem.Name = "verTodasToolStripMenuItem";
            this.verTodasToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.verTodasToolStripMenuItem.Text = "Ver Todas";
            this.verTodasToolStripMenuItem.Click += new System.EventHandler(this.verTodasToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Image = global::Gestor_Articulos.Properties.Resources.agregar_registro;
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodasToolStripMenuItem1,
            this.nuevoToolStripMenuItem2});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.marcasToolStripMenuItem.Text = "Marca&s";
            // 
            // verTodasToolStripMenuItem1
            // 
            this.verTodasToolStripMenuItem1.Image = global::Gestor_Articulos.Properties.Resources.lupa_registro;
            this.verTodasToolStripMenuItem1.Name = "verTodasToolStripMenuItem1";
            this.verTodasToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.verTodasToolStripMenuItem1.Text = "Ver Todas";
            this.verTodasToolStripMenuItem1.Click += new System.EventHandler(this.verTodasToolStripMenuItem1_Click);
            // 
            // nuevoToolStripMenuItem2
            // 
            this.nuevoToolStripMenuItem2.Image = global::Gestor_Articulos.Properties.Resources.agregar_registro;
            this.nuevoToolStripMenuItem2.Name = "nuevoToolStripMenuItem2";
            this.nuevoToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
            this.nuevoToolStripMenuItem2.Text = "Nuevo";
            this.nuevoToolStripMenuItem2.Click += new System.EventHandler(this.nuevoToolStripMenuItem2_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(264, 38);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(105, 29);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Articulos";
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(12, 70);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(621, 240);
            this.dgvProducto.TabIndex = 5;
            this.dgvProducto.SelectionChanged += new System.EventHandler(this.dgvProducto_SelectionChanged);
            // 
<<<<<<< HEAD
=======
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAgregar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.LblEliminar);
            this.groupBox1.Controls.Add(this.LblModificar);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Location = new System.Drawing.Point(639, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 339);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(46, 16);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblAgregar.TabIndex = 11;
            this.lblAgregar.Text = "Agregar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Gestor_Articulos.Properties.Resources.nuevo21;
            this.btnAgregar.Location = new System.Drawing.Point(26, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 84);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Location = new System.Drawing.Point(46, 240);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(43, 13);
            this.LblEliminar.TabIndex = 9;
            this.LblEliminar.Text = "Eliminar";
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Location = new System.Drawing.Point(39, 129);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(50, 13);
            this.LblModificar.TabIndex = 8;
            this.LblModificar.Text = "Modificar";
            // 
            // BtnModificar
            // 
            this.BtnModificar.AutoSize = true;
            this.BtnModificar.Image = global::Gestor_Articulos.Properties.Resources.registro_detalle;
            this.BtnModificar.Location = new System.Drawing.Point(26, 145);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(86, 83);
            this.BtnModificar.TabIndex = 0;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
>>>>>>> 47ecde4aac7405bb0dd723d856c5b90c9936f155
            // DgvImagenes
            // 
            this.DgvImagenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvImagenes.Location = new System.Drawing.Point(23, 339);
            this.DgvImagenes.MultiSelect = false;
            this.DgvImagenes.Name = "DgvImagenes";
            this.DgvImagenes.ReadOnly = true;
            this.DgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvImagenes.Size = new System.Drawing.Size(261, 95);
            this.DgvImagenes.TabIndex = 10;
            this.DgvImagenes.SelectionChanged += new System.EventHandler(this.DgvImagenes_SelectionChanged);
            this.DgvImagenes.Click += new System.EventHandler(this.DgvImagenes_Click);
            // 
            // PBoxImgArt
            // 
            this.PBoxImgArt.Location = new System.Drawing.Point(333, 339);
            this.PBoxImgArt.Name = "PBoxImgArt";
            this.PBoxImgArt.Size = new System.Drawing.Size(279, 106);
            this.PBoxImgArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxImgArt.TabIndex = 11;
            this.PBoxImgArt.TabStop = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.Image = global::Gestor_Articulos.Properties.Resources.registro__eliminado;
            this.BtnEliminar.Location = new System.Drawing.Point(26, 283);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 83);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.AutoSize = true;
            this.BtnModificar.Image = global::Gestor_Articulos.Properties.Resources.registro_detalle;
            this.BtnModificar.Location = new System.Drawing.Point(26, 145);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(86, 83);
            this.BtnModificar.TabIndex = 0;
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Location = new System.Drawing.Point(39, 129);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(50, 13);
            this.LblModificar.TabIndex = 8;
            this.LblModificar.Text = "Modificar";
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Location = new System.Drawing.Point(39, 258);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(73, 13);
            this.LblEliminar.TabIndex = 9;
            this.LblEliminar.Text = "Eliminar Fisico";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Gestor_Articulos.Properties.Resources.nuevo21;
            this.btnAgregar.Location = new System.Drawing.Point(26, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 84);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(46, 16);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblAgregar.TabIndex = 11;
            this.lblAgregar.Text = "Agregar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAgregar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.BtnEliminar);
            this.groupBox1.Controls.Add(this.LblEliminar);
            this.groupBox1.Controls.Add(this.LblModificar);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Location = new System.Drawing.Point(652, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 564);
            this.Controls.Add(this.PBoxImgArt);
            this.Controls.Add(this.DgvImagenes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasToolStripMenuItem1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem2;
        private System.Windows.Forms.DataGridView DgvImagenes;
        private System.Windows.Forms.PictureBox PBoxImgArt;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label LblModificar;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}