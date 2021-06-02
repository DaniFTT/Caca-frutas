using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caça_frutas.Interfaces
{
    public interface IJogador : IUsuarioBase
    {
        event EventHandler<string> ApostaRealizadaEvent;
        double SaldoAtual { get; set; }
        double UltimoGanho { get; set; }
        List<string> Registros { get; }

        void PagaAposta(double aposta);
        void Depositar(double value);
        void Premia(double value);
    }
}
