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
    public partial class Nuevo_Articulo : Form
    {
        public Nuevo_Articulo()
        {
            InitializeComponent();
        }

        private void LblArticulos_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCargarArt_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoNegocio productoNegocio = new ProductoNegocio();
            try
            {
                producto.CodArtículo = TxtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripción = txtDescripcion.Text;
                producto.marca = (Marca)comboBoxMarca.SelectedItem;
                producto.categoria = (Categoria)comboBoxCategoria.SelectedItem;
                producto.Precio = Decimal.Parse(txtPrecio.Text);

                productoNegocio.agregar(producto);
                MessageBox.Show("Agregado exitosamente");
                this.Refresh();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nuevo_Articulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                comboBoxMarca.DataSource = marca.listar();
                comboBoxCategoria.DataSource = categoria.listar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
