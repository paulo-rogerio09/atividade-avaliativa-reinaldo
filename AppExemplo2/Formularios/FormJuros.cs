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
                    montantetxt.BackColor = Color.LightGreen;
                    jurostxt.BackColor = Color.White;
                    capitaltxt.BackColor = Color.White;
                    taxatxt.BackColor = Color.White;
                    tempotxt.BackColor = Color.White;
                    break;

                case 1:
                    jurostxt.Visible = true;
                    montantetxt.Visible = true;
                    capitaltxt.Visible = true;
                    taxatxt.Visible = true;
                    tempotxt.Visible = true;
                    capitaltxt.BackColor = Color.LightGreen;
                    jurostxt.BackColor = Color.White;
                    montantetxt.BackColor = Color.White;
                    taxatxt.BackColor = Color.White;
                    tempotxt.BackColor = Color.White;

                    break;

                case 2:
                    jurostxt.Visible = true;
                    montantetxt.Visible = true;
                    capitaltxt.Visible = true;
                    taxatxt.Visible = true;
                    tempotxt.Visible = true;
                    taxatxt.BackColor = Color.LightGreen;
                    jurostxt.BackColor = Color.White;
                    capitaltxt.BackColor = Color.White;
                    montantetxt.BackColor = Color.White;
                    tempotxt.BackColor = Color.White;

                    break;

                case 3:
                    jurostxt.Visible = true;
                    montantetxt.Visible = true;
                    capitaltxt.Visible = true;
                    taxatxt.Visible = true;
                    tempotxt.Visible = true;
                    tempotxt.BackColor = Color.LightGreen;
                    jurostxt.BackColor = Color.White;
                    capitaltxt.BackColor = Color.White;
                    taxatxt.BackColor = Color.White;
                    montantetxt.BackColor = Color.White;
                    break;
            }
        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {
            int tipoCalculo = escolhacb.SelectedIndex;
            double resultado = 0, juros=0, c, ta, t,m;

            switch (tipoCalculo)
            {
                case 0:
                     c = Convert.ToDouble(capitaltxt.Text);
                    ta = Convert.ToDouble(taxatxt.Text)/100;
                     t = Convert.ToDouble(tempotxt.Text);
                    resultado = c * (1 + ta * t);
                     montantetxt.Text = resultado.ToString("F2");
                    juros = resultado - c;
                    jurostxt.Text = juros.ToString("F2");
                    break;

                case 1:
                    m = Convert.ToDouble(montantetxt.Text);
                    ta = Convert.ToDouble(taxatxt.Text) / 100;
                    t = Convert.ToDouble(tempotxt.Text);
                    resultado = m/ (1 + ta * t);
                    capitaltxt.Text = resultado.ToString("F2");
                    juros = resultado - m;
                    jurostxt.Text = juros.ToString("F2");
                    break;
                case 2:
                    m = Convert.ToDouble(montantetxt.Text);
                    c = Convert.ToDouble(capitaltxt.Text);
                    t = Convert.ToDouble(tempotxt.Text);
                    resultado = (m - c) / (c * t);
                    taxatxt.Text = resultado.ToString("F2");
                    juros = c - m;
                    jurostxt.Text = juros.ToString("F2");
                    break;
                case 3:
                    m = Convert.ToDouble(montantetxt.Text);
                    c = Convert.ToDouble(capitaltxt.Text);
                    ta = Convert.ToDouble(taxatxt.Text) / 100;
                    resultado = (m-c)/(c*ta);
                    tempotxt.Text = resultado.ToString("F2");
                    juros = c - m;
                    jurostxt.Text = juros.ToString("F2");
                    break;
            }
        }

        private void montantetxt_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = montantetxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                montantetxt.Text = montantetxt.Text.Remove(montantetxt.Text.Length - 1);
            }
        }

        private void capitaltxt_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = capitaltxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                capitaltxt.Text = capitaltxt.Text.Remove(capitaltxt.Text.Length - 1);
            }
        }

        private void taxatxt_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = taxatxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                taxatxt.Text = taxatxt.Text.Remove(taxatxt.Text.Length - 1);
            }
        }

        private void tempotxt_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = tempotxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tempotxt.Text = tempotxt.Text.Remove(tempotxt.Text.Length - 1);
            }
        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            montantetxt.Clear();
            capitaltxt.Clear();
            taxatxt.Clear();
            tempotxt.Clear();
            jurostxt.Clear();
            escolhacb.Select();
        }
    }
}
