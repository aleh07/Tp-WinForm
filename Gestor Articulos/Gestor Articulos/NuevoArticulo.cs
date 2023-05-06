﻿using System;
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
        private Producto producto = null;
      
        
        public Nuevo_Articulo()
        {
            InitializeComponent();
        }
        public Nuevo_Articulo(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            Text = "Modificar Producto";
        }

      
 private void Nuevo_Articulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                comboBoxMarca.DataSource = marca.listar();
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DisplayMember = "Nombre";

                comboBoxCategoria.DataSource = categoria.listar();
                comboBoxCategoria.ValueMember = "Id";
                comboBoxCategoria.DisplayMember = "Nombre";

                if (producto != null)
                {
                    TxtCodigo.Text = producto.CodArtículo.ToString();
                    txtNombre.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripción;
                    txtPrecio.Text = producto.Precio.ToString();
                    comboBoxMarca.SelectedValue = producto.marca.Id.ToString();
                    comboBoxCategoria.SelectedValue = producto.categoria.Id.ToString();
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnCargarArt_Click(object sender, EventArgs e)
        {
            //Producto producto = new Producto();
            ProductoNegocio productoNegocio = new ProductoNegocio();
           ImagenArticulo imagenNuevo = new ImagenArticulo();
            try
            {
               if(producto == null)
                producto = new Producto();  
               

                producto.CodArtículo = TxtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripción = txtDescripcion.Text;
                producto.marca = (Marca)comboBoxMarca.SelectedItem;
                producto.categoria = (Categoria)comboBoxCategoria.SelectedItem;
                producto.Precio = Decimal.Parse(txtPrecio.Text);
                imagenNuevo.Imagen = txtImagen.Text;
                Int32 IdArt = productoNegocio.UltimoId();
                imagenNuevo.IdProducto = IdArt+1 ;

                if (producto.Id != 0)
                {
                    productoNegocio.Modificar(producto);
                    MessageBox.Show("Modificado exitosamente");
                    
                }
                else
                {
                   
                    productoNegocio.agregar(producto,imagenNuevo);
                    MessageBox.Show("Agregado exitosamente");
                }
                
                this.Refresh();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
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

       

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
    }
}
