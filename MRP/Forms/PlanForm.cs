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
            else if (int.Parse(TXT_Periodos.Text) == 0)
            {
                MessageBox.Show("Cantidad de periodos tiene que ser mayor que 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DGV_Demanda.Rows.Clear();
                DGV_Demanda.Columns.Clear();
                periodos = int.Parse(TXT_Periodos.Text);

                for (int i = 0; i < periodos; i++)
                {
                    DGV_Demanda.Columns.Add("periodo_" + (i + 1).ToString(), "Periodo " + (i + 1).ToString());
                    Console.WriteLine(DGV_Demanda.Columns[i].Name);
                }

                DGV_Demanda.RowCount = 2;
                DGV_Demanda.Rows[0].HeaderCell.Value = "Demanda";
                DGV_Demanda.Rows[1].HeaderCell.Value = "Dias Laborados";
                DGV_Demanda.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                demandas = new int[periodos];
                dias = new int[periodos];
            }
        }

        private void CBO_Estrategias_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Console.WriteLine(CBO_Estrategias.SelectedIndex);
            switch (CBO_Estrategias.SelectedIndex)
            {
                case 0:
                    Habilitar_TXT();
                    Limpiar_Cajas();
                    TXT_C_Faltante.Enabled = false;
                    TXT_Outs.Enabled = false;
                    TXT_H.Enabled = false;
                    TXT_C_Faltante.Text = "0";
                    TXT_Outs.Text = "0";
                    TXT_H.Text = "0";
                    break;  
                case 1:
                    Habilitar_TXT();
                    Limpiar_Cajas();
                    TXT_Contratar.Enabled = false;
                    TXT_Despedir.Enabled = false;
                    break;
                case 2:
                    Habilitar_TXT();
                    TXT_C_Faltante.Enabled = false;
                    TXT_H.Enabled = false;
                    TXT_Contratar.Enabled = false;
                    TXT_Despedir.Enabled = false;
                    break;
                default:
                    Habilitar_TXT();
                    break;
            }
            */
            
        }

        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Limpiar todos los cuadros de texto?", "Advertencia",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Limpiar_Cajas();
                DGV_Demanda.Columns.Clear();
                DGV_Demanda.Rows.Clear();
                DGV_SS.Columns.Clear();
                DGV_SS.Rows.Clear();
                DGV_Plan_Agregado.DataSource = null;
                DGV_Plan_Agregado.Columns.Clear();
                DGV_Plan_Agregado.Rows.Clear();
                DGV_Totales.Columns.Clear();
                DGV_Totales.Rows.Clear();
                LBL_Total.Text = "";
            }
        }

        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            float entero_prueba;
            //
            if (string.IsNullOrEmpty(TXT_C_Hr_N.Text)
                || string.IsNullOrEmpty(TXT_Hrs_Lab.Text)
                || string.IsNullOrEmpty(TXT_T_Elab.Text)
                || string.IsNullOrEmpty(TXT_Costo.Text)
                || string.IsNullOrEmpty(TXT_Inv_Ini.Text)
                || string.IsNullOrEmpty(TXT_tasa_SS.Text)
                || float.Parse(TXT_C_Hr_N.Text) == 0
                || float.Parse(TXT_Hrs_Lab.Text) == 0
                || float.Parse(TXT_T_Elab.Text) == 0
                || float.Parse(TXT_Costo.Text) == 0
               )
            {
                MessageBox.Show("Porfavor Ingrese los datos principales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //
            if (TXT_Costo.Text.Contains(" ")
                || TXT_H.Text.Contains(" ")
                || TXT_C_Faltante.Text.Contains(" ")
                || TXT_Outs.Text.Contains(" ")
                || TXT_Contratar.Text.Contains(" ")
                || TXT_Despedir.Text.Contains(" ")
                || TXT_C_Hr_N.Text.Contains(" ")
                || TXT_F_Lab.Text.Contains(" ")
                || TXT_Inv_Ini.Text.Contains(" ")
                || TXT_Hrs_Lab.Text.Contains(" ")
                || TXT_tasa_SS.Text.Contains(" ")
                || TXT_T_Elab.Text.Contains(" ")
               )
            {
                MessageBox.Show("No se permite espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  //Sale
            }

            //valida que halla valores numericos solamente
            if (!float.TryParse(TXT_Costo.Text, out entero_prueba)
                || !float.TryParse(TXT_C_Hr_N.Text, out entero_prueba)
                || !float.TryParse(TXT_F_Lab.Text, out entero_prueba)
                || !float.TryParse(TXT_Inv_Ini.Text, out entero_prueba)
                || !float.TryParse(TXT_Hrs_Lab.Text, out entero_prueba)
                || !float.TryParse(TXT_tasa_SS.Text, out entero_prueba)
                || !float.TryParse(TXT_T_Elab.Text, out entero_prueba)
               )
            {
                MessageBox.Show("Porfavor introduzca valores numericos solamente", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            //comprueba que no halla espacios en blanco en la tabla de demandas
            foreach (DataGridViewRow rw in this.DGV_Demanda.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Porfavor introduzca completamente los valores requeridos", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            if (DGV_Demanda.Rows.Count == 0)
            {
                MessageBox.Show("Porfavor introduzca los datos de la demanda", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            //comprueba que no halla caracteres no numericos en la tabla de demandas
            try
            {
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
            }
            catch (Exception exception)
            {

                MessageBox.Show("Formato de entradas no validos", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(exception);
                return;
            }


            switch (CBO_Estrategias.SelectedIndex)
            {
                case 0:
                    if (float.Parse(TXT_Contratar.Text) == 0
                        || float.Parse(TXT_Despedir.Text) == 0
                        || string.IsNullOrEmpty(TXT_Contratar.Text)
                        || string.IsNullOrEmpty(TXT_Despedir.Text)
                       )
                    {
                        MessageBox.Show("Porfavor introduzca los datos necesarios de la estrategia seleccionada", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (!float.TryParse(TXT_Contratar.Text, out entero_prueba)
                            || !float.TryParse(TXT_Despedir.Text, out entero_prueba))
                        {
                            MessageBox.Show("Porfavor introduzca valores numericos solamente", "Advertencia", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        DGV_Totales.Columns.Clear();
                        DGV_Totales.Rows.Clear();
                        Estrategias_Plan_Agregado.persecucion(DGV_SS, DGV_Plan_Agregado, LBL_Total, c_contratar, c_despido, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab);
                    }
                    break;

                case 1:
                    if (float.Parse(TXT_C_Faltante.Text) == 0
                        || float.Parse(TXT_H.Text) == 0
                        || string.IsNullOrEmpty(TXT_C_Faltante.Text)
                        || string.IsNullOrEmpty(TXT_H.Text)
                        )
                    {
                        MessageBox.Show("Porfavor introduzca los datos necesarios de la estrategia seleccionada", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    if (!float.TryParse(TXT_C_Faltante.Text, out entero_prueba)
                        || !float.TryParse(TXT_H.Text, out entero_prueba))
                    {
                        MessageBox.Show("Porfavor introduzca valores numericos solamente", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (int.Parse(TXT_F_Lab.Text) == 0
                       || string.IsNullOrEmpty(TXT_F_Lab.Text)
                       )
                    {
                        var result = MessageBox.Show(
                            "Desea continuar sin Fuerza Lab?, se realizara un promedio de empleados necesarios durante los periodos como fuerza laboral si es asi",
                            "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            DGV_Totales.Columns.Clear();
                            DGV_Totales.Rows.Clear();
                            Estrategias_Plan_Agregado.fuerza_nivelada(DGV_SS, DGV_Plan_Agregado, LBL_Total, c_faltante, H, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, 0);
                            
                        }else
                        {
                            return;
                        }
                    }
                    else
                    {
                        DGV_Totales.Columns.Clear();
                        DGV_Totales.Rows.Clear();
                        Estrategias_Plan_Agregado.fuerza_nivelada(DGV_SS, DGV_Plan_Agregado, LBL_Total, c_faltante, H, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, f_lab);
                    }
                    break;

                case 2:
                    if (float.Parse(TXT_Outs.Text) == 0
                        || string.IsNullOrEmpty(TXT_Outs.Text)
                        )
                    {
                        MessageBox.Show("Porfavor introduzca los datos necesarios de la estrategia seleccionada", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    if (!float.TryParse(TXT_Outs.Text, out entero_prueba))
                    {
                        MessageBox.Show("Porfavor introduzca valores numericos solamente", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (int.Parse(TXT_F_Lab.Text) == 0
                        || string.IsNullOrEmpty(TXT_F_Lab.Text))
                    {
                        var result = MessageBox.Show(
                            "Desea continuar sin Fuerza Lab?, se realizara un promedio de empleados necesarios durante los periodos como fuerza laboral si es asi",
                            "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            DGV_Totales.Columns.Clear();
                            DGV_Totales.Rows.Clear();
                            Estrategias_Plan_Agregado.outsourcing(DGV_SS, DGV_Plan_Agregado, LBL_Total, c_outsourcing, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, 0);

                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        DGV_Totales.Columns.Clear();
                        DGV_Totales.Rows.Clear();
                        Estrategias_Plan_Agregado.outsourcing(DGV_SS, DGV_Plan_Agregado, LBL_Total, c_outsourcing, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, f_lab);
                    }
                    break;

                case 3:
                    
                    if (float.Parse(TXT_H.Text) == 0
                        || float.Parse(TXT_C_Faltante.Text) == 0
                        || float.Parse(TXT_Outs.Text) == 0
                        || float.Parse(TXT_Contratar.Text) == 0
                        || float.Parse(TXT_Despedir.Text) == 0
                        || string.IsNullOrEmpty(TXT_H.Text)
                        || string.IsNullOrEmpty(TXT_C_Faltante.Text)
                        || string.IsNullOrEmpty(TXT_Outs.Text)
                        || string.IsNullOrEmpty(TXT_Contratar.Text)
                        || string.IsNullOrEmpty(TXT_Despedir.Text)
                       )
                    {
                        MessageBox.Show("Porfavor introduzca los datos necesarios de la estrategia seleccionada", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    if (!float.TryParse(TXT_H.Text, out entero_prueba)
                        || !float.TryParse(TXT_C_Faltante.Text, out entero_prueba)
                        || !float.TryParse(TXT_Outs.Text, out entero_prueba)
                        || !float.TryParse(TXT_Contratar.Text, out entero_prueba)
                        || !float.TryParse(TXT_Despedir.Text, out entero_prueba))
                    {
                        MessageBox.Show("Porfavor introduzca valores numericos solamente", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }


                    if (int.Parse(TXT_F_Lab.Text) == 0
                        || string.IsNullOrEmpty(TXT_F_Lab.Text)
                        )
                    {
                        var result = MessageBox.Show(
                            "Desea continuar sin Fuerza Lab?, se realizara un promedio de empleados necesarios durante los periodos como fuerza laboral si es asi",
                            "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {

                            Estrategias_Plan_Agregado.totales_Estrategias(DGV_Totales, DGV_SS, DGV_Plan_Agregado, LBL_Total, H, c_faltante, c_outsourcing, c_contratar, c_despido, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, 0);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        Estrategias_Plan_Agregado.totales_Estrategias(DGV_Totales, DGV_SS, DGV_Plan_Agregado, LBL_Total, H, c_faltante, c_outsourcing, c_contratar, c_despido, c_hrs_n, hrs_diarias, tasa_ss, inv_ini, periodos, demandas, dias, t_elab, f_lab);
                    }
                    break;
            }
        }

        private void Habilitar_TXT()
        {
            TXT_Contratar.Enabled = true;
            TXT_Costo.Enabled = true;
            TXT_C_Hr_N.Enabled = true;
            TXT_Despedir.Enabled = true;
            TXT_C_Faltante.Enabled = true;
            TXT_F_Lab.Enabled = true;
            TXT_H.Enabled = true;
            TXT_Hrs_Lab.Enabled = true;
            TXT_Inv_Ini.Enabled = true;
            TXT_Outs.Enabled = true;
            TXT_tasa_SS.Enabled = true;
            TXT_T_Elab.Enabled = true;
        }

        private void DGV_Plan_Agregado_SelectionChanged(object sender, EventArgs e)
        {
            this.DGV_Plan_Agregado.ClearSelection();
        }

        private void DGV_Totales_SelectionChanged(object sender, EventArgs e)
        {
            this.DGV_Totales.ClearSelection();
        }

        private void DGV_SS_SelectionChanged(object sender, EventArgs e)
        {
            this.DGV_SS.ClearSelection();
        }

        private void TXT_Periodos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);
        }

        private void Limpiar_Cajas()
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
            TXT_Periodos.Text = "";
        }
    }
}
