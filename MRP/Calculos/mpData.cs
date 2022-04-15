using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Beans;

namespace MRP.Calculos
{
    public class mpData
    {
        public List<MateriaPrima> mpList = new List<MateriaPrima>();
        public void newMateria(int id, int idProv, string nombre, string UdM, int minStock, float precio, int stock, int tiempoEntrega, bool isProc)
        {
            MateriaPrima mp = new MateriaPrima();
            mp.IdMP = id;
            mp.IdProv = idProv;
            mp.Nombre = nombre;
            mp.UdM = UdM;
            mp.MinStock = minStock;
            mp.PrecioCompra = precio;
            mp.TiempoEntrega = tiempoEntrega;
            mp.isProcured = isProc;

            mpList.Add(mp);
        }

        public void deleteMp(int id)
        {
            mpList.Remove(mpList.FirstOrDefault(prod => prod.IdMP == id));
        }

        public MateriaPrima findById(int id)
        {
            return mpList.FirstOrDefault(prod => prod.IdMP == id);
        }

        public void editMp(int id, string nombre, string UdM, int minStock, float precio, int stock, int tiempoEntrega, bool isProc)
        {
            MateriaPrima mp = mpList.FirstOrDefault(prod => prod.IdMP == id);
            mp.Nombre = nombre;
            mp.UdM = UdM;
            mp.MinStock = minStock;
            mp.PrecioCompra = precio;
            mp.Stock = stock;
            mp.TiempoEntrega = tiempoEntrega;
            mp.isProcured = isProc;


        }

        public List<MateriaPrima> getMpByProv(int idProv)
        {
            //var mpProv = from prod in mpList where prod.IdProv == idProv select prod;
            var mpProv = mpList.Select(mp => new { V = mp.IdProv = idProv });
            return mpList.ToList();
        }
    }
}
