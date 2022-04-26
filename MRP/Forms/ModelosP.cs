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
    public partial class ModelosP : UserControl
    {
        public float costo_producto;
        public float tasa_mantenimiento;
        public float costo_pedir;
        public int periodos;
        public int[] demanda_total;

        public ModelosP()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            periodos = int.Parse(numericUpDown1.Text);
            demandaTable.Rows.Clear();
            demandaTable.Columns.Clear();
            for (int i = 0; i < periodos; i++)
            {
                demandaTable.Columns.Add("col" + (i + 1), "" + (i + 1));
            }
            demanda_total = new int[periodos];
            demandaTable.Rows.Add();
        }

        



        private void calcBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < periodos; i++)
            {
                demanda_total[i] = int.Parse(demandaTable.Rows[0].Cells[i].Value.ToString());
            }
            costo_producto = float.Parse(costoProducto.Text);
            tasa_mantenimiento = float.Parse(tasaMantenimiento.Text);
            costo_pedir = float.Parse(costoPedir.Text);

            
            switch (models.SelectedIndex)
            {
                case 0:
                    modeloTable.Rows.Clear();
                    Models.l4l(modeloTable, costo_pedir, periodos, demanda_total);
                    break;
                case 1:
                    modeloTable.Rows.Clear();
                    Models.eoq(modeloTable, costo_producto, tasa_mantenimiento, costo_pedir, periodos, demanda_total);
                    break;
                case 2:
                    modeloTable.Rows.Clear();
                    Models.ctm(modeloTable,costo_producto,tasa_mantenimiento,costo_pedir, periodos, demanda_total);
                    break;
                case 3:
                    modeloTable.Rows.Clear();
                    Models.cum(modeloTable,costo_producto,tasa_mantenimiento,costo_pedir, periodos, demanda_total);
                    break;
            }
            //
            //Models.makeTable(410, modeloTable, 10, float.Parse(0.5.ToString()), 47, 8, demanda_total);
            //Models.ctm(modeloTable, 10, float.Parse(0.5.ToString()), 47, 8, demanda_total);
            //Models.cum(modeloTable, 10, float.Parse(0.5.ToString()), 47, 8, demanda_total);
        }

        
    }
}
