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
    public partial class MRPForm : UserControl
    {
        public float costo_producto;
        public float tasa_mantenimiento;
        public float costo_pedir;
        public int periodos;
        public int[] demanda_total;

        public MRPForm()
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
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }



        private void calcBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < periodos; i++)
            {
                demanda_total[i] = int.Parse(demandaTable.Rows[0].Cells[i].Value.ToString());
            }
            //costo_producto = float.Parse(costoProducto.Text);
            //tasa_mantenimiento = float.Parse(tasaMantenimiento.Text);
            //costo_pedir = float.Parse(costoPedir.Text);
            //Models.l4l(modeloTable, 47, 8, demanda_total);
            //Models.makeTable(410, modeloTable, 10, float.Parse(0.5.ToString()), 47, 8, demanda_total);
            //Models.ctm(modeloTable, 10, float.Parse(0.5.ToString()), 47, 8, demanda_total);
            Models.cum(modeloTable, 10, float.Parse(0.5.ToString()), 47, 8, demanda_total);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
