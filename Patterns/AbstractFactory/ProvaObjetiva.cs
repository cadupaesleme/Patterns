using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    class ProvaObjetiva : ITipoProva
    {
        public string NomeTipoProva()
        {
            return "Prova Objetiva";
        }
    }
}
