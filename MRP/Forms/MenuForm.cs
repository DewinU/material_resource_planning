using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP.Forms
{

    public partial class MenuForm : Form
    {
        static string currentForm;
        public int idPanel = 0;
        private static MenuForm obj;

        public MenuForm()
        {
            InitializeComponent();
        }

        public MenuForm(int id)
        {
            InitializeComponent();
            setMainFrame(id);
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btnVolver, "Volver al Menu Principal");

            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(btnGestion, "Gestion De Inventario");

            ToolTip toolTip3 = new ToolTip();
            toolTip3.SetToolTip(btnEOQ, "EOQ");

            ToolTip toolTip4 = new ToolTip();
            toolTip4.SetToolTip(btnPlan, "Planeacion Estrategica");

            ToolTip toolTip5 = new ToolTip();
            toolTip5.SetToolTip(btnModelosP, "Modelos de Pedidos");

            ToolTip toolTip6 = new ToolTip();
            toolTip6.SetToolTip(btnMRP, "MRP");



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new StockForm(panel1));

        }

        private void btnEOQ_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new EoqForm(panel1));
        }

        private void ChangeUserControl(UserControl form)
        {

            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            currentForm = form.Name;
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new PlanForm());
        }

        private void btnMRP_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new ModelosP());
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new MRPForm());
        }

        private void setMainFrame(int id)
        {
            switch (id)
            {
                case 1:
                    ChangeUserControl(new StockForm(panel1));
                    break;
                case 2:
                    ChangeUserControl(new EoqForm(panel1));
                    break;
                case 3:
                    ChangeUserControl(new PlanForm());
                    break;
                case 4:
                    ChangeUserControl(new ModelosP());
                    break;
                case 5:
                    ChangeUserControl(new MRPForm());
                    break;
                default:
                    return;


            }
        }

        public static MenuForm Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new MenuForm();
                }

                return obj;
            }
        }

        public Panel pnlCointaner
        {
            get { return panel1; }
        }


    }
}
