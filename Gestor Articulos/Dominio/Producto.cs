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
        public Int64 CodArtículo{ get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria{ get; set; }

        public string Imagen { get; set; }
        public Decimal Precio { get; set; }

     
}
