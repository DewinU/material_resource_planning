using System;
using System.Windows.Forms;
using MaterialSkin;
using MRP.Beans;
using MRP.Calculos;

namespace MRP.Forms
{
    public partial class addProveedor : UserControl
    {
        public Panel panelCont;
        private Proveedor proveedor;
        private bool flag = false;


        public addProveedor(Panel panel)
        {
            InitializeComponent();

            panelCont = panel;


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey400, Primary.BlueGrey400, Primary.Teal400, Accent.LightBlue400, TextShade.WHITE);

        }

        private void materialMultiLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ProvForm prov = new ProvForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            if (!validateCampos())
            {
                if (flag)
                {
                    editProveedor();
                }
                else
                {
                    newProveedor();
                }

                volver();
            }
            else
            {
                MessageBox.Show("Por favor rellene todos los campos", "Error de igreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void addProveedor_Load(object sender, EventArgs e)
        {

            txtId.Text = provData.getLastId().ToString();
        }

        private void volver()
        {
            ProvForm prov = new ProvForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void newProveedor()
        {
            Proveedor proveedor = new Proveedor();

            proveedor.IdProveedor = provData.getLastId();
            proveedor.Titulo = txtNombre.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.Telefono = txtTelefono.Text;
            provData.newProveedor(proveedor);
        }

        public void setProveedor(Proveedor prov)
        {
            proveedor = prov;
            txtId.Text = prov.IdProveedor.ToString();
            txtTelefono.Text = prov.Telefono;
            txtDireccion.Text = prov.Direccion;
            txtNombre.Text = prov.Titulo;
            flag = true;
        }

        private void editProveedor()
        {
            provData.editProveedor(int.Parse(txtId.Text), txtNombre.Text, txtTelefono.Text, txtDireccion.Text);
        }

        private bool validateCampos()
        {
            bool isVal = String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text) ||
                         String.IsNullOrWhiteSpace(txtDireccion.Text);

            return isVal;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Validaciones.SoloLetras(e);
        }
    }
}
