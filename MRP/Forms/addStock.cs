﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MRP.Beans;
using MRP.Calculos;

namespace MRP.Forms
{
    public partial class addStock : UserControl
    {
        private Panel panelCont;
        private bool flag = false;
        private MateriaPrima mp;
        public addStock(Panel panel)
        {
            this.panelCont = panel;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey400, Primary.BlueGrey400, Primary.Teal400, Accent.LightBlue400, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            volver();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (!validateCampos())
            {
                if (flag)
                {
                    editMp();
                }
                else
                {
                    newMp();
                }

                volver();
            }
            else
            {
                MessageBox.Show("Por favor rellene todos los campos", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void newMp()
        {
            MateriaPrima mp = new MateriaPrima();
            mp.IdMP = mpData.getLastId();
            mp.IdProv = txtProv.SelectedIndex + 1;
            mp.Nombre = txtNombre.Text;
            mp.UdM = txtUdm.Text;
            mp.MinStock = Int32.Parse(txtMinStock.Text);
            mp.PrecioCompra = double.Parse(txtPrecioCompra.Text);
            mp.TiempoEntrega = int.Parse(txtTiempoEntrega.Text);
            mp.Stock = int.Parse(txtStock.Text);
            mp.isProcured = txtisProcured.Checked;
            mp.costoMantenimiento = double.Parse(txtCostoMantenimiento.Text);
            mp.costoEnvio = double.Parse(txtCostoEnvio.Text);
            mp.tasaMantenimiento = double.Parse(txtTasaMantenimiento.Text);

            mpData.newMateria(mp);


        }

        private void addStock_Load(object sender, EventArgs e)
        {
            txtID.Text = mpData.getLastId().ToString();

            txtProv.DataSource = provData.GetProveedorsNames();

        }

        private void txtisProcured_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void volver()
        {
            StockForm prov = new StockForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        public void setMp(MateriaPrima mp)
        {
            txtID.Text = mp.IdMP.ToString();
            txtProv.SelectedIndex = (int)(mp.IdProv - 1);
            txtNombre.Text = mp.Nombre;
            txtUdm.Text = mp.UdM;
            txtMinStock.Text = mp.MinStock.ToString();
            txtPrecioCompra.Text = mp.PrecioCompra.ToString();
            txtTiempoEntrega.Text = mp.TiempoEntrega.ToString();
            txtStock.Text = mp.Stock.ToString();
            txtisProcured.Checked = mp.isProcured;
            txtCostoMantenimiento.Text = mp.costoMantenimiento.ToString();
            txtCostoEnvio.Text = mp.costoEnvio.ToString();
            txtTasaMantenimiento.Text = mp.tasaMantenimiento.ToString();

            flag = true;
        }

        private void editMp()
        {
            mpData.editMp(int.Parse(txtID.Text), txtNombre.Text, txtUdm.Text, int.Parse(txtMinStock.Text), double.Parse(txtPrecioCompra.Text), int.Parse(txtStock.Text),
                int.Parse(txtTiempoEntrega.Text), txtisProcured.Checked, double.Parse(txtCostoMantenimiento.Text), double.Parse(txtCostoEnvio.Text), double.Parse(txtTasaMantenimiento.Text));
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validateCampos()
        {
            bool isNullOrWhiteSpace = String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtStock.Text) || String.IsNullOrWhiteSpace(txtUdm.Text) || String.IsNullOrWhiteSpace(txtMinStock.Text)
                        || String.IsNullOrWhiteSpace(txtPrecioCompra.Text) || String.IsNullOrWhiteSpace(txtTiempoEntrega.Text) || String.IsNullOrWhiteSpace(txtCostoEnvio.Text)
                        || String.IsNullOrWhiteSpace(txtCostoMantenimiento.Text) || String.IsNullOrWhiteSpace(txtTasaMantenimiento.Text);

            return isNullOrWhiteSpace;
        }
    }
}
