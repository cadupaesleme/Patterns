using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    interface IProvaFactory
    {
        IModoProva GetModoProva(string modo);
        ITipoProva GetTipoProva(string tipoProva);

    }
}
