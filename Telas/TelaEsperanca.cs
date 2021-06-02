using Caça_frutas.Models;
using Caça_frutas.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Caça_frutas.Telas
{
    public partial class TelaEsperanca : Form
    {

        public TelaEsperanca()
        {
            InitializeComponent();

            CarregaInformacoes();
        }

        /// <summary>
        /// Carrega as informações do jogador atual
        /// </summary>
        private void CarregaInformacoes()
        {
            lblSaldo.Text = GlobalVariables.JogadorAtual.SaldoAtual.ToString("f2");
            GlobalVariables.JogadorAtual.ApostaRealizadaEvent += JogadorAtual_ApostaRealizadaEvent;
        }

        private void JogadorAtual_ApostaRealizadaEvent(object sender, string e)
        {
            lblSaldo.Text = GlobalVariables.JogadorAtual.SaldoAtual.ToString("f2");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TelaHistorico telaHistorico = new TelaHistorico();
            telaHistorico.Show();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double deposito = Convert.ToDouble(txtDeposito.Text);
            GlobalVariables.JogadorAtual.Depositar(deposito);

            JsonFileHandler.SalvarLista(GlobalVariables.FilePath, GlobalVariables.ListaDeUsuarios, true);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
