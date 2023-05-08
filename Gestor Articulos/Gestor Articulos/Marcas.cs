using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gestor_Articulos
{
    public partial class Marcas : Form
    {
        private List<Marca> listaMarca;
        public Marcas()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaMarca VentanaNewMar = new NuevaMarca();
            VentanaNewMar.ShowDialog();
        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias VentanaCat = new Categorias();
            VentanaCat.ShowDialog();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevaCategoria VentanaNewCat = new NuevaCategoria();
            VentanaNewCat.ShowDialog();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulos VentanaArt = new Articulos();
            VentanaArt.ShowDialog();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Nuevo_Articulo VentanaNewArt = new Nuevo_Articulo();
            VentanaNewArt.ShowDialog();
        }


        private void Marcas_Load(object sender, EventArgs e)
        {

            CargarPrincipal();
            
        }

        private void CargarPrincipal() 
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarca = negocio.listar();
                DgvMarcas.DataSource = listaMarca;
                DgvMarcas.Columns["Id"].Visible = false;

                listaMarca = negocio.listar();
                DgvMarcas.DataSource = listaMarca;


            }
            catch (Exception)
            {

                throw;

            }
        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            NuevaMarca VentanaNewMar = new NuevaMarca();
            VentanaNewMar.ShowDialog();
            CargarPrincipal();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio negocio = new MarcaNegocio();
                DialogResult respuesta = MessageBox.Show("Se Eliminara de manera permanente ,Desea seguir?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Marca seleccionado = (Marca)DgvMarcas.CurrentRow.DataBoundItem;
                    negocio.EliminarFisico(seleccionado.Id);
                    CargarPrincipal();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
