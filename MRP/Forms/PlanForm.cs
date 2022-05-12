using MRP.Calculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP.Forms
{
    public partial class PlanForm : UserControl
    {
        public PlanForm()
        {
            InitializeComponent();
        }
        public int periodos = 0;
        public float costo;
        public float H;
        public float c_faltante;
        public float c_outsourcing;
        public float c_contratar;
        public float c_despido;
        public float c_hrs_n;
        public int f_lab;
        public float tasa_ss;
        public int inv_ini;
        public int hrs_diarias;
        public float t_elab;

        public int[] demandas, dias;


        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(TXT_Periodos.Text) || string.IsNullOrWhiteSpace(TXT_Periodos.Text))
            {
                MessageBox.Show("Campo Vacio, intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DGV_Demanda.Rows.Clear();
                DGV_Demanda.Columns.Clear();
                periodos = int.Parse(TXT_Periodos.Text);
                //DGV_Demanda.ColumnCount = periodos;


                for (int i = 0; i < periodos; i++)
                {
                    /*
                    DGV_Demanda.Columns[i].Name = "Periodo " + (i + 1).ToString();
                    Console.WriteLine(DGV_Demanda.Columns[i].Name);
                    */

                    DGV_Demanda.Columns.Add("periodo_" + (i + 1).ToString(), "Periodo " + (i + 1).ToString());
                    Console.WriteLine(DGV_Demanda.Columns[i].Name);

                }
                DGV_Demanda.Rows.Add();
                DGV_Demanda.Rows.Add();
                DGV_Demanda.Rows[0].HeaderCell.Value = "Demanda";
                DGV_Demanda.Rows[1].HeaderCell.Value = "Dias Laborados";
                DGV_Demanda.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                demandas = new int[periodos];
                dias = new int[periodos];
            }
        }

        private void CBO_Estrategias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(CBO_Estrategias.SelectedIndex);

            switch (CBO_Estrategias.SelectedIndex)
            {
                case 0:
                    TXT_C_Faltante.Enabled = false;
                    TXT_Outs.Enabled = false;
                    TXT_H.Enabled = false;
                    break;  
                case 1:
                    TXT_Contratar.Enabled = false;
                    TXT_Despedir.Enabled = false;
                    break;
                case 2:
                    TXT_C_Faltante.Enabled = false;
                    TXT_Outs.Enabled = false;
                    TXT_H.Enabled = false;
                    TXT_Contratar.Enabled = false;
                    TXT_Despedir.Enabled = false;
                    break;
                default:
                    TXT_C_Faltante.Enabled = true;
                    TXT_Outs.Enabled = true;
                    TXT_H.Enabled = true;
                    TXT_Contratar.Enabled = true;
                    TXT_Despedir.Enabled = true;
                    break;
            }
        }

        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Limpiar todos los cuadros de texto?", "Advertencia",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                TXT_Contratar.Text = "";
                TXT_Costo.Text = "";
                TXT_C_Hr_N.Text = "";
                TXT_Despedir.Text = "";
                TXT_C_Faltante.Text = "";
                TXT_F_Lab.Text = "";
                TXT_H.Text = "";
                TXT_Hrs_Lab.Text = "";
                TXT_Inv_Ini.Text = "";
                TXT_Outs.Text = "";
                TXT_tasa_SS.Text = "";
                TXT_T_Elab.Text = "";
                DGV_Demanda.Columns.Clear();
                DGV_Demanda.Rows.Clear();
                DGV_SS.Columns.Clear();
                DGV_SS.Rows.Clear();
                DGV_Plan_Agregado.Columns.Clear();
                DGV_Plan_Agregado.Rows.Clear();
            }
        }

        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            /*
            var result = MessageBox.Show("No posee Fuerza Laboral Estandar? Se asumira la Fuerza laboral calculada en el primer mes como Inical 
            y para la estrategia de Fuerza Nivelada, Se hara promedio de trabajadores durante los meses. ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            { 
                
            }
            else
            {
                return;
            }
            */

            c_contratar = float.Parse(TXT_Contratar.Text);
            costo = float.Parse(TXT_Costo.Text);
            c_hrs_n = float.Parse(TXT_C_Hr_N.Text);
            c_despido = float.Parse(TXT_Despedir.Text);
            c_faltante = float.Parse(TXT_C_Faltante.Text);
            f_lab = int.Parse(TXT_F_Lab.Text);
            H = float.Parse(TXT_H.Text);
            hrs_diarias = int.Parse(TXT_Hrs_Lab.Text);
            inv_ini = int.Parse(TXT_Inv_Ini.Text);
            c_outsourcing = float.Parse(TXT_Outs.Text);
            tasa_ss = float.Parse(TXT_tasa_SS.Text);
            t_elab = float.Parse(TXT_T_Elab.Text);


            for (int i = 0; i < periodos; i++)
            {
                demandas[i] = int.Parse(DGV_Demanda.Rows[0].Cells[i].Value.ToString());
                dias[i] = int.Parse(DGV_Demanda.Rows[1].Cells[i].Value.ToString());
            }


            switch (CBO_Estrategias.SelectedIndex)
            {
                case 0:
                    Estrategias_Plan_Agregado.persecucion(DGV_SS, DGV_Plan_Agregado, LBL_Total, c_contratar, c_despido, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab);
                    break;
                case 1:
                    Estrategias_Plan_Agregado.fuerza_nivelada(DGV_SS, DGV_Plan_Agregado, LBL_Total, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, c_faltante, H);
                    break;
                case 2:
                    Estrategias_Plan_Agregado.outsourcing(DGV_SS, DGV_Plan_Agregado, LBL_Total, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, c_outsourcing);
                    break;
                case 3:

                    break;
            }
        }
    }
}
