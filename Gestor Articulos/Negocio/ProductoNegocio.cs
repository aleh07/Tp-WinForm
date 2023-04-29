using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;


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
                datos.setearConsulta("SELECT A.id, Nombre, A.descripcion, M.descripcion as marca, C.descripcion as categoria, I.ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I \r\nwhere A.IdMarca = M.Id and C.Id = A.IdCategoria and I.IdArticulo = A.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripción = (string)datos.Lector["Descripcion"];
                    aux.marca = (Marca)datos.Lector["marca"];
                    aux.categoria = (Categoria)datos.Lector["categoria"];
                    aux.ImgArt = (ImagenArticulo)datos.Lector["ImagenUrl"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

    
