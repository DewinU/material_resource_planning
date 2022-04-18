using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Beans;

namespace MRP.Calculos
{
    public class provData
    {
        public List<Proveedor> ProvList = new List<Proveedor>();

        public provData()
        {
            populateList();
        }
        public void newProveedor(int id, string titulo, string telefono, string direccion)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = id;
            proveedor.Titulo = titulo;
            proveedor.Telefono = telefono;
            proveedor.Direccion = direccion;
            ProvList.Add(proveedor);

        }

        public void editProveedor(int id, string titulo, string telefono, string direccion)
        {
            Proveedor p = ProvList.FirstOrDefault(prod => id == prod.IdProveedor);
            p.Titulo = titulo;
            p.Direccion = direccion;
            p.Telefono = telefono;


        }

        public void deleteProveedor(int id)
        {
            ProvList.Remove(ProvList.Find(p => p.IdProveedor == id));
        }

        public List<Proveedor> getListProv()
        {

            return ProvList;
        }

        public Proveedor GetProveedorById(int id)
        {
            return ProvList.Find(p => p.IdProveedor == id);
        }

        private void populateList()
        {
            newProveedor(1, "Empresa x", "888-8888-888", "Cerca de la UCA");
            newProveedor(2, "Empresa Y", "999-888-777", "Cerca de Metrocentro");
            newProveedor(3, "Empresa z", "666-555-111", "Cerca del Rupap");
            newProveedor(4, "Empresa A", "444-333-222", "Cerca de Claro");
        }

    }
}
