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
    public partial class FormExemploComboBox : Form
    {
        public FormExemploComboBox()
        {
            InitializeComponent();
            descontotxt.Visible = false;
            percentuallb.Visible = false;
        }

        private void FormExemploComboBox_Load(object sender, EventArgs e)
        {

        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {
            int tipoCliente = clientecb.SelectedIndex;
            double valorCompra = Convert.ToDouble(valortxt.Text);
            double valorComDesconto = 0;
            switch (tipoCliente)
            {
                case 0://Cliente Diamante: 25%
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.25;
                        resultadotxt.Text = valorComDesconto.ToString("C2");
                        break;
                    }//fim case 0
                case 1://Cliente Ouro: 20%
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.20;
                        resultadotxt.Text = valorComDesconto.ToString("C2");
                        break;
                    }//fim case 1
                case 2://Cliente Ouro: 20%
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.15;
                        resultadotxt.Text = valorComDesconto.ToString("C2");
                        break;
                    }//fim case 1
                case 3://Cliente Ouro: 20%
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.10;
                        resultadotxt.Text = valorComDesconto.ToString("C2");
                        break;
                    }//fim case 1
                case 4://Cliente Ouro: 20%
                    {
                        
                        double desconto = Convert.ToDouble(descontotxt.Text)/100;
                        valorComDesconto = valorCompra - valorCompra * desconto;
                        resultadotxt.Text = valorComDesconto.ToString("C2");
                        

                        break;
                    }//fim case 1
                default:
                    {
                        MessageBox.Show("SELECIONE UM CLIENTE!", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }//fim da estrutura switch
            }
        }

        private void descontotxt_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void clientecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCliente = clientecb.SelectedIndex;
            if (tipoCliente == 4)
            {
                descontotxt.Visible = true; //para ficar visível
                percentuallb.Visible = true;//para ficar visível
            }
        }
    }
}