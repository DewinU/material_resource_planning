using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP.Beans
{
    public class BOMDetalle
    {
        public int idBomDetalle { get; set; }
        public int idBom { get; set; }
        public int idMp { get; set; }
        public int cantidad { get; set; }

        public BOMDetalle(int id, int idb, int idMp, int cantidad)
        {
            idBomDetalle = id;
            idBom = idb;
            this.idMp = idMp;
            this.cantidad = cantidad;
        }

        public BOMDetalle()
        {

        }


    }
}
