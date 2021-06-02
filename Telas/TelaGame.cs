using Caça_frutas.MessageBoxs;
using Caça_frutas.Models;
using Caça_frutas.Utilities;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caça_frutas.Telas
{
    public partial class TelaGame : Form
    {
        public TelaGame()
        {
            InitializeComponent();

            CarregaInformacoes();
        }

        /// <summary>
        /// Carrega as informações do jogador atual
        /// </summary>
        private void CarregaInformacoes()
        {
            lblBemVindo.Text = $"Bem vindo {GlobalVariables.JogadorAtual.Nome} ao Caça-Frutas";
            lblSaldo.Text = GlobalVariables.JogadorAtual.SaldoAtual.ToString("f2");
            lblUltimoGanho.Text = GlobalVariables.JogadorAtual.UltimoGanho.ToString("f2");

            GlobalVariables.JogadorAtual.ApostaRealizadaEvent += JogadorAtual_ApostaRealizadaEvent;
        }

        private void JogadorAtual_ApostaRealizadaEvent(object sender, string e)
        {
            lblSaldo.Text = GlobalVariables.JogadorAtual.SaldoAtual.ToString("f2");
            lblUltimoGanho.Text = GlobalVariables.JogadorAtual.UltimoGanho.ToString("f2");
        }

        private async void btnSpin_Click(object sender, EventArgs e)
        {
            //Verifica se o jogador tem saldo para roletar, caso tenha, chama a classe GameMetodos e roleta
            if ((GlobalVariables.JogadorAtual.SaldoAtual - Convert.ToDouble(lblValorAposta.Text)) < 0)
            {
                MessageBox.Show($"Você só possui {lblSaldo.Text}, diminua sua aposta ou deposite!");
            }
            else
            {
                btnSpin.Enabled = false;
                btnAumentaBet.Enabled = false;
                btnDiminuiBet.Enabled = false;

                GameMetodos game = new GameMetodos();
                await game.LigaCacaNiquel(pbLeft, pbCenter, pbRight, Convert.ToDouble(lblValorAposta.Text));

                // O jogo aguarda o metodo game.LigaCacaNiquel terminar para seguir rodando

                btnSpin.Enabled = true;
                btnAumentaBet.Enabled = true;
                btnDiminuiBet.Enabled = true;
            }

        }
    
        private void btnAumentaBet_Click(object sender, EventArgs e)
        {
            double aposta = Convert.ToDouble(lblValorAposta.Text);
            aposta += 1.00;
            lblValorAposta.Text = aposta.ToString("f2");
        }

        private void btnDiminuiBet_Click(object sender, EventArgs e)
        {
            double aposta = Convert.ToDouble(lblValorAposta.Text);
            if ((aposta - 1.00) <= 0)
            {
                MessageBox.Show("A aposta não pode ser menor ou igual a zero");
                return;
            }
            aposta -= 1.00;
            lblValorAposta.Text = aposta.ToString("f2");
        }

        private void btnEsperança_Click(object sender, EventArgs e)
        {
            TelaEsperanca telaEsperanca = new TelaEsperanca();
            this.Visible = false;
            telaEsperanca.ShowDialog();
            this.Visible = true;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
