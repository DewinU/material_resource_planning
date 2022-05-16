using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP.Calculos
{
    public class Estrategias_Plan_Agregado
    {
        public DataTable DT_Estrategias;

        public static DataTable DT_Persecucion = new DataTable();
        public static DataTable DT_F_Nivelada = new DataTable();
        public static DataTable DT_OutSourcing = new DataTable();
        public static DataTable DT_Total_Estrategias = new DataTable();
        public static float total_persecucion;
        public static float total_f_nivelada;
        public static float total_outs;

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
            main.DataSource = null;
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

            main.RowCount = 11;

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

            total_persecucion = c_total_estrategia;

            //PrintValues(DT_Persecucion, "aaaaa");
        }
        public static void fuerza_nivelada(DataGridView ss, DataGridView main, Label lbl_total, float c_faltante, float h, float c_hrs_n, float hrs_diarias, float tasa_ss, int inv_ini, int periodos, int[] demandas, int[] dias, float t_elab, int f_lab)
        {
            main.DataSource = null;
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
            main.RowCount = 12;

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
            
            
            //calcular mano de obra
            int fuerza_lab = 0;
            if (f_lab > 0)
            {
                fuerza_lab = f_lab;
            }
            else
            {
                fuerza_lab = (req_list.Sum() * (int)t_elab) / (dias.Sum() * (int)hrs_diarias);
                Console.WriteLine(fuerza_lab);
            }

            int No_Trab_Prom = (req_list.Sum() * (int)t_elab) / (dias.Sum() * (int)hrs_diarias);
            Console.WriteLine(No_Trab_Prom);
            
            
            for (int i = 0; i < periodos; i++)
            {
                main.Rows[0].Cells[i].Value = inv_ini;
                main.Rows[1].Cells[i].Value = dias[i];
                main.Rows[2].Cells[i].Value = dias[i] * 8 * fuerza_lab;
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

            total_f_nivelada = c_total_estrategia;

            //PrintValues(DT_F_Nivelada, "aaaaa");
        }
        public static void outsourcing(DataGridView ss, DataGridView main, Label lbl_total, float c_outsourcing, float c_hrs_n, float hrs_diarias, float tasa_ss, int inv_ini, int periodos, int[] demandas, int[] dias, float t_elab, int f_lab)
        {
            main.DataSource = null;
            main.Rows.Clear();
            main.Columns.Clear();
            float c_total_estrategia = 0;
            int[] req_list = new int[periodos];
            req_list = make_ss(ss, periodos, tasa_ss, demandas, inv_ini);
            int excedente = 0;


            //hacer tabla main
            for (int i = 0; i < periodos; i++)
            {
                main.Columns.Add("periodo_" + (i + 1).ToString(), "Periodo " + (i + 1).ToString());
            }

            main.RowCount = 8;
            main.Rows[0].HeaderCell.Value = "Req de Prod";
            main.Rows[1].HeaderCell.Value = "Dias Habiles";
            main.Rows[2].HeaderCell.Value = "Hrs Disponibles";
            main.Rows[3].HeaderCell.Value = "Prod Real";
            main.Rows[4].HeaderCell.Value = "Und SubContratadas";
            main.Rows[5].HeaderCell.Value = "C SubContratar";
            main.Rows[6].HeaderCell.Value = "C Hrs N";
            main.Rows[7].HeaderCell.Value = "C Total";

            main.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            //calcular mano de obra
            int mano_obra = 0;
            if (f_lab > 0)
            {
                mano_obra = f_lab;
            }
            else
            {
                mano_obra = (req_list.Sum() * (int)t_elab) / (dias.Sum() * (int)hrs_diarias);
                Console.WriteLine(mano_obra);
            }

            for (int i = 0; i < periodos; i++)
            {
                
                main.Rows[0].Cells[i].Value = req_list[i] - excedente;
                main.Rows[1].Cells[i].Value = dias[i];
                main.Rows[2].Cells[i].Value = dias[i] * hrs_diarias * mano_obra;
                main.Rows[3].Cells[i].Value = float.Parse(main.Rows[2].Cells[i].Value.ToString()) / t_elab;
                if (float.Parse(main.Rows[0].Cells[i].Value.ToString()) - float.Parse(main.Rows[3].Cells[i].Value.ToString()) < 0)
                {
                    main.Rows[4].Cells[i].Value = 0;
                }
                else
                {
                main.Rows[4].Cells[i].Value = float.Parse(main.Rows[0].Cells[i].Value.ToString()) - float.Parse(main.Rows[3].Cells[i].Value.ToString());
                }
                main.Rows[5].Cells[i].Value = float.Parse(main.Rows[4].Cells[i].Value.ToString()) * c_outsourcing;
                main.Rows[6].Cells[i].Value = float.Parse(main.Rows[2].Cells[i].Value.ToString()) * c_hrs_n;
                main.Rows[7].Cells[i].Value = float.Parse(main.Rows[5].Cells[i].Value.ToString()) + float.Parse(main.Rows[6].Cells[i].Value.ToString());
                c_total_estrategia += float.Parse(main.Rows[7].Cells[i].Value.ToString());

                if (int.Parse(main.Rows[3].Cells[i].Value.ToString()) - int.Parse(main.Rows[0].Cells[i].Value.ToString()) > 0)
                {
                    excedente = int.Parse(main.Rows[3].Cells[i].Value.ToString()) - int.Parse(main.Rows[0].Cells[i].Value.ToString());
            }
                else
                {
                    excedente = 0;
                }
            }
            lbl_total.Text = "Costo Total Estrategia: " + c_total_estrategia.ToString();

            DT_OutSourcing.Rows.Clear();
            DT_OutSourcing.Columns.Clear();

            DT_OutSourcing = DGV_a_DT(main);

            total_outs = c_total_estrategia;
            //PrintValues(DT_OutSourcing, "aaaaaaa");

        }

        public static void totales_Estrategias(DataGridView totales, DataGridView ss, DataGridView main, Label lbl_total, float h, float c_faltante, float c_outsourcing, float c_contratacion, float c_despido, float c_hrs_n, float hrs_diarias, float tasa_ss, int inv_ini, int periodos, int[] demandas, int[] dias, float t_elab, int f_lab)
        {
            main.DataSource = null;
            main.Rows.Clear();
            main.Columns.Clear();
            float c_total_estrategia = 0;
            int[] req_list = new int[periodos];
            req_list = make_ss(ss, periodos, tasa_ss, demandas, inv_ini);
            string nombre_estrat = "";

            DT_Total_Estrategias.Rows.Clear();
            DT_Total_Estrategias.Columns.Clear();

            persecucion(ss, main, lbl_total, c_contratacion, c_despido, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab);

            if (f_lab > 0)
            {
                fuerza_nivelada(ss, main, lbl_total, c_faltante, h, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, f_lab);
                outsourcing(ss, main, lbl_total, c_outsourcing, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, f_lab);
            }
            else
            {
                fuerza_nivelada(ss, main, lbl_total, c_faltante, h, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, 0);
                outsourcing(ss, main, lbl_total, c_outsourcing, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, 0);
            }

            main.Rows.Clear();
            main.Columns.Clear();

            DT_Total_Estrategias.Merge(DT_Persecucion);
            DT_Total_Estrategias.Merge(DT_F_Nivelada,true);
            DT_Total_Estrategias.Merge(DT_OutSourcing, true);
            PrintValues(DT_Total_Estrategias,"aaaaaa");

            main.DataSource = DT_Total_Estrategias;

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

            main.Rows[11].HeaderCell.Value = "Inv Ini";
            main.Rows[12].HeaderCell.Value = "Dias x Mes";
            main.Rows[13].HeaderCell.Value = "Hrs Disponibles";
            main.Rows[14].HeaderCell.Value = "Prod Real";
            main.Rows[15].HeaderCell.Value = "Pronostico";
            main.Rows[16].HeaderCell.Value = "Inv Final";
            main.Rows[17].HeaderCell.Value = "C Faltante";
            main.Rows[18].HeaderCell.Value = "SS";
            main.Rows[19].HeaderCell.Value = "Exceso Unds";
            main.Rows[20].HeaderCell.Value = "H";
            main.Rows[21].HeaderCell.Value = "C T Normal";
            main.Rows[22].HeaderCell.Value = "C Total";

            main.Rows[23].HeaderCell.Value = "Req de Prod";
            main.Rows[24].HeaderCell.Value = "Dias Habiles";
            main.Rows[25].HeaderCell.Value = "Hrs Disponibles";
            main.Rows[26].HeaderCell.Value = "Prod Real";
            main.Rows[27].HeaderCell.Value = "Und SubContratadas";
            main.Rows[28].HeaderCell.Value = "C SubContratar";
            main.Rows[29].HeaderCell.Value = "C Hrs N";
            main.Rows[30].HeaderCell.Value = "C Total";


            for (int i = 0; i < main.Rows.Count; i++)
            {
                if (i <= 10)
                {
                    main.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                else if (i >= 11 && i <= 22)
                {
                    main.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                    
                }
                else if (i >= 21 && i <= 30)
                {
                    main.Rows[i].DefaultCellStyle.BackColor = Color.BurlyWood;
                }

            }
            totales.Rows.Clear();
            totales.Columns.Clear();
            totales.ColumnCount = 2;
            totales.Columns[0].HeaderText = "Estrategia";
            totales.Columns[1].HeaderText = "Total";
            totales.RowCount = 3;
            totales.Rows[0].Cells[0].Value = "Persecucion";
            totales.Rows[1].Cells[0].Value = "Fuerza Nivelada";
            totales.Rows[2].Cells[0].Value = "OutSourcing";

            totales.Rows[0].DefaultCellStyle.BackColor = Color.GreenYellow;
            totales.Rows[1].DefaultCellStyle.BackColor = Color.Aqua;
            totales.Rows[2].DefaultCellStyle.BackColor = Color.BurlyWood;

            totales.Rows[0].Cells[1].Value = total_persecucion;
            totales.Rows[1].Cells[1].Value = total_f_nivelada;
            totales.Rows[2].Cells[1].Value = total_outs;

            float MinEstrategia = totales.Rows.Cast<DataGridViewRow>().Min(r => float.Parse(r.Cells[1].Value.ToString()));

            for (int i = 0; i < 3; i++)
            {
                if (MinEstrategia == float.Parse(totales.Rows[i].Cells[1].Value.ToString()))
                {
                    nombre_estrat = totales.Rows[i].Cells[0].Value.ToString();
                }
            }
            lbl_total.Text = "Mejor Estrategia: " + nombre_estrat.ToString() + " Costo Total Estrategia: " + MinEstrategia.ToString();
        }


        private static void PrintValues(DataTable table, string label)
        {
            int i = 0;

            // Display the values in the supplied DataTable:
            Console.WriteLine(label);
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    
                    Console.Write("\t " + row[col].ToString());
                    
                }
                Console.WriteLine();
                //esto era para separar los finales de cada tabla agregada
                if (i == 10 || i == 23 || i == 32)
                {
                    Console.Write("espacioooooooooooooooo");
                    Console.WriteLine();
                }
                i++;
                //aqui termina lo que le agregue
            }
        }

    }
}
