using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    class QuestaoComposta : IQuestao
    {
        public string Enunciado { get; set; }

        public List<IQuestao> SubQuestoes = new List<IQuestao>();

        public void AdicionarSubQuestao(IQuestao subquestao)
        {
            SubQuestoes.Add(subquestao);
        }
    }
}
