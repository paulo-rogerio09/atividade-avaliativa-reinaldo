using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemplo2.Formularios
{
    public partial class FormJuros : Form
    {
        public FormJuros()
        {
            InitializeComponent();
        }

        private void escolhacb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCalculo = escolhacb.SelectedIndex;
            switch (tipoCalculo)
            {
                case 0:
                    jurostxt.Visible = true;
                    montantetxt.Visible = true;
                    capitaltxt.Visible = true;
                    taxatxt.Visible = true;
                    tempotxt.Visible = true;
                    montantetxt.BackColor = Color.Green;
                    break;

                case 1:
                    jurostxt.Visible = true;
                    montantetxt.Visible = true;
                    capitaltxt.Visible = true;
                    taxatxt.Visible = true;
                    tempotxt.Visible = true;
                    capitaltxt.BackColor = Color.Green;

                    break;

                case 2:
                    jurostxt.Visible = true;
                    montantetxt.Visible = true;
                    capitaltxt.Visible = true;
                    taxatxt.Visible = true;
                    tempotxt.Visible = true;
                    taxatxt.BackColor = Color.Green;

                    break;

                case 3:
                    jurostxt.Visible = true;
                    montantetxt.Visible = true;
                    capitaltxt.Visible = true;
                    taxatxt.Visible = true;
                    tempotxt.Visible = true;
                    tempotxt.BackColor = Color.Green;

                    break;
            }
        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {
            int tipoCalculo = escolhacb.SelectedIndex;
            double resultado = 0, juros=0, c, i, t,m;

            switch (tipoCalculo)
            {
                case 0:
                     c = Convert.ToDouble(capitaltxt.Text);
                     i = Convert.ToDouble(taxatxt.Text)/100;
                     t = Convert.ToDouble(tempotxt.Text);
                    resultado = c * (1 + i * t);
                     montantetxt.Text = resultado.ToString("F2");
                    juros = resultado - c;
                    jurostxt.Text = juros.ToString("F2");
                    break;

                case 1:
                    m = Convert.ToDouble(capitaltxt.Text);
                    i = Convert.ToDouble(taxatxt.Text) / 100;
                    t = Convert.ToDouble(tempotxt.Text);
                    resultado = m/ (1 + i * t);
                    montantetxt.Text = resultado.ToString("F2");
                    juros = resultado - m;
                    jurostxt.Text = juros.ToString("F2");
                    break;
                case 2:
                    
                    break;
                case 3:

                    break;
            }
        }
    }
}
