using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class FormPizarra : Form
    {
        public FormPizarra()
        {
            InitializeComponent();
        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            string x = TextBoxX.Text;
            string y = TextBoxY.Text;

            int ladoX = Convert.ToInt32(x);
            int ladoY = Convert.ToInt32(y);

            Globo globo = new Globo();
            //instanciacion de objetos
            globo.X = ladoX;
            globo.Y = ladoY;

            HacerGlobo(globo.X,globo.Y);

        }

        private void HacerGlobo(int x, int y)
        {
            Graphics papel;
            papel = PictureBoxPizarra.CreateGraphics();
            Pen lapiz = new Pen(Color.DarkBlue);

            papel.DrawRectangle(lapiz, x, 30, y, 50);
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxX.Clear();
            TextBoxY.Clear();
            TextBoxX.Focus();
            PictureBoxPizarra.Image = null;
        }
    }
}
