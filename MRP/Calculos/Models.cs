using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP.Calculos
{
    public class Models
    {
        public static void l4l(DataGridView table, float costo_pedido, int periodos, int[] demanta_total)
        {
            float costoTotal = 0;
            for (int i = 0; i < periodos; i++)
            {
                costoTotal += costo_pedido;
                table.Rows.Add(new DataGridViewRow());
                table.Rows[i].Cells["periodoClm"].Value = i + 1;
                table.Rows[i].Cells["demandaClm"].Value = demanta_total[i].ToString();
                table.Rows[i].Cells["productoPedirClm"].Value = demanta_total[i].ToString();
                table.Rows[i].Cells["inventarioFinalClm"].Value = 0.ToString();
                table.Rows[i].Cells["costoMantenimientoClm"].Value = 0.ToString();
                table.Rows[i].Cells["costoPedidoClm"].Value = costo_pedido.ToString();
                table.Rows[i].Cells["costoTotalClm"].Value = costoTotal.ToString();
            }
        }

        public static void makeTable(int cantidad, DataGridView table,float costo_producto, float tasa_mantenimiento, float costo_pedido, int periodos, int[] demanta_total)
        {
            float costoTotal = 0;
            int invFinal = 0;
            for (int i = 0; i < periodos; i++)
            {
                table.Rows.Add(new DataGridViewRow());
                table.Rows[i].Cells["periodoClm"].Value = (i + 1).ToString();
                table.Rows[i].Cells["demandaClm"].Value = demanta_total[i].ToString();
                int newProductoPedir;;
                float newCostoPedido;
                if (invFinal - demanta_total[i] < 0)
                {
                    newProductoPedir = cantidad;
                    newCostoPedido = costo_pedido;
                    
                }
                else
                {
                    newProductoPedir = 0;
                    newCostoPedido = 0;   
                }
                table.Rows[i].Cells["productoPedirClm"].Value = newProductoPedir.ToString();
                table.Rows[i].Cells["costoPedidoClm"].Value = newCostoPedido.ToString();
                invFinal += (newProductoPedir - demanta_total[i]);
                table.Rows[i].Cells["inventarioFinalClm"].Value = invFinal.ToString();
                float costo_mantenimiento = invFinal * costo_producto * tasa_mantenimiento / 100;
                table.Rows[i].Cells["costoMantenimientoClm"].Value = costo_mantenimiento.ToString();
                costoTotal += costo_mantenimiento + newCostoPedido;
                table.Rows[i].Cells["costoTotalClm"].Value = costoTotal.ToString();
            }
        }

        public static void eoq(DataGridView table, float costo_producto, float tasa_mantenimiento, float costo_pedido, int periodos, int[] demanta_total)
        {
            table.Rows.Clear();
            float demandaAnualPromedio = (float)(demanta_total.Average() * 52);
            int cantidadOpt = (int)Math.Floor(Math.Sqrt((2 * demandaAnualPromedio * costo_pedido) / (tasa_mantenimiento / 100 * costo_producto * 52)));
            makeTable(cantidadOpt, table, costo_producto, tasa_mantenimiento, costo_pedido, periodos, demanta_total);
        }


        public static void ctm(DataGridView table, float costo_producto, float tasa_mantenimiento, float costo_pedido, int periodos, int[] demanta_total)
        {
            int? demanda = null;
            float? minGap = null;
            for(int i = 0; i < periodos; i++)
            {
                float sumaMantenimiento = 0;
                int cantidad = 0;
                for(int j = 0; j <= i; j++)
                {
                    float costoMantenimiento = costo_producto * demanta_total[j] * (tasa_mantenimiento / 100) * j;
                    sumaMantenimiento += costoMantenimiento;
                    cantidad += demanta_total[j];
                }
                float gap = Math.Abs(sumaMantenimiento - costo_pedido);
                if(minGap != null)
                {
                    if(gap < minGap)
                    {
                        demanda = cantidad;
                        minGap = gap;
                    }
                }
                else
                {
                    demanda = cantidad;
                    minGap=gap;
                }
            }
            makeTable((int)demanda, table, costo_producto, tasa_mantenimiento, costo_pedido, periodos, demanta_total);
        }


        public static void cum(DataGridView table, float costo_producto, float tasa_mantenimiento, float costo_pedido, int periodos, int[] demanta_total)
        {
            int? demanda = null;
            float? minCU = null;
            for (int i = 0; i < periodos; i++)
            {
                float costoTotal = costo_pedido;
                int cantidad = 0;
                for (int j = 0; j <= i; j++)
                {
                    float costoMantenimiento = costo_producto * demanta_total[j] * (tasa_mantenimiento / 100) * j;
                    costoTotal += costoMantenimiento;
                    cantidad += demanta_total[j];
                }
                float cu = costoTotal / cantidad;
                if (minCU != null)
                {
                    if (cu < minCU)
                    {
                        demanda = cantidad;
                        minCU = cu;
                    }
                }
                else
                {
                    demanda = cantidad;
                    minCU = cu;
                }
            }
            makeTable((int)demanda, table, costo_producto, tasa_mantenimiento, costo_pedido, periodos, demanta_total);
        }

    }
}
