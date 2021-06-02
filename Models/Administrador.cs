using Caça_frutas.Interfaces;
using Caça_frutas.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caça_frutas.Models
{
    public class Administrador: UsuarioBase, IAdministrador
    {
        public override string Nivel { get; protected set; } 

        public Administrador(string nome, int idade, string senha)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Senha = senha;
            Nivel = "Administrador";
        }


        /// <summary>
        /// Expulsa um jogador da Casa(Perfil no Jogo) e atualiza o arquivo jogadores.json
        /// </summary>
        /// <param name="jogador">Jogador a ser expulso</param>
        public void ExpulsaJogador(Jogador jogador)
        {
            GlobalVariables.ListaDeUsuarios.Remove(jogador);
            JsonFileHandler.SalvarLista(GlobalVariables.FilePath, GlobalVariables.ListaDeUsuarios, true);             
        }


        /// <summary>
        /// Presenteia um jogador especifico com um bônus determinado
        /// </summary>
        /// <param name="jogador">Jogador a ser presentado</param>
        /// <param name="bonus">Bônus que sera depositado na conta do jogador</param>
        public void PresenteiaBonus(Jogador jogador, double bonus)
        {
            var jog = GlobalVariables.ListaDeUsuarios.Find(x => x.Nome == jogador.Nome);
            jog.Depositar(bonus);
            JsonFileHandler.SalvarLista(GlobalVariables.FilePath, GlobalVariables.ListaDeUsuarios, true);
        }

    }
}
