using Caça_frutas.Interfaces;
using Caça_frutas.MessageBoxs;
using Caça_frutas.Models;
using Caça_frutas.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Caça_frutas.Telas
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();

        }
        private void btnTelaLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                var verificaSeExiste = GlobalVariables.ListaDeUsuarios.Find(x => x.Nome == txtNome.Text);// Verifica se o nome de jogador já existe
                string senha = PasswordHandler.HashSenha(txtPassword.Text); // cria uma senha encriptografada

                if (verificaSeExiste == null) // Se o nome de jogador não existir, realiza o cadastro e o salva no arquivo
                {
                    GlobalVariables.ListaDeUsuarios.Add(new Jogador(txtNome.Text, Convert.ToInt32(txtIdade.Text), senha));

                    JsonFileHandler.SalvarLista(GlobalVariables.FilePath, GlobalVariables.ListaDeUsuarios, true);

                    txtNome.Clear();
                    txtPassword.Clear();
                    txtIdade.Clear();

                    CadastroRealizadoMessage message = new CadastroRealizadoMessage();
                    message.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Esse nome de usuário já existe, escolha outro");
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

    }
}
