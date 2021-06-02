using Caça_frutas.Utilities;
using System.Windows.Forms;

namespace Caça_frutas.Telas
{
    public partial class TelaHistorico : Form
    {
        public TelaHistorico()
        {
            InitializeComponent();

            lbHistorico.DataSource = GlobalVariables.JogadorAtual.Registros;
            GlobalVariables.JogadorAtual.ApostaRealizadaEvent += Jogador_ApostaRealizadaEvent;

        }

        private void Jogador_ApostaRealizadaEvent(object sender, string e)
        {
            lbHistorico.DataSource = null;
            lbHistorico.DataSource = GlobalVariables.JogadorAtual.Registros;            
        }
    }
}
