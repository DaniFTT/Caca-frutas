using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caça_frutas.Interfaces
{
    public interface IUsuarioBase
    {
        string Nome { get; }
        int Idade { get; }
        string Senha { get; }
        string Nivel { get; }
    }
}
