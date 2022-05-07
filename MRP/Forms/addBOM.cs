using System;
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
    public partial class addBOM : UserControl
    {

        private Panel panelCont;
        ComboBox combo = null;
        public addBOM(Panel panel)
        {
            panelCont = panel;
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            volver();
        }

        private void volver()
        {
            BOMForm prov = new BOMForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBOM_Load(object sender, EventArgs e)
        {
            txtId.Text = BOMData.getLasId().ToString();
            loadComboBox();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey900, Primary.Grey500, Accent.Indigo100, TextShade.WHITE);
        }

        private void loadComboBox()
        {
            cmbProducto.DataSource = mpData.getIsProcuredMP(true);
            materialComboBox1.DataSource = mpData.getIsProcuredMP(false);
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;

        }

        private void getComboId()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        void dataGridView1_EditingControlShowing(object sender,
            DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
        }

        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["clmProducto"].Value.ToString()
                    .Equals(getCmbId(materialComboBox1.SelectedValue.ToString())))
                {
                    MessageBox.Show("Producto ya registrado");
                    return;

                }

            }

            dataGridView1.Rows.Add(getCmbId(materialComboBox1.SelectedValue.ToString()), 0);
        }

        private string getCmbId(string key)
        {

            MateriaPrima mp = mpData.findById(int.Parse(key.Substring(0, 1)));

            return mp.Nombre;
        }

        private bool AddBOM()
        {
            bool flag = true;
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor rellene los campos", "Error de igreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }
            else
            {
                BOM bom = new BOM();
                bom.IdBOM = BOMData.getLasId();
                bom.IdProducto = int.Parse(cmbProducto.SelectedValue.ToString().Substring(0, 1));
                bom.nombreBOM = txtNombre.Text;
                BOMData.BomList.Add(bom);
                flag = true;
            }

            return flag;
        }

        private bool AddDtBOM()
        {
            bool flag = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                BOMDetalle bom = new BOMDetalle();
                if (int.Parse(dataGridView1.Rows[i].Cells["txtCantidad"].Value.ToString()) == 0)
                {
                    MessageBox.Show("Por favor digite una cantida", "Error de igreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                }
                else
                {
                    bom.cantidad = int.Parse((dataGridView1.Rows[i].Cells["txtCantidad"].Value.ToString()));
                    bom.idBom = int.Parse(txtId.Text);
                    bom.idBomDetalle = BOMData.getLastIdDetail();
                    bom.idMp = mpData.getMpByName(dataGridView1.Rows[i].Cells["clmProducto"].Value.ToString()).IdMP;
                    BOMData.BdList.Add(bom);
                    flag = true;
                }


            }

            return flag;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Por favor ingrese un producto a la lista", "Error de igreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (AddBOM() & AddDtBOM())
            {
                AddBOM();
                AddDtBOM();
                volver();
            }

        }


    }
}
