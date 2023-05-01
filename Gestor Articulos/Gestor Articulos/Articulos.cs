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
    public partial class Articulos : Form
    {
       private List<Producto> listaProductos;
        private List<ImagenArticulo> listaImagenes;
        public Articulos()
        {
            InitializeComponent();
        }
       
        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Articulo VentanaNewArt = new Nuevo_Articulo();
            VentanaNewArt.ShowDialog();
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

        private void verTodasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Marcas VentanaMar = new Marcas();
            VentanaMar.ShowDialog();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NuevaMarca VentanaNewMar = new NuevaMarca();
            VentanaNewMar.ShowDialog();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {

            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                listaProductos = negocio.listar();
                dgvProducto.DataSource = listaProductos;
                dgvProducto.Columns["Id"].Visible = false;
                dgvProducto.Columns["imgArt"].Visible = false;

                listaImagenes = negocio.listarImgArt();
                DgvImagenes.DataSource = listaImagenes;
                DgvImagenes.Columns[0].Visible = false;
                DgvImagenes.Columns[2].Visible = false;
                PBoxImgArt.Load(listaImagenes[0].Imagen); 
                
                    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
