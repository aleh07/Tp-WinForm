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
        private Producto producto;
        private int ImgProducto = 0;
        public Articulos()
        {
            InitializeComponent();
        }
        public Articulos(Producto ProdCargado)
        {
            InitializeComponent();
            producto = ProdCargado;
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
                if (producto == null)
                {
                    listaProductos = negocio.listar();
                    dgvProducto.DataSource = listaProductos;
                    dgvProducto.Columns["Id"].Visible = false;

                    Int32 IdArt = 1;
                    listaImagenes = negocio.listarImgArt(IdArt);
                    DgvImagenes.DataSource = listaImagenes;
                    DgvImagenes.Columns[0].Visible = false;
                    DgvImagenes.Columns[2].Visible = false;
                    PBoxImgArt.Load(listaImagenes[0].Imagen);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dgvProducto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio negocio = new ProductoNegocio();
                Producto seleccionado = (Producto)dgvProducto.CurrentRow.DataBoundItem;
                listaImagenes = negocio.listarImgArt(seleccionado.Id);
                DgvImagenes.DataSource = listaImagenes;
                DgvImagenes.Columns[0].Visible = false;
                DgvImagenes.Columns[2].Visible = false;
            }
  
            catch (Exception ex)
                {

                    PBoxImgArt.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
               
            }

            private void cargarImagen(string imagen)
            {
                try
                {
                    PBoxImgArt.Load(imagen);
                }
                catch (Exception ex)
                {
                    PBoxImgArt.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
            }

            private void DgvImagenes_SelectionChanged(object sender, EventArgs e)
            {

                if (producto == null)
                {
                    PBoxImgArt.Load(listaImagenes[0].Imagen);

                    ImgProducto = 1;
                }
                else
                {
                    
                }
            }

            private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {


            }

        }
    }

