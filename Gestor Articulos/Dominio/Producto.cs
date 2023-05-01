using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public Int32 Id { get; set; }
        public string CodArtículo { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }

        //la idea es que tenga una lista de imagenes  
        public ImagenArticulo ImgArt { get; set; }

        public Decimal Precio { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
