using Caça_frutas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caça_frutas.Models
{
    public class Jogador : UsuarioBase, IJogador
    {
        public event EventHandler<string> ApostaRealizadaEvent;

        private double saldoAtual;       
        public double SaldoAtual
        {
            get => saldoAtual;
            set
            {
                if (value < 0)
                    throw new Exception($"Você só Possui {saldoAtual} em sua conta");

                saldoAtual = value;
            }
        }
        public double UltimoGanho { get; set; }

        public List<string> Registros { get; private set; }

        public override string Nivel { get; protected set; } 

        public Jogador(string nome, int idade, string senha)
        {
            Nome = nome;
            Idade = idade;
            Senha = senha;
            SaldoAtual = 0.0;
            UltimoGanho = 0.0;
            Registros = new List<string>();
            Nivel = "Jogador";
        }


        /// <summary>
        /// Depoista um valor na conta do Jogador
        /// </summary>
        /// <param name="value">Valor a ser Depositado</param>
        public void Depositar(double value)
        {
            SaldoAtual += value;

            Registros.Add(value == 1 ? $"Você depositou {value} real" : $"Você depositou {value} reais");

            ApostaRealizadaEvent?.Invoke(this, "Depositou");
        }


        /// <summary>
        /// Realiza o pagamento da aposta do caça niquel
        /// </summary>
        /// <param name="aposta">Valor apostado pelo jogador</param>
        public void PagaAposta(double aposta)
        {
            SaldoAtual -= aposta;
            ApostaRealizadaEvent?.Invoke(this, "Pagou");        
        }

        /// <summary>
        /// Premia o jogador, acrescentando o premio em seu saldo
        /// </summary>
        /// <param name="value">Valor ganho pelo jogador no caça niquel</param>
        public void Premia(double value)
        {
           
            SaldoAtual += value;
            UltimoGanho = value;
            Registros.Add(value == 1 ? $"Você ganhou {value} real" : $"Você ganhou {value} reais"); 

            ApostaRealizadaEvent?.Invoke(this, "Ganhou");                    
        }

    }
}
