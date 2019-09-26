using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinnacleSoftware.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public Boolean Estado { get; set; } = true;
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }

    }
}
