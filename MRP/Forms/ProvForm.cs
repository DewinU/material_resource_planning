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

namespace MRP.Forms
{
    public partial class ProvForm : UserControl
    {
        public Panel panelCont;
        public ProvForm(Panel panel)
        {
            InitializeComponent();
            panelCont = panel;
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

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
