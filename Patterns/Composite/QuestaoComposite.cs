using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    class QuestaoComposite : IQuestao
    {
        public string Enunciado { get; set; }
        private List<IQuestao> SubQuestoes = new List<IQuestao>();

        public void Adicionar(IQuestao questao)
        {
            SubQuestoes.Add(questao);
        }

        public void Remover(IQuestao questao)
        {
            SubQuestoes.Remove(questao);
        }

        public void Exibir(int i,int j, int pai)
        {
//            Console.WriteLine(new String('-', i) +
  //            "+ " + i +" " + j + pai +   Enunciado);


            string aux = "";
            if (j == 0)
            {
                aux = pai.ToString();
            }
            else
            {
                aux = pai.ToString() + j + i;
                //aux = new String('-', i) + " " + i + " " + j + pai + Enunciado;
            }

            Console.WriteLine(aux);

            foreach (IQuestao q in SubQuestoes)
            {
                j++;
                q.Exibir(i + 1,j, pai);
            }
        }
    }
}
