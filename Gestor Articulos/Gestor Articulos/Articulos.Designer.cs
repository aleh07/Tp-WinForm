
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.LblModificar = new System.Windows.Forms.Label();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.BtnImagenes = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.PBoxImgArt = new System.Windows.Forms.PictureBox();
            this.LblLeyenda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GBGestores = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GbImg = new System.Windows.Forms.GroupBox();
            this.BtnmodificarImg = new System.Windows.Forms.Button();
            this.BtnEliminarImg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GBImgGestores = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt)).BeginInit();
            this.GBGestores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbImg.SuspendLayout();
            this.GBImgGestores.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(999, 25);
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
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.LblTitulo.Location = new System.Drawing.Point(285, 93);
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
            this.dgvProducto.Location = new System.Drawing.Point(22, 77);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(599, 173);
            this.dgvProducto.TabIndex = 5;
            this.dgvProducto.SelectionChanged += new System.EventHandler(this.dgvProducto_SelectionChanged);
            // 
            // DgvImagenes
            // 
            this.DgvImagenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvImagenes.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.DgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvImagenes.Location = new System.Drawing.Point(665, 266);
            this.DgvImagenes.MultiSelect = false;
            this.DgvImagenes.Name = "DgvImagenes";
            this.DgvImagenes.ReadOnly = true;
            this.DgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvImagenes.Size = new System.Drawing.Size(175, 95);
            this.DgvImagenes.TabIndex = 11;
            this.DgvImagenes.SelectionChanged += new System.EventHandler(this.DgvImagenes_SelectionChanged);
            this.DgvImagenes.Click += new System.EventHandler(this.DgvImagenes_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.Image = global::Gestor_Articulos.Properties.Resources.Sin_título;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(524, 150);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 48);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LblImagenes
            // 
            this.LblImagenes.AutoSize = true;
            this.LblImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImagenes.Location = new System.Drawing.Point(694, 228);
            this.LblImagenes.Name = "LblImagenes";
            this.LblImagenes.Size = new System.Drawing.Size(200, 25);
            this.LblImagenes.TabIndex = 15;
            this.LblImagenes.Text = "Imagenes x Articulo";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(385, 177);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(133, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged_1);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(339, 180);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 25;
            this.lblFiltro.Text = "Filtro";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(225, 177);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(103, 21);
            this.cboCriterio.TabIndex = 2;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(179, 180);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 23;
            this.lblCriterio.Text = "Criterio";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(70, 177);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(98, 21);
            this.cboCampo.TabIndex = 1;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(24, 185);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(40, 13);
            this.lblcampo.TabIndex = 21;
            this.lblcampo.Text = "Campo";
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Location = new System.Drawing.Point(194, 465);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(50, 13);
            this.LblModificar.TabIndex = 8;
            this.LblModificar.Text = "Modificar";
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Location = new System.Drawing.Point(267, 21);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(46, 13);
            this.LblEliminar.TabIndex = 9;
            this.LblEliminar.Text = "Eliminar ";
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(66, 464);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblAgregar.TabIndex = 11;
            this.lblAgregar.Text = "Agregar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Agregar mas imagenes";
            // 
            // btnDetalle
            // 
            this.btnDetalle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalle.BackColor = System.Drawing.Color.Silver;
            this.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetalle.Image = global::Gestor_Articulos.Properties.Resources._929250;
            this.btnDetalle.Location = new System.Drawing.Point(365, 37);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(86, 83);
            this.btnDetalle.TabIndex = 6;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // BtnImagenes
            // 
            this.BtnImagenes.Image = global::Gestor_Articulos.Properties.Resources.nuevo21;
            this.BtnImagenes.Location = new System.Drawing.Point(30, 33);
            this.BtnImagenes.Name = "BtnImagenes";
            this.BtnImagenes.Size = new System.Drawing.Size(86, 84);
            this.BtnImagenes.TabIndex = 8;
            this.BtnImagenes.UseVisualStyleBackColor = true;
            this.BtnImagenes.Click += new System.EventHandler(this.BtnImagenes_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Gestor_Articulos.Properties.Resources.nuevo21;
            this.btnAgregar.Location = new System.Drawing.Point(48, 480);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 84);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEliminar.Image = global::Gestor_Articulos.Properties.Resources.registro__eliminado;
            this.BtnEliminar.Location = new System.Drawing.Point(247, 36);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 83);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.AutoSize = true;
            this.BtnModificar.Image = global::Gestor_Articulos.Properties.Resources.registro_detalle;
            this.BtnModificar.Location = new System.Drawing.Point(161, 481);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(83, 83);
            this.BtnModificar.TabIndex = 9;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // PBoxImgArt
            // 
            this.PBoxImgArt.Location = new System.Drawing.Point(16, 19);
            this.PBoxImgArt.Name = "PBoxImgArt";
            this.PBoxImgArt.Size = new System.Drawing.Size(90, 70);
            this.PBoxImgArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxImgArt.TabIndex = 11;
            this.PBoxImgArt.TabStop = false;
            // 
            // LblLeyenda
            // 
            this.LblLeyenda.AutoSize = true;
            this.LblLeyenda.Location = new System.Drawing.Point(179, 402);
            this.LblLeyenda.Name = "LblLeyenda";
            this.LblLeyenda.Size = new System.Drawing.Size(211, 13);
            this.LblLeyenda.TabIndex = 27;
            this.LblLeyenda.Text = "Seleccione una fila si desea administrarlos..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Seleccione una fila si desea  ver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Detalle";
            // 
            // GBGestores
            // 
            this.GBGestores.Controls.Add(this.BtnEliminar);
            this.GBGestores.Controls.Add(this.LblEliminar);
            this.GBGestores.Controls.Add(this.btnDetalle);
            this.GBGestores.Controls.Add(this.label3);
            this.GBGestores.Location = new System.Drawing.Point(20, 444);
            this.GBGestores.Name = "GBGestores";
            this.GBGestores.Size = new System.Drawing.Size(498, 131);
            this.GBGestores.TabIndex = 30;
            this.GBGestores.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProducto);
            this.groupBox1.Controls.Add(this.GbImg);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 289);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // GbImg
            // 
            this.GbImg.Controls.Add(this.PBoxImgArt);
            this.GbImg.Location = new System.Drawing.Point(834, 128);
            this.GbImg.Name = "GbImg";
            this.GbImg.Size = new System.Drawing.Size(122, 95);
            this.GbImg.TabIndex = 32;
            this.GbImg.TabStop = false;
            // 
            // BtnmodificarImg
            // 
            this.BtnmodificarImg.AutoSize = true;
            this.BtnmodificarImg.Image = global::Gestor_Articulos.Properties.Resources.registro_detalle;
            this.BtnmodificarImg.Location = new System.Drawing.Point(146, 34);
            this.BtnmodificarImg.Name = "BtnmodificarImg";
            this.BtnmodificarImg.Size = new System.Drawing.Size(83, 83);
            this.BtnmodificarImg.TabIndex = 32;
            this.BtnmodificarImg.UseVisualStyleBackColor = true;
            this.BtnmodificarImg.Click += new System.EventHandler(this.BtnmodificarImg_Click);
            // 
            // BtnEliminarImg
            // 
            this.BtnEliminarImg.AutoSize = true;
            this.BtnEliminarImg.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEliminarImg.Image = global::Gestor_Articulos.Properties.Resources.registro__eliminado;
            this.BtnEliminarImg.Location = new System.Drawing.Point(247, 33);
            this.BtnEliminarImg.Name = "BtnEliminarImg";
            this.BtnEliminarImg.Size = new System.Drawing.Size(86, 83);
            this.BtnEliminarImg.TabIndex = 33;
            this.BtnEliminarImg.UseVisualStyleBackColor = true;
            this.BtnEliminarImg.Click += new System.EventHandler(this.BtnEliminarImg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Modificar IMG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Eliminar IMG";
            // 
            // GBImgGestores
            // 
            this.GBImgGestores.Controls.Add(this.label6);
            this.GBImgGestores.Controls.Add(this.label4);
            this.GBImgGestores.Controls.Add(this.BtnImagenes);
            this.GBImgGestores.Controls.Add(this.BtnmodificarImg);
            this.GBImgGestores.Controls.Add(this.BtnEliminarImg);
            this.GBImgGestores.Controls.Add(this.label1);
            this.GBImgGestores.Location = new System.Drawing.Point(635, 448);
            this.GBImgGestores.Name = "GBImgGestores";
            this.GBImgGestores.Size = new System.Drawing.Size(352, 131);
            this.GBImgGestores.TabIndex = 36;
            this.GBImgGestores.TabStop = false;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(999, 591);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.LblModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.LblLeyenda);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.LblImagenes);
            this.Controls.Add(this.DgvImagenes);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBGestores);
            this.Controls.Add(this.GBImgGestores);
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
            this.GBGestores.ResumeLayout(false);
            this.GBGestores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.GbImg.ResumeLayout(false);
            this.GBImgGestores.ResumeLayout(false);
            this.GBImgGestores.PerformLayout();
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
        private System.Windows.Forms.Label LblLeyenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBGestores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GbImg;
        private System.Windows.Forms.Button BtnmodificarImg;
        private System.Windows.Forms.Button BtnEliminarImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GBImgGestores;
    }
}