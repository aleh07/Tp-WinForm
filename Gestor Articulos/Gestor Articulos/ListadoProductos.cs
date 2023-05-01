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
    public partial class ListadoProductos : Form
    {
        private List<Producto> listaProductos;
        public ListadoProductos()
        {
            InitializeComponent();
        }

        private void ListadoProductos_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                listaProductos = negocio.listar();
                dgvProducto.DataSource = listaProductos;
                cargarImagen(listaProductos[0].ImgArt.Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducto_SelectionChanged(object sender, EventArgs e)
        {
            
            
                Producto seleccionado = (Producto)dgvProducto.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImgArt.Imagen);
            


        }   
        
        private void cargarImagen (string imagen)
        {
            try
            {

                pictureBoxProductos.Load(imagen);

            }
            
            catch(Exception ex)             
            {
                pictureBoxProductos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");     

            }

        }
    
    }
}
