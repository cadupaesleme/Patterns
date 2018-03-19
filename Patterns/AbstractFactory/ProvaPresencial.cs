using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    class ProvaPresencial : IModoProva
    {
        public string NomeModoProva()
        {
            return "Prova Presencial";
        }
    }
}
