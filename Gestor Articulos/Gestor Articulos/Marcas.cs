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
using Negocio;
using Dominio;
namespace Gestor_Articulos
{
    public partial class Marcas : Form
    {
        private List<Marca> listaMarca;
<<<<<<< HEAD
=======

>>>>>>> ec1af2688d30ddf87c86577a321ac1e24d9d2798
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
<<<<<<< HEAD

        private void Marcas_Load(object sender, EventArgs e)
        {
             MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                       listaMarca = negocio.listar();
                        DgvMarcas.DataSource = listaMarca;
=======
      
        private void Marcas_Load_1(object sender, EventArgs e)
        {
         MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarca = negocio.listar();
                DgvMarcas.DataSource = listaMarca;
>>>>>>> ec1af2688d30ddf87c86577a321ac1e24d9d2798

            }
            catch (Exception)
            {

                throw;
<<<<<<< HEAD
            }
        }   
=======
            }       
        }
>>>>>>> ec1af2688d30ddf87c86577a321ac1e24d9d2798
    }
}
