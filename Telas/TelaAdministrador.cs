using System;
using System.Windows.Forms;
using Caça_frutas.Utilities;
using System.Collections.Generic;
using Caça_frutas.Models;

namespace Caça_frutas.Telas
{
    public partial class TelaAdministrador : Form
    {
        List<Jogador> lista;
        public TelaAdministrador()
        {
            InitializeComponent();
        }

        private void TelaAdministrador_Load(object sender, EventArgs e)
        {
            CarregaListaDeJogadores();
        }


        /// <summary>
        /// Carrega lista atualizada de jogadores do arquivo jogadores.json
        /// e os coloca na listView de jogadores
        /// </summary>
        private void CarregaListaDeJogadores()
        {
            lista = GlobalVariables.ListaDeUsuarios;

            listViewJogadores.Items.Clear();
            foreach (var jogador in lista)
            {
                var row = new string[] {
                jogador.Nome,
                jogador.Nivel,
                jogador.SaldoAtual.ToString(),
                jogador.Idade.ToString()
            };
                var lvi = new ListViewItem(row)
                {
                    Tag = jogador
                };

                listViewJogadores.Items.Add(lvi);
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Jogador)listViewJogadores.SelectedItems[0].Tag;
                if (selectedItem != null)
                {
                    GlobalVariables.AdministradorAtual.PresenteiaBonus(selectedItem, Convert.ToDouble(txtBonus.Text));

                    CarregaListaDeJogadores();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um jogador para depositar um bônus");
            }
        }

        private void btnExpulsar_Click(object sender, EventArgs e)
        {

            try
            {
                var selectedItem = (Jogador)listViewJogadores.SelectedItems[0].Tag;
                if (selectedItem != null)
                {
                    GlobalVariables.AdministradorAtual.ExpulsaJogador(selectedItem);

                    CarregaListaDeJogadores();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um jogador para expulsar");
            }
        }
    }
}
