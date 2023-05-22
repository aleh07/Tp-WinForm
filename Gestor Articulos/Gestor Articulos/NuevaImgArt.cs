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
    public partial class NuevaImgArt : Form
    {

        private ImagenArticulo producto = null;

        
        public NuevaImgArt()
        {
            InitializeComponent();
        }

        public NuevaImgArt(ImagenArticulo producto)
        {
            InitializeComponent();
            this.producto = producto;

            
        }




        private void NuevaImgArt_Load(object sender, EventArgs e)
        {
            try
            {
               
                if (producto.PreView!= true)
                {
                    txtImagen1.Text = producto.Imagen;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        public bool ValidarCampos()
        {
            if (txtImagen1.Text == "")
            {
                MessageBox.Show("Hay campos vacios");

                return false;


            }
            else

            {

                return true;
            }

        }

        private void cargarImagen(string imagen)
        {
            try
            {

                PBoxImgArt1.Load(imagen);

            }
            catch (Exception ex)
            {
                PBoxImgArt1.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void txtImagen1_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen1.Text);
        }

        private void txtImagen1_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtImagen1.Text);
        }

        private void BtnCargarArt_Click(object sender, EventArgs e)
        {


            ProductoNegocio productoNegocio = new ProductoNegocio();
            ImagenArticulo imagenNuevo = new ImagenArticulo();

            try
            {
                if (producto.Id != 0 && producto.PreView != true )
                {
                    if (ValidarCampos() == true)
                    {
                        imagenNuevo.IdProducto = producto.Id;
                        imagenNuevo.Imagen = txtImagen1.Text;
                        imagenNuevo.Id = producto.Id;
                        productoNegocio.ModificarImg(imagenNuevo);
                        MessageBox.Show("Modificado exitosamente");
                        Close();
                    }
                }
                else
                {
                    if (ValidarCampos() == true)
                    {
                        imagenNuevo.IdProducto = producto.Id;
                        imagenNuevo.Imagen = txtImagen1.Text;
                        productoNegocio.agregarImg(imagenNuevo);
                        MessageBox.Show("Agregado exitosamente");
                        Close();

                    }

                }
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
    }
}
    

