using Caça_frutas.Interfaces;
using Caça_frutas.Models;
using Caça_frutas.Telas;
using Caça_frutas.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Caça_frutas
{
    public partial class TelaLogin : Form
    {

        public TelaLogin()
        {
            InitializeComponent();
        }
        private void btnTelaCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro tela = new TelaCadastro();
            this.Visible = false;
            tela.ShowDialog();
            this.Visible = true;
            txtLoginName.Clear();
            txtLoginPass.Clear();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o jogoador existe na lista de Usuários
                Jogador jog = GlobalVariables.ListaDeUsuarios.Find(x => x.Nome == txtLoginName.Text);

                if (jog != null)// Se o jogador existir, verifica se sua senha está correta
                {
                    GlobalVariables.JogadorAtual = jog;
                    bool verificaSenha = PasswordHandler.ComparaSenha(txtLoginPass.Text, GlobalVariables.JogadorAtual.Senha);

                    if (verificaSenha)// Se a senha estiver correta, entra no jogo
                    {
                        TelaGame telaGame = new TelaGame();
                        this.Visible = false;

                        telaGame.ShowDialog();
                        this.Visible = true;
                        txtLoginName.Clear();
                        txtLoginPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta");
                    }
                }
                else if(txtLoginName.Text == GlobalVariables.AdministradorAtual.Nome) // Se o nome não existe na lista, verifica se é o nome do Admin
                {
                    bool verificaSenha = PasswordHandler.ComparaSenha(txtLoginPass.Text, GlobalVariables.AdministradorAtual.Senha);
                    if (verificaSenha)// Verifica se a senha do admin está correta(true), e se estiver entra na tela de administrador
                    {
                        TelaAdministrador telaAdministrador = new TelaAdministrador();
                        this.Visible = false;

                        telaAdministrador.ShowDialog();
                        this.Visible = true;
                        txtLoginName.Clear();
                        txtLoginPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta");
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }     
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
