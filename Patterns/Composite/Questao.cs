﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    public class Questao : IQuestao
    {
        public string Enunciado { get; set; }

        public void Adicionar(IQuestao questao)
        {
            //Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public void Remover(IQuestao questao)
        {
            //Console.WriteLine("Cannot remove from a PrimitiveElement");
        }

        public void Exibir(int i, int j, int pai)
        {
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
        }
    }
}
