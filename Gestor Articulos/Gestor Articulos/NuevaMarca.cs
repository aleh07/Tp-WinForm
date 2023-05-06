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
    public partial class NuevaMarca : Form
    {
        public NuevaMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            MarcaNegocio Marcanegocio = new MarcaNegocio();

            try
            {

                Marca aux = new Marca();
                aux.Nombre = txtNombre.Text;

                Marcanegocio.agregar(aux);
                MessageBox.Show("agregado sin problema");
                this.Close();




            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
