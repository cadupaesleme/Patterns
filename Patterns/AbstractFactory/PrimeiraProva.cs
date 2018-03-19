using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    class PrimeiraProva : IProvaFactory
    {
        public IModoProva GetModoProva(string modo)
        {
            switch (modo)
            {
                case "Presencial":
                    return new ProvaPresencial();
                case "Online":
                    return new ProvaOnline();
                default:
                    throw new ApplicationException(modo + " - este modo de prova não pôde ser criardo.");
            }
        }

        public ITipoProva GetTipoProva(string tipoProva)
        {
            switch (tipoProva)
            {
                case "Discursiva":
                    return new ProvaDiscursiva();
                case "Objetiva":
                    return new ProvaObjetiva();
                default:
                    throw new ApplicationException(tipoProva + " - este modo de prova não pôde ser criardo.");
            }
        }
    }
}
