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

        private void valortxt_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;
            //Verificação do que foi digitado => Número ou Letra?
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;

            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true;//liberar a vírgula
                if (e.KeyCode == Keys.Enter) verificarNumero = true; //liberar a tecla enter
                if (e.KeyCode == Keys.Back) verificarNumero = true; //liberar a tecla back
                int qtdVirgula = valortxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valortxt.Text = valortxt.Text.Remove(valortxt.Text.Length - 1);
            }
        }

        private void descontotxt_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;
            //Verificação do que foi digitado => Número ou Letra?
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;

            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true;//liberar a vírgula
                if (e.KeyCode == Keys.Enter) verificarNumero = true; //liberar a tecla enter
                if (e.KeyCode == Keys.Back) verificarNumero = true; //liberar a tecla back
                int qtdVirgula = descontotxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                descontotxt.Text = descontotxt.Text.Remove(descontotxt.Text.Length - 1);
            }
        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            valortxt.Clear();
            resultadotxt.Clear();
            descontotxt.Clear();
            descontotxt.Visible = false;
            percentuallb.Visible = false;
        }
    }
}