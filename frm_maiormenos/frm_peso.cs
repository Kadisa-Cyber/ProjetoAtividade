using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_maiormenos
{
    public partial class frm_peso : Form
    {
        public frm_peso()
        {
            InitializeComponent();
        }

        double pesoP, pesoT;

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPeso.Text) == false)
            {

                pesoT = double.Parse(txtPeso.Text);

                if (radJupiter.Checked == true)
                {
                    pesoP = pesoT * 2.64;
                    MessageBox.Show($"Seu peso em Júpiter é {Math.Round(pesoP, 0)}kg");
                }
                else if (radMercurio.Checked == true)
                {
                    pesoP = pesoT * 0.37;
                    MessageBox.Show($"Seu peso em Mercúrio é {Math.Round(pesoP, 0)}kg");
                }
                else if (radVenus.Checked == true)
                {
                    pesoP = pesoT * 0.88;
                    MessageBox.Show($"Seu peso em Venus é {Math.Round(pesoP, 0)}kg");
                }
                else if (radMarte.Checked == true)
                {
                    pesoP = pesoT * 0.38;
                    MessageBox.Show($"Seu peso em Marte é {Math.Round(pesoP, 0)}kg");
                }
                else if (radSaturno.Checked == true)
                {
                    pesoP = pesoT * 1.15;
                    MessageBox.Show($"Seu peso em Saturno é {Math.Round(pesoP, 0)}kg");
                }
                else if (radUrano.Checked == true)
                {
                    pesoP = pesoT * 1.17;
                    MessageBox.Show($"Seu peso em Urano é {Math.Round(pesoP, 0)}kg");
                }
            }
            else
            {
                MessageBox.Show("Digite um valor!");
            }
        }
    }
}
