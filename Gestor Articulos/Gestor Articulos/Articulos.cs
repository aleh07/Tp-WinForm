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

            CargarPaginaIncial();
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
        }

        private void CargarPaginaIncial()
        {

            ProductoNegocio negocio = new ProductoNegocio();
            try
            {


                listaProductos = negocio.listar();
                dgvProducto.DataSource = listaProductos;
                dgvProducto.Columns["Id"].Visible = false;

                Int32 IdArt = listaProductos[0].Id; ;
                listaImagenes = negocio.listarImgArt(IdArt);
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
        private void dgvProducto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.CurrentRow != null)
                {
                    ProductoNegocio negocio = new ProductoNegocio();
                    Producto seleccionado = (Producto)dgvProducto.CurrentRow.DataBoundItem;
                    listaImagenes = negocio.listarImgArt(seleccionado.Id);
                    DgvImagenes.DataSource = listaImagenes;
                    DgvImagenes.Columns[0].Visible = false;
                    DgvImagenes.Columns[2].Visible = false;
                    
                }
               

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


            PBoxImgArt.Load(listaImagenes[0].Imagen);

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nuevo_Articulo VentanaNewArt = new Nuevo_Articulo();
            VentanaNewArt.ShowDialog();
            CargarPaginaIncial();

        }

        private void DgvImagenes_Click(object sender, EventArgs e)
        {
            ImagenArticulo seleccionado = (ImagenArticulo)DgvImagenes.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }

        private  void Eliminar() 
        {

            try
            {
                ProductoNegocio negocio = new ProductoNegocio();
                DialogResult respuesta = MessageBox.Show("Se Eliminara de manera permanente ,Desea seguir?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Producto seleccionado = (Producto)dgvProducto.CurrentRow.DataBoundItem;
                    negocio.EliminarFisico(seleccionado.Id);
                    CargarPaginaIncial();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            Eliminar();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Producto seleccionado;
            seleccionado = (Producto)dgvProducto.CurrentRow.DataBoundItem;

            Nuevo_Articulo modificar = new Nuevo_Articulo(seleccionado);
            modificar.ShowDialog();
            CargarPaginaIncial();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar campo y criterio para hacer una búsqueda avanzada");
                return true;
            }
            if (cboCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar campo y criterio para hacer una búsqueda avanzada");
                return true;
            }
            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            ProductoNegocio producto = new ProductoNegocio();

            try
            {
                if (validarFiltro())
                    return;
                
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvProducto.DataSource = producto.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

        

        private void BtnImagenes_Click(object sender, EventArgs e)
        {

            Producto seleccionado;
            seleccionado = (Producto)dgvProducto.CurrentRow.DataBoundItem;

            NuevaImgArt VentanaNewImg = new NuevaImgArt(seleccionado);
            VentanaNewImg.ShowDialog();
            CargarPaginaIncial();

        }

        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            List<Producto> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {

                listaFiltrada = listaProductos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.categoria.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripción.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaProductos;
            }

            dgvProducto.DataSource = null;
            dgvProducto.DataSource = listaFiltrada;
            dgvProducto.Columns["Id"].Visible = false;
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion != "")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");

            }
        }
    }
}

