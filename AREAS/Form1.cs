using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AREAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            calcular.WebServiceSoapClient ws = new calcular.WebServiceSoapClient();
            resultadoC.Text = ws.CUADRADO(Convert.ToInt32(lado.Text)).ToString();
            resultadot.Text = ws.TRIANGULO(Convert.ToInt32(Base.Text),Convert.ToInt32(Altura.Text)).ToString();
            resultadoR.Text = ws.CIRCULO(Convert.ToInt32(radio.Text)).ToString();
        }
    }
}
