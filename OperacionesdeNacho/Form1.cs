using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sumaNachoOpera;
using RestaNachoOpera;
using MultiplicacionNachoOpera;
using DividirNachoOpera;

namespace OperacionesdeNacho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbSuma.Checked)
                {
                    long sumRtdo;
                    sumRtdo = sumaNachoOpera.Class1.Suma(long.Parse(txtnum1.Text), long.Parse(txtnum2.Text));
                    txtresultado.Text = sumRtdo.ToString();
                }
                if (rdbResta.Checked)
                {
                    long resRtdo;
                    resRtdo = RestaNachoOpera.Class1.resta(long.Parse(txtnum1.Text), long.Parse(txtnum2.Text));
                    txtresultado.Text = resRtdo.ToString();
                }
                if (rdbMultiplicar.Checked)
                {
                    double multRtdo;
                    multRtdo = MultiplicacionNachoOpera.Class1.multiplicacion(long.Parse(txtnum1.Text), long.Parse(txtnum2.Text));
                    txtresultado.Text = multRtdo.ToString();
                }
                if (rdbDividir.Checked)
                {
                    double DivRtdo;
                    DivRtdo = DividirNachoOpera.Class1.Dividir(long.Parse(txtnum1.Text), long.Parse(txtnum2.Text));
                    txtresultado.Text = DivRtdo.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
