using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjercicioCondicionales2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Horastrabajadas, valorhora, salariobase, salud, incremento, salarioapagar;

            Horastrabajadas = double.Parse(txthorastrabajadas.Text);
            valorhora = double.Parse(txtvalorhoras.Text);

            salariobase = valorhora * Horastrabajadas;

            if (salariobase > 1000000)
            {
                salud = salariobase * 0.04;
                incremento = 0;
            }
            else
            {
                salud = 0;
                incremento = salariobase * 0.02;

            }
            salarioapagar = salariobase - salud + incremento;

            //sin decimales
            /*
            lblsalariopagar.Text = Convert.ToString(lblsalariopagar.Text);
            lblpagosalud.Text = Convert.ToString(lblpagosalud.Text);
            lblincremento.Text = Convert.ToString(lblincremento.Text);
            lblsalariopagar.Text = Convert.ToString(lblsalariopagar.Text);
            */
            //pa que me muestre con decimales hago esto
            Convert.ToString("$" + string.Format("{0:n0}", salariobase));
            Convert.ToString("$" + string.Format("{0:n0}", salud));
            Convert.ToString("$" + string.Format("{0:n0}", incremento));
            Convert.ToString("$" + string.Format("{0:n0}", salarioapagar));


            Gb1.Visible = true;

        }
    }
}
