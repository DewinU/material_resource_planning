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
    public partial class StockForm : UserControl
    {
        public Panel panelCont;
        ContextMenuStrip a = new ContextMenuStrip();
        public StockForm(Panel panel)
        {
            InitializeComponent();
            panelCont = panel;
            this.Load += new EventHandler(StockForm_Load);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey900, Primary.Grey500, Accent.Indigo100, TextShade.WHITE);
        }
        public StockForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey900, Primary.Grey500, Accent.Indigo100, TextShade.WHITE);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addStock prov = new addStock(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            ProvForm prov = new ProvForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            addStock prov = new addStock(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            var bs = new BindingSource();
            bs.DataSource = mpData.MpLista;
            dataGridView1.DataSource = bs;

            Image img = null;
            a.Items.Add("Editar", img, new System.EventHandler(ContextMenuClick));
            a.Items.Add("Eliminar", img, new System.EventHandler(ContextMenuClick));
            dataGridView1.ContextMenuStrip = a;
        }

        private void ContextMenuClick(Object sender, System.EventArgs e)
        {
            MateriaPrima currentObject = (MateriaPrima)dataGridView1.CurrentRow.DataBoundItem;
            switch (sender.ToString().Trim())
            {
                case "Editar":

                    addStock prov = new addStock(panelCont);
                    panelCont.Controls.Clear();
                    prov.setMp(currentObject);
                    prov.Dock = DockStyle.Fill;
                    panelCont.Controls.Add(prov);
                    break;
                case "Eliminar":

                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    mpData.deleteMp(currentObject.IdMP);
                    break;
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
            bs.DataSource = mpData.mpList;
            dataGridView1.DataSource = bs;
            DataTable dt = GetDataTableFromDGV(dataGridView1);

            DataView dv = dt.DefaultView;

            dv.RowFilter = string.Format("Convert(IdMP,'System.String') like '%{0}%' or Nombre like '%{0}%' or Convert(Stock,'System.String') like '%{0}%' or Convert(TiempoEntrega,'System.String') like '%{0}%'", materialTextBox1.Text);
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

        private void materialButton3_Click(object sender, EventArgs e)
        {
            BOMForm prov = new BOMForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
