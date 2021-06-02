using Caça_frutas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caça_frutas.Interfaces
{
    public interface IAdministrador : IUsuarioBase
    {
        void ExpulsaJogador(Jogador jogador);
        void PresenteiaBonus(Jogador jogador, double bonus);
    }
}
