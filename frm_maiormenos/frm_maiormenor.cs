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
    public partial class frm_maiormenor : Form
    {
        public frm_maiormenor()
        {
            InitializeComponent();
        }

        double v1, v2, v3, maior, menor;

        private void bt_calc_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(tb_v1.Text);
            v2 = double.Parse(tb_v2.Text);
            v3 = double.Parse(tb_v3.Text);

            if (v1 > v2 && v1 > v3 && v2 > v3)
            {
                lbmaior.Text = v1.ToString();
                lbmenor.Text = v3.ToString();
            }
            else if (v1 > v2 && v1 > v3 && v2 < v3)
            {
                lbmaior.Text = v1.ToString();
                lbmenor.Text = v2.ToString();
            }
            else if (v2 > v1 && v2 > v3 && v3 > v1)
            {
                lbmaior.Text = v2.ToString();
                lbmenor.Text = v1.ToString();
            }
            else if (v2 > v1 && v2 > v3 && v3 < v1)
            {
                lbmaior.Text = v2.ToString();
                lbmenor.Text = v3.ToString();
            }
            else if (v3 > v1 && v3 > v2 && v2 > v1)
            {
                lbmaior.Text = v3.ToString();
                lbmenor.Text = v1.ToString();
            }
            else if (v3 > v1 && v3 > v2 && v2 < v1)
            {
                lbmaior.Text = v3.ToString();
                lbmenor.Text = v2.ToString();
            }
            else
            {
                MessageBox.Show("Insira números diferentes", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
    }
}
