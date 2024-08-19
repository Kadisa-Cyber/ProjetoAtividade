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
    public partial class frm_placar : Form
    {
        public frm_placar()
        {
            InitializeComponent();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bt_calc_Click(object sender, EventArgs e)
        {
            int v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12;

            bool verdadeiro1 = int.TryParse(tx_1.Text, out v1);
            bool verdadeiro2 = int.TryParse(tx_2.Text, out v2);
            bool verdadeiro3 = int.TryParse(tx_3.Text, out v3);
            bool verdadeiro4 = int.TryParse(tx_4.Text, out v4);
            bool verdadeiro5 = int.TryParse(tx_5.Text, out v5);
            bool verdadeiro6 = int.TryParse(tx_6.Text, out v6);
            bool verdadeiro7 = int.TryParse(tx_7.Text, out v7);
            bool verdadeiro8 = int.TryParse(tx_8.Text, out v8);
            bool verdadeiro9 = int.TryParse(tx9.Text, out v9);
            bool verdadeiro10 = int.TryParse(tx10.Text, out v10);
            bool verdadeiro11 = int.TryParse(tx11.Text, out v11);
            bool verdadeiro12 = int.TryParse(tx12.Text, out v12);

            if( verdadeiro1 && verdadeiro2 && verdadeiro3 && verdadeiro4 && verdadeiro5 && verdadeiro6 &&
                verdadeiro7 && verdadeiro8 && verdadeiro9 &&verdadeiro10 && verdadeiro11 && verdadeiro12)
                {
                v1 = int.Parse(tx_1.Text);
                v2 = int.Parse(tx_2.Text);
                v3 = int.Parse(tx_3.Text);
                v4 = int.Parse(tx_4.Text);
                v5 = int.Parse(tx_5.Text);
                v6 = int.Parse(tx_6.Text);
                v7 = int.Parse(tx_7.Text);
                v8 = int.Parse(tx_8.Text);
                v9 = int.Parse(tx9.Text);
                v10 = int.Parse(tx10.Text);
                v11 = int.Parse(tx11.Text);
                v12 = int.Parse(tx12.Text);

                if (v1 > v7)
                {
                    r1.Text = t1.Text;
                }
                else if (v1 < v7)
                {
                    r1.Text = t7.Text;
                }
                else
                {
                    r1.Text = "Empate";
                }

                if (v2 > v8)
                {
                    r2.Text = t2.Text;
                }
                else if (v2 < v8)
                {
                    r2.Text = t8.Text;
                }
                else
                {
                    r2.Text = "Empate";
                }

                if (v3 > v9)
                {
                    r3.Text = t3.Text;
                }
                else if (v3 < v9)
                {
                    r3.Text = t9.Text;
                }
                else
                {
                    r3.Text = "Empate";
                }

                if (v4 > v10)
                {
                    r4.Text = t4.Text;
                }
                else if (v4 < v10)
                {
                    r4.Text = t10.Text;
                }
                else
                {
                    r4.Text = "Empate";
                }

                if (v5 > v11)
                {
                    r5.Text = t5.Text;
                }
                else if (v5 < v11)
                {
                    r5.Text = t11.Text;
                }
                else
                {
                    r5.Text = "Empate";
                }

                if (v6 > v12)
                {
                    r6.Text = t6.Text;
                }
                else if (v6 < v12)
                {
                    r6.Text = t12.Text;
                }
                else
                {
                    r6.Text = "Empate";
                }
            }
            else
            {
                MessageBox.Show("ERRO");
            }
        }

        private void tx_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
