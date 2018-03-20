using Patterns.AbstractFactory;
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
            Console.WriteLine("-------------------------- Gerando os Provas Escritas do Curso --------------------------");


            Console.ReadLine();

            //Gerar o tempo estimado 
        }
    }
}
