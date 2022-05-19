using System;
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
        public int? MinStock { get; set; }
        public double PrecioCompra { get; set; }
        public int? TiempoEntrega { get; set; }
        public int Stock { get; set; }
        public bool isProcured { get; set; }
        public double? costoMantenimiento { get; set; }
        public double? costoEnvio { get; set; }
        public double? tasaMantenimiento { get; set; }

        public MateriaPrima()
        {

        }

        public MateriaPrima(int idMp, int idProv, string nombre, string udm, int minStock, double precioCompra, int tiempoEntregam, int stock, bool isProcured, double costoMant, double costoEnvio, double tasaMantenimiento)
        {
            this.IdMP = idMp;
            this.IdProv = idProv;
            this.Nombre = nombre;
            this.UdM = udm;
            this.MinStock = minStock;
            this.PrecioCompra = precioCompra;
            this.TiempoEntrega = tiempoEntregam;
            this.Stock = stock;
            this.isProcured = isProcured;
            this.costoMantenimiento = costoMant;
            this.costoEnvio = costoEnvio;
            this.tasaMantenimiento = tasaMantenimiento;
        }
        public MateriaPrima(int idMp, string nombre, string udm, int minStock, double precioCompra, int tiempoEntregam, int stock, bool isProcured, double costoMant, double costoEnvio, double tasaMantenimiento)
        {
            this.IdMP = idMp;

            this.Nombre = nombre;
            this.UdM = udm;
            this.MinStock = minStock;
            this.PrecioCompra = precioCompra;
            this.TiempoEntrega = tiempoEntregam;
            this.Stock = stock;
            this.isProcured = isProcured;
            this.costoMantenimiento = costoMant;
            this.costoEnvio = costoEnvio;
            this.tasaMantenimiento = tasaMantenimiento;
        }







    }

}
