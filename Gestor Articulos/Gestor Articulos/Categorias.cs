using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Gestor_Articulos
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCategoria VetanaNewCat = new NuevaCategoria();
            VetanaNewCat.ShowDialog();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas VentanaMar = new Marcas();
            VentanaMar.ShowDialog();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevaMarca VentanaNewMar = new NuevaMarca();
            VentanaNewMar.ShowDialog();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Articulos VentanaArt = new Articulos();
            VentanaArt.ShowDialog();
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Nuevo_Articulo VentanaNewArt = new Nuevo_Articulo();
            VentanaNewArt.ShowDialog();
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            dgvCategoria.DataSource = categoria.listar();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CargarPrincipal();
        }

        private void CargarPrincipal()
        {

            CategoriaNegocio categoria = new CategoriaNegocio();
            dgvCategoria.DataSource = categoria.listar();
            dgvCategoria.Columns["Id"].Visible = false;
        }

        private void btbAgregar_Click(object sender, EventArgs e)
        {

            NuevaCategoria VetanaNewCat = new NuevaCategoria();
            VetanaNewCat.ShowDialog();
            CargarPrincipal();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                DialogResult respuesta = MessageBox.Show("Se Eliminara de manera permanente ,Desea seguir?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    negocio.EliminarFisico(seleccionado.Id);
                    CargarPrincipal();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
