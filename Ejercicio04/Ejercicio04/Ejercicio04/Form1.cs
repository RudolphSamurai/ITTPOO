using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int centavosOriginales, dolaresEnteros = 0, centavosSobrantes = 0;
            centavosOriginales = int.Parse(textBox1.Text);
            DolaresYCentavos(centavosOriginales,out dolaresEnteros,out centavosSobrantes);
            DolaresYCentavosREF(ref centavosOriginales);
            dolaresLabel.Text = Convert.ToString(dolaresEnteros);
            centavosLabel.Text = Convert.ToString(centavosSobrantes);
            MessageBox.Show(""+centavosOriginales);
        }

        private void DolaresYCentavosREF(ref int centavosOriginales)
        {
            centavosOriginales *= 2;
           
        }

        private void DolaresYCentavos(int centavosOriginales, out int dolaresEnteros, out int centavosSobrantes)
        {
            dolaresEnteros = centavosOriginales / 100;
            centavosSobrantes = centavosOriginales % 100;
        }
    }
}
