using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
=======
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;


>>>>>>> ff18944925276e0cf72dab6c8324f11259465a08
namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.id,A.codigo, A.Nombre, A.descripcion,M.descripcion as marca , C.descripcion as categoria, I.ImagenUrl, a.precio from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where A.IdMarca = M.Id and C.Id = A.IdCategoria and I.IdArticulo = A.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = (Int32)datos.Lector["Id"];
                    aux.CodArtículo = (string)datos.Lector["codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripción = (string)datos.Lector["Descripcion"];
                    aux.ImgArt = new ImagenArticulo();
                    aux.ImgArt.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["precio"];
                    aux.marca = new Marca();
                    aux.marca.Nombre = (string)datos.Lector["marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.Nombre = (string)datos.lector["categoria"];
>>>>>>> ff18944925276e0cf72dab6c8324f11259465a08



                    lista.Add(aux);
                }

                return lista;
<<<<<<< HEAD
            }
=======
            } 
>>>>>>> ff18944925276e0cf72dab6c8324f11259465a08
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
<<<<<<< HEAD

       



    }
}

=======
    }
}

    
>>>>>>> ff18944925276e0cf72dab6c8324f11259465a08
