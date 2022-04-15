using MRP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP
{
    public partial class MRPMain : Form
    {
        public Boolean isVolver = false;
        public bool isMain = false;

        public MRPMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Hide();
            MenuForm menu = new MenuForm(1);
            menu.ShowDialog();
            Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            MenuForm menu = new MenuForm(2);
            menu.ShowDialog();
            Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            MenuForm menu = new MenuForm(3);
            menu.ShowDialog();
            Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Hide();
            MenuForm menu = new MenuForm(4);
            menu.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            MenuForm menu = new MenuForm(5);
            menu.ShowDialog();
            Show();
        }


    }
}
