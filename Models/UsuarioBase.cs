using Caça_frutas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caça_frutas.Models
{
    public class UsuarioBase : IUsuarioBase
    {
        /// <summary>
        /// Classe com os atributos e validações que todo usuário deve ter
        /// </summary>
        private string nome;
        private int idade;
        private string senha;
        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome de Usuário é Obrigatório");

                nome = value;
            }
        }
        public int Idade
        {
            get => idade;
            set
            {
                if (value < 18)
                    throw new Exception("O usuário deve ser maior de idade");

                idade = value;
            }
        }
        public string Senha
        {
            get => senha;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A senha é Obrigatória");

                senha = value;
            }
        }

        public virtual string Nivel { get; protected set; }
    }
}
