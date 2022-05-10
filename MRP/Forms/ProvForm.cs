using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MRP.Beans;
using MRP.Calculos;

namespace MRP.Forms
{
    public partial class ProvForm : UserControl
    {
        public Panel panelCont;
        private List<Proveedor> proveedors = null;
        private int isNew = 0;
        private Boolean flag = true;
        private DataSet ds = null;
        ContextMenuStrip a = new ContextMenuStrip();

        public ProvForm(Panel panel)
        {
            InitializeComponent();
            panelCont = panel;
            proveedors = provData.ListProveedors;
            this.Load += new EventHandler(ProvForm_Load);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal200, Primary.Teal800, Primary.Teal400, Accent.LightBlue400, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            StockForm stock = new StockForm(panelCont);
            panelCont.Controls.Clear();
            stock.Dock = DockStyle.Fill;
            panelCont.Controls.Add(stock);
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            addProveedor prov = new addProveedor(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addProveedor prov = new addProveedor(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void ProvForm_Load(object sender, EventArgs e)
        {
            var bs = new BindingSource();
            bs.DataSource = provData.ListProveedors;
            dataGridView1.DataSource = bs;

            Image img = null;
            a.Items.Add("Editar", img, new System.EventHandler(ContextMenuClick));
            a.Items.Add("Eliminar", img, new System.EventHandler(ContextMenuClick));
            dataGridView1.ContextMenuStrip = a;

        }

        private void ContextMenuClick(Object sender, System.EventArgs e)
        {
            Proveedor currentObject = (Proveedor)dataGridView1.CurrentRow.DataBoundItem;
            switch (sender.ToString().Trim())
            {
                case "Editar":

                    addProveedor prov = new addProveedor(panelCont);
                    panelCont.Controls.Clear();
                    prov.setProveedor(currentObject);
                    prov.Dock = DockStyle.Fill;
                    panelCont.Controls.Add(prov);
                    break;
                case "Eliminar":

                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    provData.deleteProveedor(currentObject.IdProveedor);
                    break;
            }
        }

        private void populateForm(Boolean flag)
        {
            if (flag)
            {
                isNew++;
            }

            if (isNew <= 0)
            {
                provData.populateList();

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    a.Items.Add(string.Format("", currentMouseOverRow.ToString()));
                }
                a.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            var bs = new BindingSource();
            bs.DataSource = provData.ListProveedors;
            dataGridView1.DataSource = bs;
            DataTable dt = GetDataTableFromDGV(dataGridView1);

            DataView dv = dt.DefaultView;

            dv.RowFilter = string.Format("Convert(IdProveedor,'System.String') like '%{0}%' or Direccion like '%{0}%' or Telefono like '%{0}%' or Titulo like '%{0}%'", materialTextBox1.Text);
            dataGridView1.DataSource = dv.ToTable();

        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    Console.WriteLine(column.Name);
                    dt.Columns.Add(column.Name);

                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Proveedor currentObject = (Proveedor)dataGridView1.CurrentRow.DataBoundItem;
            listBox1.DataSource = mpData.getMpByProv(currentObject.IdProveedor);
        }
    }
}
