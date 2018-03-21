using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    class Prova
    {
        public IList<IQuestao> Questoes { get; set; }
        public string Materia { get; set; }
        public float TempoEstimado { get; set; }

        public Prova()
        {
            Questoes = new List<IQuestao>();
        }

        public void ExibirProva()
        {
            int pai = 0;

            foreach (IQuestao q in Questoes)
            {
                pai++;
                q.Exibir(1,0,pai);
            }
        }
    }
}
