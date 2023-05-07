
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LblImagenes = new System.Windows.Forms.Label();
            this.PBoxImgArt = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblModificar = new System.Windows.Forms.Label();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.BtnImagenes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt)).BeginInit();
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
            this.LblTitulo.Location = new System.Drawing.Point(259, 61);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(105, 29);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Articulos";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvProducto.Location = new System.Drawing.Point(12, 149);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(621, 262);
            this.dgvProducto.TabIndex = 5;
            this.dgvProducto.SelectionChanged += new System.EventHandler(this.dgvProducto_SelectionChanged);
            // 
            // DgvImagenes
            // 
            this.DgvImagenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvImagenes.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.DgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvImagenes.Location = new System.Drawing.Point(12, 446);
            this.DgvImagenes.MultiSelect = false;
            this.DgvImagenes.Name = "DgvImagenes";
            this.DgvImagenes.ReadOnly = true;
            this.DgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvImagenes.Size = new System.Drawing.Size(261, 95);
            this.DgvImagenes.TabIndex = 10;
            this.DgvImagenes.SelectionChanged += new System.EventHandler(this.DgvImagenes_SelectionChanged);
            this.DgvImagenes.Click += new System.EventHandler(this.DgvImagenes_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(508, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 42);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LblImagenes
            // 
            this.LblImagenes.AutoSize = true;
            this.LblImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImagenes.Location = new System.Drawing.Point(44, 414);
            this.LblImagenes.Name = "LblImagenes";
            this.LblImagenes.Size = new System.Drawing.Size(222, 29);
            this.LblImagenes.TabIndex = 15;
            this.LblImagenes.Text = "Imagenes x Articulo";
            // 
            // PBoxImgArt
            // 
            this.PBoxImgArt.Location = new System.Drawing.Point(313, 446);
            this.PBoxImgArt.Name = "PBoxImgArt";
            this.PBoxImgArt.Size = new System.Drawing.Size(135, 106);
            this.PBoxImgArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxImgArt.TabIndex = 11;
            this.PBoxImgArt.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(401, 112);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 26;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged_1);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(355, 115);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 25;
            this.lblFiltro.Text = "Filtro";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(241, 112);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(103, 21);
            this.cboCriterio.TabIndex = 24;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(195, 115);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 23;
            this.lblCriterio.Text = "Criterio";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(86, 112);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(98, 21);
            this.cboCampo.TabIndex = 22;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(40, 120);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(40, 13);
            this.lblcampo.TabIndex = 21;
            this.lblcampo.Text = "Campo";
            // 
            // BtnModificar
            // 
            this.BtnModificar.AutoSize = true;
            this.BtnModificar.Image = global::Gestor_Articulos.Properties.Resources.registro_detalle;
            this.BtnModificar.Location = new System.Drawing.Point(639, 331);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(83, 83);
            this.BtnModificar.TabIndex = 0;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Location = new System.Drawing.Point(639, 315);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(50, 13);
            this.LblModificar.TabIndex = 8;
            this.LblModificar.Text = "Modificar";
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Location = new System.Drawing.Point(741, 315);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(46, 13);
            this.LblEliminar.TabIndex = 9;
            this.LblEliminar.Text = "Eliminar ";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEliminar.Image = global::Gestor_Articulos.Properties.Resources.registro__eliminado;
            this.BtnEliminar.Location = new System.Drawing.Point(744, 331);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 83);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Gestor_Articulos.Properties.Resources.nuevo21;
            this.btnAgregar.Location = new System.Drawing.Point(639, 219);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 84);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(645, 203);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblAgregar.TabIndex = 11;
            this.lblAgregar.Text = "Agregar";
            // 
            // BtnImagenes
            // 
            this.BtnImagenes.Image = global::Gestor_Articulos.Properties.Resources.nuevo21;
            this.BtnImagenes.Location = new System.Drawing.Point(744, 219);
            this.BtnImagenes.Name = "BtnImagenes";
            this.BtnImagenes.Size = new System.Drawing.Size(86, 84);
            this.BtnImagenes.TabIndex = 12;
            this.BtnImagenes.UseVisualStyleBackColor = true;
            this.BtnImagenes.Click += new System.EventHandler(this.BtnImagenes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(741, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Agregar mas imagenes";
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(663, 149);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(167, 38);
            this.btnDetalle.TabIndex = 16;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(895, 564);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnImagenes);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.LblEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.LblModificar);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.LblImagenes);
            this.Controls.Add(this.PBoxImgArt);
            this.Controls.Add(this.DgvImagenes);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem2;
        private System.Windows.Forms.DataGridView DgvImagenes;
        private System.Windows.Forms.PictureBox PBoxImgArt;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LblImagenes;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label LblModificar;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Button BtnImagenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetalle;
    }
}