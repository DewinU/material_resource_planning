using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Beans;

namespace MRP.Calculos
{
    public static class BOMData
    {

        public static readonly List<BOM> Boms;
        public static readonly List<BOMDetalle> BomDetalles;

        public static List<BOM> BomList
        {
            get
            {
                if (Boms.Count < 1)
                {
                    //populateList();
                }
                return Boms;
            }
        }

        public static List<BOMDetalle> BdList
        {
            get
            {
                if (BomDetalles.Count < 1)
                {
                    //populateList();
                }
                return BomDetalles;
            }
        }
    }
}
