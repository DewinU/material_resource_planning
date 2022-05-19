using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP.Forms
{
    public partial class InventoryPForm : UserControl
    {
        public Panel panelCont;
        public InventoryPForm()
        {
            InitializeComponent();
        }

        public InventoryPForm(Panel panel)
        {
            InitializeComponent();
            panelCont = panel;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey900, Primary.Grey500, Accent.Indigo100, TextShade.WHITE);
            txtDemanda.Text = "10";
            numPlazo.Value = 30;
            numRevision.Value = 14;
            txtStdev.Text = "3";
            txtInventario.Text = "150";
            txtNivelServicio.Text = "98";
        }
        static double F(double x)
        {
            var curve = new MathNet.Numerics.Distributions.Normal();
            var z_value = curve.InverseCumulativeDistribution(x);
            return (z_value);
        }

        private void InventoryPForm_Load(object sender, EventArgs e)
        {
            txtDemanda.Text = "10";
            numPlazo.Value = 30;
            numRevision.Value = 14;
            txtStdev.Text = "3";
            txtInventario.Text = "150";

        }

        private void btnModelQ_Click(object sender, EventArgs e)
        {
            var prov = new EoqForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCostoUnitario.Text) || string.IsNullOrEmpty(txtDemanda.Text) || string.IsNullOrEmpty(txtMantenimiento.Text) || string.IsNullOrEmpty(txtNivelServicio.Text)
                    || string.IsNullOrEmpty(txtPedido.Text) || string.IsNullOrEmpty(txtStdev.Text) || (numPlazo.Value < 0))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!checktxt(txtCostoUnitario) || !checktxt(txtDemanda) || !checktxt(txtMantenimiento) || !checktxt(txtPedido) || !checktxt(txtDiasLaborales) || !checktxt(txtStdev) || !checktxt(txtInventario))
            {
                MessageBox.Show("formatos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMantenimiento.Text == "0")
            {
                MessageBox.Show("El costo de mantenimiento no debe ser de 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtDemanda.Text.All(char.IsDigit))
            {
                MessageBox.Show("Demanda no puede ser en decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double zScore = F(double.Parse(txtNivelServicio.Text) / 100);
            int ss = calcSecurityStock(int.Parse(txtStdev.Text), zScore);
            int cantidad = calcModelP(int.Parse(txtDemanda.Text), int.Parse(numPlazo.Value.ToString()), int.Parse(numRevision.Value.ToString()), int.Parse(txtStdev.Text), int.Parse(txtInventario.Text), ss);
            double tbo = (cantidad / int.Parse(txtDemanda.Text));

            string costo = calcCosto(int.Parse(txtDemanda.Text), double.Parse(txtPedido.Text), double.Parse(txtMantenimiento.Text), cantidad, double.Parse(txtCostoUnitario.Text)).ToString("C3");
            solRichTextBox.Text = $"Si se establece un sistema de administración de inventario de periodos fijos se deben hacer pedidos de {cantidad.ToString("N0")} unidades." +
                $" El inventario de seguridad con este sistema es de {ss.ToString("N0")} unidades .Tambien se debe realizar los pedidos cada {int.Parse(numRevision.Value.ToString())} dias y tiene un costo de {costo} unidades monetarias.";


        }

        private int calcModelP(int demanda, int revisiones, int entrega, int stdev, int inventario, int ss)
        {
            int demandaVulnerable = demanda * (revisiones + entrega);
            Console.WriteLine(demandaVulnerable);
            return (int)demandaVulnerable + ss - inventario;
        }

        private int calcSecurityStock(int stdev, double zScore)
        {
            var stdevPeriodo = stdev * Math.Sqrt((int)numPlazo.Value + (int)numRevision.Value);
            Console.WriteLine(zScore);
            return (int)(stdevPeriodo * zScore);
        }

        private double calcCosto(int demanda, double pedido, double mantenimiento, int eoq, double costo)
        {
            double costoOrdenamiento = (pedido * demanda * int.Parse(txtDiasLaborales.Text)) / eoq;
            double costoMantenimiento = (mantenimiento * eoq) / 2;
            double costoProd = demanda * int.Parse(txtDiasLaborales.Text) * costo;
            return (costoOrdenamiento + costoMantenimiento + costoProd);
        }

        private void btnModelQ_Click_1(object sender, EventArgs e)
        {

            var prov = new EoqForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private bool checktxt(TextBox txt)
        {

            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(txt.Text), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;

        }

        private void txtNivelServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);
        }

        private void txtDemanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumerosEnteros(e);

        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);
        }

        private void txtMantenimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);

        }

        private void txtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);
        }

        private void txtStdev_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);
        }

        private void txtInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumerosEnteros(e);

        }

        private void txtDiasLaborales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);
        }
    }
}
