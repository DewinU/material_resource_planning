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
    public partial class StockForm : UserControl
    {
        public Panel panelCont;
        public StockForm(Panel panel)
        {
            InitializeComponent();
            panelCont = panel;
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

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
             ProvForm prov = new ProvForm(panelCont);
            panelCont.Controls.Clear();
            prov.Dock = DockStyle.Fill;
            panelCont.Controls.Add(prov);


        }
    }
}
