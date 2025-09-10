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
    public partial class FormExemploRotulos : Form
    {
        public FormExemploRotulos()
        {
            InitializeComponent();
        }

        private void salarioatualtxt_Leave(object sender, EventArgs e)
        {
            if (salarioatualtxt.Text == "")
            {
                MessageBox.Show("voce nao preencheu tudo");

                salarioatualtxt.Select();
            }



            
        }

        private void reajustetxt_Leave(object sender, EventArgs e)
        {
            if(reajustetxt.Text == "")
            {
                MessageBox.Show("voce nao preencheu tudo");

                reajustetxt.Select();
            }




        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(salarioatualtxt.Text);
            double valor2 = Convert.ToDouble(reajustetxt.Text)/100;
            double total = valor1 * valor2;
            respostalb.Text = total.ToString("F2");

        }

        private void salarioatualtxt_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = salarioatualtxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                salarioatualtxt.Text = salarioatualtxt.Text.Remove(salarioatualtxt.Text.Length - 1);
            }
        }

        private void reajustetxt_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = reajustetxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reajustetxt.Text = reajustetxt.Text.Remove(reajustetxt.Text.Length - 1);
            }
        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            salarioatualtxt.Clear();
            reajustetxt.Clear();
            respostalb.Text="SALARIO REAJUSTADO";
        }

        private void salarioatualtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
