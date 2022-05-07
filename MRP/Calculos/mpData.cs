using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using MRP.Beans;

namespace MRP.Calculos
{
    public static class mpData
    {
        public static readonly List<MateriaPrima> mpList = new List<MateriaPrima>();

        public static List<MateriaPrima> MpLista
        {
            get
            {
                if (mpList.Count < 1)
                {
                    populateList();
                }
                return mpList;
            }
        }

        public static void newMateria(MateriaPrima mp)
        {

            mpList.Add(mp);
        }

        public static void deleteMp(int id)
        {
            mpList.Remove(mpList.FirstOrDefault(prod => prod.IdMP == id));
        }

        public static MateriaPrima findById(int id)
        {
            return mpList.FirstOrDefault(prod => prod.IdMP == id);
        }

        public static void editMp(int id, string nombre, string UdM, int minStock, double precio, int stock, int tiempoEntrega, bool isProc, double costoMantenimiento, double costoEnvio, double tasaMante)
        {
            MateriaPrima mp = mpList.FirstOrDefault(prod => prod.IdMP == id);
            mp.Nombre = nombre;
            mp.UdM = UdM;
            mp.MinStock = minStock;
            mp.PrecioCompra = precio;
            mp.Stock = stock;
            mp.TiempoEntrega = tiempoEntrega;
            mp.isProcured = isProc;
            mp.tasaMantenimiento = tasaMante;




        }

        public static List<MateriaPrima> getMpByProv(int idProv)
        {
            //var mpProv = from prod in mpList where prod.IdProv == idProv select prod;
            var mpProv = mpList.Select(mp => new { V = mp.IdProv = idProv });
            return mpList.ToList();
        }

        public static MateriaPrima getMpByName(string nombre)
        {
            return mpList.FirstOrDefault(prod => prod.Nombre.Equals(nombre));
        }

        private static void populateList()
        {
            MateriaPrima prima = new MateriaPrima(1, 1, "Mesa", "Und", 3, 50, 2, 30, true, 4, 10, 0.10);
            MateriaPrima prima1 = new MateriaPrima(2, 1, "Pata de Mesa", "Und", 4, 25, 1, 52, false, 5, 5, 0.05);
            MateriaPrima prima2 = new MateriaPrima(3, "Tabla de Mesa", "Und", 2, 10, 2, 35, false, 5, 8, 0.07);

            mpList.Add(prima);
            mpList.Add(prima1);
            mpList.Add(prima2);
        }

        public static int getLastId()
        {
            return mpList.Count + 1;
        }

        public static List<String> getIsProcuredMP(bool flag)
        {
            if (flag)
            {
                var mpProcured = from materia in mpList where materia.isProcured select materia.IdMP + " " + materia.Nombre;
                return mpProcured.ToList();
            }
            else
            {
                var mpProcured = from materia in mpList where !materia.isProcured select materia.IdMP + " " + materia.Nombre;
                return mpProcured.ToList();
            }

        }


    }
}
