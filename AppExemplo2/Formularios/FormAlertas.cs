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
    public partial class FormAlertas : Form
    {
        public FormAlertas()
        {
            InitializeComponent();
        }

        private void btInformacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Mensagem", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btAtencao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Mensagem", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Mensagem", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btPergunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Mensagem", "Título da Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btExemplo_Click(object sender, EventArgs e)
        {
            DialogResult resposta; 
            resposta = MessageBox.Show("Gosta de Futebol", "ADS/JIPA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            MessageBox.Show("Resposta: "+resposta.ToString(), "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resposta = MessageBox.Show("Deseja fechar o Programa?", "ADS/JIPA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                this.Close(); //fechar o programa
            }
        }
    }
}
