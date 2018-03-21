using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    public interface IQuestao
    {
        string Enunciado { get; set; }
        void Adicionar(IQuestao questao);        
        void Remover(IQuestao questao);        
        void Exibir(int i, int j, int pai);
    }
}
