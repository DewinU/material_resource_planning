using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP.Beans
{
    public class BOM
    {
        public int IdBOM { get; set; }
        public int IdProducto { get; set; }
        public string nombreBOM { get; set; }

        public BOM(int id, int idProducto, string nombreBOM)
        {
            IdBOM = id;
            IdProducto = idProducto;
            this.nombreBOM = nombreBOM;
        }

        public BOM()
        {

        }

    }


}
