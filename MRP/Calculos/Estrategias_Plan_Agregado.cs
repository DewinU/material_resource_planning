using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP.Calculos
{
    public class Estrategias_Plan_Agregado
    {
        public DataTable DT_Estrategias;

        public static DataTable DT_Persecucion;
        public static DataTable DT_F_Nivelada;
        public static DataTable DT_OutSourcing;


        public static int[] make_ss(DataGridView ss, int periodos, float tasa_ss, int[] demandas, int inv_ini)
        {
            //hacer tabla ss
            ss.Columns.Clear();
            ss.Rows.Clear();
            int stock;
            int req_prod;
            int[] lista_req_prod = new int[periodos];

            //columnas ss
            for (int i = 0; i < periodos; i++)
            {

                ss.Columns.Add("periodo_" + (i + 1).ToString(), "Periodo " + (i + 1).ToString());
            }
            //filas ss
            ss.Rows.Add();
            ss.Rows.Add();
            ss.Rows.Add();
            ss.Rows.Add();
            ss.Rows[0].HeaderCell.Value = "Demanda";
            ss.Rows[1].HeaderCell.Value = "SS";
            ss.Rows[2].HeaderCell.Value = "Inv Inicial";
            ss.Rows[3].HeaderCell.Value = "Req de Prod";
            ss.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);


            for (int i = 0; i < periodos; i++)
            {
                stock = Convert.ToInt32(tasa_ss * demandas[i]);
                req_prod = demandas[i] + stock - inv_ini;
                ss.Rows[0].Cells[i].Value = demandas[i];
                ss.Rows[1].Cells[i].Value = stock;
                ss.Rows[2].Cells[i].Value = inv_ini;
                ss.Rows[3].Cells[i].Value = req_prod;
                inv_ini = stock;
                lista_req_prod[i] = req_prod;
            }
            return lista_req_prod;
        }

        public static DataTable DGV_a_DT(DataGridView dg)
        {
            DataTable ExportDataTable = new DataTable();
            foreach (DataGridViewColumn col in dg.Columns)
            {
                ExportDataTable.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dg.Rows)
            {
                DataRow dRow = ExportDataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                ExportDataTable.Rows.Add(dRow);
            }
            return ExportDataTable;
        }

        public static void persecucion(DataGridView ss, DataGridView main, Label lbl_total, float c_contratacion, float c_despido, float c_hrs_n, float hrs_diarias, float tasa_ss, int inv_ini, int periodos, int[] demandas, int[] dias, float t_elab)
        {
            main.Rows.Clear();
            main.Columns.Clear();
            float c_total_estrategia = 0;
            int[] req_list  = new int[periodos];
            req_list = make_ss(ss, periodos, tasa_ss, demandas, inv_ini);

            //hacer tabla main
            for (int i = 0; i < periodos; i++)
            {
                main.Columns.Add("periodo_" + (i + 1).ToString(), "Periodo " + (i + 1).ToString());
            }

            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows[0].HeaderCell.Value = "Req de Prod";
            main.Rows[1].HeaderCell.Value = "Hrs de Prod Req";
            main.Rows[2].HeaderCell.Value = "Dias Habiles x Mes";
            main.Rows[3].HeaderCell.Value = "Hrs Disponibles";
            main.Rows[4].HeaderCell.Value = "Trab Req";
            main.Rows[5].HeaderCell.Value = "Trab Contratados";
            main.Rows[6].HeaderCell.Value = "C Contratar";
            main.Rows[7].HeaderCell.Value = "Trab Despedidos";
            main.Rows[8].HeaderCell.Value = "C Despedir";
            main.Rows[9].HeaderCell.Value = "Costo T Normal";
            main.Rows[10].HeaderCell.Value = "Costo Total";

            main.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            for (int i = 0; i < periodos; i++)
            {
                main.Rows[0].Cells[i].Value = req_list[i];
                main.Rows[1].Cells[i].Value = (float)req_list[i] * t_elab;
                main.Rows[2].Cells[i].Value = dias[i];
                main.Rows[3].Cells[i].Value = dias[i] * hrs_diarias;
                main.Rows[4].Cells[i].Value = Math.Round((float)main.Rows[1].Cells[i].Value / (float)main.Rows[3].Cells[i].Value);

                
                if(i == 0)
                {
                    //falta validar f lab inical
                    main.Rows[5].Cells[i].Value = 0;
                    main.Rows[7].Cells[i].Value = 0;

                    main.Rows[6].Cells[i].Value = 0;
                    main.Rows[8].Cells[i].Value = 0;
                }
                else
                {
                    if (int.Parse(main.Rows[4].Cells[i - 1].Value.ToString()) - int.Parse(main.Rows[4].Cells[i].Value.ToString()) > 0)
                    {
                        main.Rows[5].Cells[i].Value = 0;
                    }
                    else
                    {
                        main.Rows[5].Cells[i].Value = Math.Abs(int.Parse(main.Rows[4].Cells[i - 1].Value.ToString()) - int.Parse(main.Rows[4].Cells[i].Value.ToString()));
                    }

                    main.Rows[6].Cells[i].Value = float.Parse(main.Rows[5].Cells[i].Value.ToString()) * c_contratacion;

                    if (int.Parse(main.Rows[4].Cells[i - 1].Value.ToString()) - int.Parse(main.Rows[4].Cells[i].Value.ToString()) >= 1)
                    {
                        main.Rows[7].Cells[i].Value = Math.Abs(int.Parse(main.Rows[4].Cells[i - 1].Value.ToString()) - int.Parse(main.Rows[4].Cells[i].Value.ToString()));
                    }
                    else
                    {
                        main.Rows[7].Cells[i].Value = 0;
                    }
                    main.Rows[8].Cells[i].Value = float.Parse(main.Rows[7].Cells[i].Value.ToString()) * c_despido;
                }
                main.Rows[9].Cells[i].Value = float.Parse(main.Rows[1].Cells[i].Value.ToString()) * c_hrs_n;
                main.Rows[10].Cells[i].Value = float.Parse(main.Rows[6].Cells[i].Value.ToString()) + float.Parse(main.Rows[8].Cells[i].Value.ToString()) + float.Parse(main.Rows[9].Cells[i].Value.ToString());
                c_total_estrategia += float.Parse(main.Rows[10].Cells[i].Value.ToString());
            }

            lbl_total.Text ="Costo Total Estrategia: " + c_total_estrategia.ToString();

            DT_Persecucion.Rows.Clear();
            DT_Persecucion.Columns.Clear();

            DT_Persecucion = DGV_a_DT(main);
        }
        public static void fuerza_nivelada(DataGridView ss, DataGridView main, Label lbl_total, float c_hrs_n, float hrs_diarias, float tasa_ss, int inv_ini, int periodos, int[] demandas, int[] dias, float t_elab, float c_faltante, float h)
        {
            main.Rows.Clear();
            main.Columns.Clear();
            float c_total_estrategia = 0;
            int[] req_list = new int[periodos];
            req_list = make_ss(ss, periodos, tasa_ss, demandas, inv_ini);


            //hacer main
            //columnas
            for (int i = 0; i < periodos; i++)
            {
                main.Columns.Add("periodo_" + (i + 1).ToString(), "Periodo " + (i + 1).ToString());
            }
            //filas
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows[0].HeaderCell.Value = "Inv Ini";
            main.Rows[1].HeaderCell.Value = "Dias x Mes";
            main.Rows[2].HeaderCell.Value = "Hrs Disponibles";
            main.Rows[3].HeaderCell.Value = "Prod Real";
            main.Rows[4].HeaderCell.Value = "Pronostico";
            main.Rows[5].HeaderCell.Value = "Inv Final";
            main.Rows[6].HeaderCell.Value = "C Faltante";
            main.Rows[7].HeaderCell.Value = "SS";
            main.Rows[8].HeaderCell.Value = "Exceso Unds";
            main.Rows[9].HeaderCell.Value = "H";
            main.Rows[10].HeaderCell.Value = "C T Normal";
            main.Rows[11].HeaderCell.Value = "C Total";
            main.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            
            
            //calcular trabajadores promedio

            int No_Trab_Prom = (req_list.Sum() * (int)t_elab) / (dias.Sum() * (int)hrs_diarias);
            Console.WriteLine(No_Trab_Prom);
            
            for (int i = 0; i < periodos; i++)
            {
                main.Rows[0].Cells[i].Value = inv_ini;
                main.Rows[1].Cells[i].Value = dias[i];
                main.Rows[2].Cells[i].Value = dias[i] * 8 * No_Trab_Prom;
                main.Rows[3].Cells[i].Value = float.Parse(main.Rows[2].Cells[i].Value.ToString()) / t_elab;
                main.Rows[4].Cells[i].Value = demandas[i];
                main.Rows[5].Cells[i].Value = inv_ini + int.Parse(main.Rows[3].Cells[i].Value.ToString()) - int.Parse(main.Rows[4].Cells[i].Value.ToString());

                if (int.Parse(main.Rows[5].Cells[i].Value.ToString()) < 0)
                {
                    main.Rows[6].Cells[i].Value = Math.Abs(float.Parse(main.Rows[5].Cells[i].Value.ToString()) * c_faltante);
                }
                else
                {
                    main.Rows[6].Cells[i].Value = 0;
                }
                main.Rows[7].Cells[i].Value = int.Parse(ss.Rows[1].Cells[i].Value.ToString());
                if (int.Parse(main.Rows[5].Cells[i].Value.ToString()) - int.Parse(main.Rows[7].Cells[i].Value.ToString()) > 0)
                {
                    main.Rows[8].Cells[i].Value = int.Parse(main.Rows[5].Cells[i].Value.ToString()) - int.Parse(main.Rows[7].Cells[i].Value.ToString());
                }
                else
                {
                    main.Rows[8].Cells[i].Value = 0;
                }
                main.Rows[9].Cells[i].Value = Math.Round(int.Parse(main.Rows[8].Cells[i].Value.ToString()) * h);
                main.Rows[10].Cells[i].Value = float.Parse(main.Rows[2].Cells[i].Value.ToString()) * c_hrs_n;
                main.Rows[11].Cells[i].Value = float.Parse(main.Rows[6].Cells[i].Value.ToString()) + float.Parse(main.Rows[9].Cells[i].Value.ToString()) + float.Parse(main.Rows[10].Cells[i].Value.ToString());
                
                c_total_estrategia += float.Parse(main.Rows[11].Cells[i].Value.ToString());

                inv_ini = int.Parse(main.Rows[5].Cells[i].Value.ToString());
            }
            lbl_total.Text = "Costo Total Estrategia: " + c_total_estrategia.ToString();

            DT_F_Nivelada.Rows.Clear();
            DT_F_Nivelada.Columns.Clear();

            DT_F_Nivelada = DGV_a_DT(main);
        }
        public static void outsourcing(DataGridView ss, DataGridView main, Label lbl_total, float c_hrs_n, float hrs_diarias, float tasa_ss, int inv_ini, int periodos, int[] demandas, int[] dias, float t_elab,float c_outsourcing)
        {
            main.Rows.Clear();
            main.Columns.Clear();
            float c_total_estrategia = 0;
            int[] req_list = new int[periodos];
            req_list = make_ss(ss, periodos, tasa_ss, demandas, inv_ini);

            //hacer tabla main
            for (int i = 0; i < periodos; i++)
            {
                main.Columns.Add("periodo_" + (i + 1).ToString(), "Periodo " + (i + 1).ToString());
            }

            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows.Add();
            main.Rows[0].HeaderCell.Value = "Req de Prod";
            main.Rows[1].HeaderCell.Value = "Dias Habiles";
            main.Rows[2].HeaderCell.Value = "Hrs Disponibles";
            main.Rows[3].HeaderCell.Value = "Prod Real";
            main.Rows[4].HeaderCell.Value = "Und SubContratadas";
            main.Rows[5].HeaderCell.Value = "C SubContratar";
            main.Rows[6].HeaderCell.Value = "C Hrs N";
            main.Rows[7].HeaderCell.Value = "C Total";

            main.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            //calcular trabajadores promedio
            int No_Trab_Prom = (req_list.Sum() * (int)t_elab) / (dias.Sum() * (int)hrs_diarias);
            Console.WriteLine(No_Trab_Prom);
            for (int i = 0; i < periodos; i++)
            {
                main.Rows[0].Cells[i].Value = req_list[i];
                main.Rows[1].Cells[i].Value = dias[i];
                main.Rows[2].Cells[i].Value = dias[i] * hrs_diarias * No_Trab_Prom;
                main.Rows[3].Cells[i].Value = float.Parse(main.Rows[2].Cells[i].Value.ToString()) / t_elab;
                main.Rows[4].Cells[i].Value = float.Parse(main.Rows[0].Cells[i].Value.ToString()) - float.Parse(main.Rows[3].Cells[i].Value.ToString());
                main.Rows[5].Cells[i].Value = float.Parse(main.Rows[4].Cells[i].Value.ToString()) * c_outsourcing;
                main.Rows[6].Cells[i].Value = float.Parse(main.Rows[2].Cells[i].Value.ToString()) * c_hrs_n;
                main.Rows[7].Cells[i].Value = float.Parse(main.Rows[5].Cells[i].Value.ToString()) + float.Parse(main.Rows[6].Cells[i].Value.ToString());
                c_total_estrategia += float.Parse(main.Rows[7].Cells[i].Value.ToString());
            }
            lbl_total.Text = "Costo Total Estrategia: " + c_total_estrategia.ToString();

            DT_OutSourcing.Rows.Clear();
            DT_OutSourcing.Columns.Clear();

            DT_OutSourcing = DGV_a_DT(main);
        }

        public static void totales_Estrategias(DataGridView ss, DataGridView main, Label lbl_total, float c_hrs_n, float hrs_diarias, float tasa_ss, int inv_ini, int periodos, int[] demandas, int[] dias, float t_elab, float c_outsourcing)
        {
            main.Rows.Clear();
            main.Columns.Clear();
            float c_total_estrategia = 0;
            int[] req_list = new int[periodos];
            req_list = make_ss(ss, periodos, tasa_ss, demandas, inv_ini);

            
        }


        private static void PrintValues(DataTable table, string label)
        {
            // Display the values in the supplied DataTable:
            Console.WriteLine(label);
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    Console.Write("\t " + row[col].ToString());
                }
                Console.WriteLine();
            }
        }

    }
}
