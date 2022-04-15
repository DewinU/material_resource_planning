﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP.Beans
{
    public class MateriaPrima
    {
        public int IdMP { get; set; }
        public int IdProv { get; set; }
        public string Nombre { get; set; }
        public string UdM { get; set; }
        public int MinStock { get; set; }
        public float TiempoEntrega { get; set; }
        public float PrecioCompra { get; set; }
        public int Stock { get; set; }
        public bool isProcured { get; set; }

       
    }

}
