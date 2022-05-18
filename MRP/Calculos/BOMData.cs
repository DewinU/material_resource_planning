using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using MRP.Beans;

namespace MRP.Calculos
{
    public static class BOMData
    {

        public static readonly List<BOM> Boms = new List<BOM>();
        public static readonly List<BOMDetalle> BomDetalles = new List<BOMDetalle>();

        public static List<BOM> BomList
        {
            get
            {
                if (Boms.Count < 1)
                {
                    populateListBOM();
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
                    populateBomDetails();
                }
                return BomDetalles;
            }
        }


        private static void populateListBOM()
        {
            BOM bom = new BOM(1, 1, "Mesa BOM");


            Boms.Add(bom);

        }

        private static void populateBomDetails()
        {

            List<BOMDetalle> prueba = new List<BOMDetalle>();
            BOMDetalle bom1 = new BOMDetalle(1, 1, 2, 4);
            BOMDetalle bom2 = new BOMDetalle(2, 0, 3, 1);

            BomDetalles.Add(bom1);
            BomDetalles.Add(bom2);



        }

        public static List<String> getMpByIDBOm(int id)
        {

            var pruba =
                from bd in BdList where bd.idBom == id select bd;

            var ahorasi = from p in pruba
                          join mp in mpData.MpLista on p.idMp equals mp.IdMP
                          select mp.Nombre;

            var prueba2 = BomList.Where(x => x.IdBOM == id).Join(BdList, b => b.IdBOM, d => d.idBom, (bom, detalle) => new
            {
                idBom = bom.IdBOM,
                idMP = detalle.idMp
            }).Join(mpData.MpLista, d => d.idMP, mp => mp.IdMP, (detalle, materia) => new
            {
                Nombre1 = materia.Nombre

            }).ToList();

            return ahorasi.ToList();



        }

        public static int getLasId()
        {
            return BomList.Count + 1;
        }

        public static int getLastIdDetail()
        {
            return BdList.Count + 1;
        }

        public static void deleteBom(int id)
        {
            var pruba =
                from bd in BdList where bd.idBom == id select bd;

            List<BOMDetalle> det = new List<BOMDetalle>();
            det = pruba.ToList();
            foreach (var vt in det)
            {
                BdList.Remove(vt);
            }

           // BomList.Remove(BomList.First(x => x.IdBOM == id));
        }

    }
}
