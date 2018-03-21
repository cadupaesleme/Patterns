﻿using Patterns.AbstractFactory;
using Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Primeiramente gera as avaliações possiveis para o curso em Primeira Avaliacao e Segunda Avaliacao
            //Utilizado o padrão abstract factory para construir as avaliações
            IAvaliacaoFactory primeiraAvaliacaoFactory = new PrimeiraAvaliacao();
            IAvaliacaoFactory segundaAvaliacaoFactory = new SegundaAvaliacao();

            Console.WriteLine("-------------------------- Gerando os Modos de Avaliação do Curso --------------------------");
            Console.WriteLine("");
            Console.WriteLine("--------- Primeira Avaliação ---------");
            Avaliacao primeiraAvaliacao = new Avaliacao(primeiraAvaliacaoFactory, "Presencial");
            Console.WriteLine(primeiraAvaliacao.GetAvaliacaoEscrita());
            Console.WriteLine(primeiraAvaliacao.GetAvaliacaoOral());

            primeiraAvaliacao = new Avaliacao(primeiraAvaliacaoFactory, "Online");
            Console.WriteLine(primeiraAvaliacao.GetAvaliacaoEscrita());
            Console.WriteLine(primeiraAvaliacao.GetAvaliacaoOral());

            Console.WriteLine("");
            Console.WriteLine("--------- Segunda Avaliação ---------");
            Avaliacao segundaAvaliacao = new Avaliacao(segundaAvaliacaoFactory, "Presencial");
            Console.WriteLine(segundaAvaliacao.GetAvaliacaoEscrita());
            Console.WriteLine(segundaAvaliacao.GetAvaliacaoOral());

            segundaAvaliacao = new Avaliacao(segundaAvaliacaoFactory, "Online");
            Console.WriteLine(segundaAvaliacao.GetAvaliacaoEscrita());
            Console.WriteLine(segundaAvaliacao.GetAvaliacaoOral());


            //Gerar 2 provas escritas (primeira avaliacao e segunda avaliacao)
            Console.WriteLine("");
            Console.WriteLine("-------------------------- Gerando as Provas Escritas do Curso --------------------------");
            Console.WriteLine("");

            //cria uma prova
            Prova provaEscrita1 = new Prova();

            //criar questoes para a prova
            QuestaoComposite questao1 = new QuestaoComposite { Enunciado = "Enunciado" };
            questao1.Adicionar(new Questao { Enunciado = "Enunciado da Questão" });
            questao1.Adicionar(new Questao { Enunciado = "Enunciado da Questão" });
            

            QuestaoComposite composite = new QuestaoComposite { Enunciado = "Enunciado da Questão" };
            composite.Adicionar(new Questao { Enunciado = "Enunciado da Questão" });
            questao1.Adicionar(composite);

            provaEscrita1.Questoes.Add(questao1);



            QuestaoComposite questao2 = new QuestaoComposite { Enunciado = "Enunciado" };
            provaEscrita1.Questoes.Add(questao2);

            QuestaoComposite questao3 = new QuestaoComposite { Enunciado = "Enunciado" };
            questao3.Adicionar(new Questao { Enunciado = "Enunciado da Questão" });
            questao3.Adicionar(new Questao { Enunciado = "Enunciado da Questão" });
            provaEscrita1.Questoes.Add(questao3);

            provaEscrita1.ExibirProva();




            //QuestaoComposite questao1 = new QuestaoComposite { Enunciado="Enunciado" };
            //questao1.Adicionar(new Questao { Enunciado = "Enunciado da Questão" });
            //questao1.Adicionar(new Questao { Enunciado = "Enunciado da Questão" });

            //QuestaoComposite questao2 = new QuestaoComposite { Enunciado = "Enunciado" };
            //questao1.Adicionar(questao2);

            //questao1.Exibir(1);


            //Questao questao1 = new Questao();
            //questao1.Enunciado = "Enunciado da Questão 1";
            //Questao questao2 = new Questao();
            //questao2.Enunciado = "Enunciado da Questão 2";
            //Questao questao3 = new Questao();
            //questao3.Enunciado = "Enunciado da Questão 3";

            //QuestaoComposta questao4 = new QuestaoComposta { Enunciado = "Enunciado da Questão 4" };
            //questao4.SubQuestoes.Add(new Questao { Enunciado = "Enunciado da Questão 4.1" });
            //questao4.SubQuestoes.Add(new Questao { Enunciado = "Enunciado da Questão 4.2" });
            //questao4.SubQuestoes.Add(new Questao { Enunciado = "Enunciado da Questão 4.3" });

            //Console.WriteLine("");
            //Console.WriteLine("--------- Gerando Prova ---------");
            ////colocar isso em objeto prova e percorrer
            //Console.WriteLine(questao1.Enunciado);
            //Console.WriteLine("");
            //Console.WriteLine(questao2.Enunciado);
            //Console.WriteLine("");
            //Console.WriteLine(questao3.Enunciado);
            //Console.WriteLine("");
            //Console.WriteLine(questao4.Enunciado);







            Console.ReadLine();

            //Gerar o tempo estimado 
        }
    }
}
