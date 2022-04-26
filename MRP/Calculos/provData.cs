using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Beans;

namespace MRP.Calculos
{
    public static class provData
    {

        public static readonly List<Proveedor> ProvList = new List<Proveedor>();

        public static List<Proveedor> ListProveedors
        {
            get
            {
                if (ProvList.Count < 1)
                {
                    populateList();
                }
                return ProvList;
            }
        }
        public static void newProveedor(Proveedor proveedor)
        {

            ProvList.Add(proveedor);

        }

        public static void editProveedor(int id, string titulo, string telefono, string direccion)
        {
            Proveedor p = ProvList.FirstOrDefault(prod => id == prod.IdProveedor);
            p.Titulo = titulo;
            p.Direccion = direccion;
            p.Telefono = telefono;


        }

        public static void deleteProveedor(int id)
        {
            ProvList.Remove(ProvList.Find(p => p.IdProveedor == id));
        }



        public static Proveedor GetProveedorById(int id)
        {
            return ProvList.Find(p => p.IdProveedor == id);
        }

        public static void populateList()
        {
            Proveedor prov1 = new Proveedor(1, "Empresa x", "888-8888-888", "Cerca de la UCA");
            Proveedor prov2 = new Proveedor(2, "Empresa Y", "999-888-777", "Cerca de Metrocentro");
            Proveedor prov3 = new Proveedor(3, "Empresa z", "666-555-111", "Cerca del Rupap");
            Proveedor prov4 = new Proveedor(4, "Empresa A", "444-333-222", "Cerca de Claro");

            newProveedor(prov1);
            newProveedor(prov2);
            newProveedor(prov3);
            newProveedor(prov4);

        }

        public static int getLastId()
        {
            return ProvList.Count + 1;

        }

    }
}
