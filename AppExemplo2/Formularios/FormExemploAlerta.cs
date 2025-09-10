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
    public partial class FormExemploAlerta : Form
    {
        public FormExemploAlerta()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);
            double total = valor1 / valor2;
            txtTotal.Text = total.ToString("F2");
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtTotal.Clear();
            txtValor1.Select();
        }
    }
}
