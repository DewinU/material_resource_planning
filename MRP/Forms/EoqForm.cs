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
    public partial class EoqForm : UserControl
    {
        public EoqForm()
        {
            InitializeComponent();

            Console.WriteLine(F(0.99));
        }

        //metodo para sacar z con probabilidad
        static double F(double x)
        {
            var curve = new MathNet.Numerics.Distributions.Normal();
            var z_value = curve.InverseCumulativeDistribution(x);
            return (z_value);
        }
    }
}
