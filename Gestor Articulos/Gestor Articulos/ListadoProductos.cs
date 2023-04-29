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
            //ProductoNegocio negocio = new ProductoNegocio();
            //listaProductos = negocio.listar();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
