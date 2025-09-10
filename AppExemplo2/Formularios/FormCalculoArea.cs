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
    public partial class FormCalculoArea : Form
    {
        public FormCalculoArea()
        {
            InitializeComponent();
            hipotenusatxt.Visible = false;
            areatxt.Visible = false;
            hipotenusalb.Visible = false;
            arealb.Visible = false;
            areatxt.BackColor = Color.Green;
        }

        private void tipocalculocb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCalculo = tipocalculocb.SelectedIndex;
            switch (tipoCalculo)
            {
                case 0:
                    hipotenusatxt.Visible = false;
                    hipotenusalb.Visible = false;
                    areatxt.Visible = true;
                    arealb.Visible = true;
                    ladoatxt.BackColor = Color.White;
                    ladobtxt.BackColor = Color.White;
                    break;

                case 1:
                    hipotenusatxt.Visible = true;
                    hipotenusalb.Visible = true;
                    areatxt.Visible = false;
                    arealb.Visible = false;
                    ladoatxt.BackColor = Color.Green;
                    ladobtxt.BackColor = Color.White;
                    hipotenusatxt.BackColor = Color.White;

                    break;

                case 2:
                    hipotenusatxt.Visible = true;
                    hipotenusalb.Visible = true;
                    areatxt.Visible = false;
                    arealb.Visible = false;
                    ladobtxt.BackColor = Color.Green;
                    ladoatxt.BackColor = Color.White;
                    hipotenusatxt.BackColor = Color.White;

                    break;

                case 3:
                    hipotenusatxt.Visible = true;
                    hipotenusalb.Visible = true;
                    areatxt.Visible = false;
                    arealb.Visible = false;
                    ladobtxt.BackColor = Color.White;
                    ladoatxt.BackColor = Color.White;
                    hipotenusatxt.BackColor = Color.Green;

                    break;
            }
        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {
            int tipoCalculo = tipocalculocb.SelectedIndex;
            double catetoa, catetob, hipotenusa, area;
            switch (tipoCalculo)
            {
                case 0:
                    catetoa = Convert.ToDouble(ladoatxt.Text);
                    catetob = Convert.ToDouble(ladobtxt.Text);
                    area = (catetoa * catetob) / 2;
                    areatxt.Text = area.ToString("F2");
                    break;

                case 1:
                    catetob = Convert.ToDouble(ladobtxt.Text);
                    hipotenusa = Convert.ToDouble(hipotenusatxt.Text);
                    catetob = catetob * catetob;
                    hipotenusa = hipotenusa * hipotenusa;
                    catetoa = Math.Pow((hipotenusa - catetob), 0.5);
                    ladoatxt.Text = catetoa.ToString("F2");
                    break;
                case 2:
                    catetoa = Convert.ToDouble(ladoatxt.Text);
                    hipotenusa = Convert.ToDouble(hipotenusatxt.Text);
                    catetoa = catetoa * catetoa;
                    hipotenusa = hipotenusa * hipotenusa;
                    catetoa = Math.Pow((hipotenusa - catetoa), 0.5);
                    ladobtxt.Text = catetoa.ToString("F2");
                    break;
                case 3:
                    catetoa = Convert.ToDouble(ladoatxt.Text);
                    catetob = Convert.ToDouble(ladobtxt.Text);

                    catetoa = catetoa * catetoa;
                    catetob = catetob * catetob;

                    hipotenusa = Math.Pow((catetoa + catetob), 0.5);
                    hipotenusatxt.Text = hipotenusa.ToString("F2");
                    break;
            }
        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            ladoatxt.Clear();
            ladobtxt.Clear();
            hipotenusatxt.Clear();
            areatxt.Clear();
            hipotenusatxt.Visible = false;
            areatxt.Visible = false;
            hipotenusalb.Visible = false;
            arealb.Visible = false;
            ladobtxt.BackColor = Color.White;
            ladoatxt.BackColor = Color.White;
            hipotenusatxt.BackColor = Color.White;
        }

        private void ladoatxt_leave(object sender, EventArgs e)
        {
        }

        private void ladobtxt_leave(object sender, EventArgs e)
        {

        }

        private void hipotenusatxt_leave(object sender, EventArgs e)
        {

        }

        private void FormCalculoArea_Load(object sender, EventArgs e)
        {

        }

        private void ladoatxt_keyup(object sender, KeyEventArgs e)
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
                int qtdVirgula = ladoatxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ladoatxt.Text = ladoatxt.Text.Remove(ladoatxt.Text.Length - 1);
            }

        }

        private void ladobtxt_keyup(object sender, KeyEventArgs e)
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
                int qtdVirgula = ladobtxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ladobtxt.Text = ladobtxt.Text.Remove(ladobtxt.Text.Length - 1);
            }
        }

        private void hipotenusatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void hipotenusatxt_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = hipotenusatxt.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hipotenusatxt.Text = hipotenusatxt.Text.Remove(hipotenusatxt.Text.Length - 1);
            }
        }
    }
}
