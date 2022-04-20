using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP.Beans
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Titulo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Proveedor()
        {

        }

        public Proveedor(int id, string titulo, string telefono, string direccion)
        {
            IdProveedor = id;
            Titulo = titulo;
            Telefono = telefono;
            Direccion = direccion;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
