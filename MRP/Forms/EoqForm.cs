using MaterialSkin;
using System;
using System.Windows.Forms;

namespace MRP.Forms
{
    public partial class EoqForm : UserControl
    {
        public Panel panelCont;
        public EoqForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey900, Primary.Grey500, Accent.Indigo100, TextShade.WHITE);
            Console.WriteLine(F(0.99));
        }

        public EoqForm(Panel panel)
        {
            InitializeComponent();
            panelCont = panel;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey900, Primary.Grey500, Accent.Indigo100, TextShade.WHITE);
            solRichTextBox.Enabled = false;
            txtCostoUnitario.Text = "0.5";
            txtDemanda.Text = "35";
            txtMantenimiento.Text = "700";
            txtNivelServicio.Text = "98";
            txtPedido.Text = "50";
            txtStdev.Text = "5";
            numPlazo.Value = 3;
            txtDiasLaborales.Text = "250";

        }

        //metodo para sacar z con probabilidad
        static double F(double x)
        {
            var curve = new MathNet.Numerics.Distributions.Normal();
            var z_value = curve.InverseCumulativeDistribution(x);
            return (z_value);
        }

        private void EoqForm_Load(object sender, EventArgs e)
        {

        }

        private void btnModelP_Click(object sender, EventArgs e)
        {
            var prov = new InventoryPForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtCostoUnitario.Text) || string.IsNullOrEmpty(txtDemanda.Text) || string.IsNullOrEmpty(txtMantenimiento.Text) || string.IsNullOrEmpty(txtNivelServicio.Text)
                    || string.IsNullOrEmpty(txtPedido.Text) || string.IsNullOrEmpty(txtStdev.Text) || (numPlazo.Value < 0) || String.IsNullOrWhiteSpace(txtDiasLaborales.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtMantenimiento.Text == "0")
                {
                    MessageBox.Show("El costo de mantenimiento no debe ser de 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int eoq = calcModelQ(int.Parse(txtDemanda.Text), float.Parse(txtPedido.Text), int.Parse(txtDiasLaborales.Text), float.Parse(txtMantenimiento.Text));
                double zScore = F(double.Parse(txtNivelServicio.Text) / 100);
                int securityStock = calcSecurityStock(int.Parse(txtStdev.Text), zScore);
                int rop = calcRop(int.Parse(txtDemanda.Text), int.Parse(numPlazo.Value.ToString()), securityStock);
                double costoTotal = calcCosto(int.Parse(txtDemanda.Text), double.Parse(txtPedido.Text), double.Parse(txtMantenimiento.Text), eoq, double.Parse(txtCostoUnitario.Text));
                double tbo = (eoq / int.Parse(txtDemanda.Text));
                solRichTextBox.Text = $"Si se establece un sistema de administración de inventario de revisión continua se deben hacer pedidos de {eoq.ToString("N0")} unidades. Además se debe estar revisando continuamente las existencias del producto. " +
                                      $"Vigilando que cuando las existencias sean menores o iguales a {rop.ToString("N0")} unidades se realice un nuevo pedido. El inventario de seguridad con este sistema es de {securityStock.ToString("N0")} unidades. Tambien se deben realizar los pedidos cada {tbo.ToString("N0")} dias y tiene un costo de {costoTotal.ToString("C3")} unidades monetarias.";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Formato no validos", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private int calcModelQ(int demanda, float costoPedido, int diasLaborales, float costoMantenimiento)
        {
            return (int)Math.Ceiling(Math.Sqrt((2 * demanda * diasLaborales * costoPedido) / costoMantenimiento));
        }

        private int calcRop(int demanda, int plazo, int securityStock)
        {
            return ((plazo * demanda) + securityStock);
        }

        private int calcSecurityStock(int stdev, double zScore)
        {
            var stdevPeriodo = stdev * Math.Sqrt((double)numPlazo.Value);
            Console.WriteLine(stdev);
            Console.WriteLine(numPlazo.Value); ;
            return (int)Math.Ceiling(stdevPeriodo * zScore);
        }

        private double calcCosto(int demanda, double pedido, double mantenimiento, int eoq, double costo)
        {
            double costoOrdenamiento = (pedido * demanda * int.Parse(txtDiasLaborales.Text)) / eoq;
            double costoMantenimiento = (mantenimiento * eoq) / 2;
            double costoProd = demanda * int.Parse(txtDiasLaborales.Text) * costo;
            return (costoOrdenamiento + costoMantenimiento + costoProd);
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

        private void txtNivelServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);

        }

        private void txtStdev_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);
        }

        private void txtDiasLaborales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloNumeros(e);

        }
    }
}
