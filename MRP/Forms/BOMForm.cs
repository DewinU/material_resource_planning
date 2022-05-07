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
    public partial class BOMForm : UserControl
    {
        private Panel panelCont;
        ContextMenuStrip a = new ContextMenuStrip();
        public BOMForm(Panel panel)
        {
            panelCont = panel;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey900, Primary.Grey500, Accent.Indigo100, TextShade.WHITE);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            ProvForm prov = new ProvForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            StockForm prov = new StockForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void BOMForm_Load(object sender, EventArgs e)
        {
            var bs = new BindingSource();
            bs.DataSource = BOMData.BomList;
            dataGridView2.DataSource = bs;


            Image img = null;

            a.Items.Add("Eliminar", img, new System.EventHandler(ContextMenuClick));
            dataGridView2.ContextMenuStrip = a;
        }

        private void ContextMenuClick(Object sender, System.EventArgs e)
        {
            BOM currentObject = (BOM)dataGridView2.CurrentRow.DataBoundItem;
            switch (sender.ToString().Trim())
            {

                case "Eliminar":


                    dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                    BOMData.deleteBom(currentObject.IdBOM);
                    break;
            }
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridView2.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    a.Items.Add(string.Format("", currentMouseOverRow.ToString()));
                }
                a.Show(dataGridView2, new Point(e.X, e.Y));
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            addBOM prov = new addBOM(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BOM currentObject = (BOM)dataGridView2.CurrentRow.DataBoundItem;
            listBox1.DataSource = BOMData.getMpByIDBOm(currentObject.IdBOM);
        }
    }
}
