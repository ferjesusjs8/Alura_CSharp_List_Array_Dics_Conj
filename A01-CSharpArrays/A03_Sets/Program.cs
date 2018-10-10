using A03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso cSharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");
            cSharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            cSharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            cSharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno aluno1 = new Aluno("Vanessa Tonini", 34672);
            Aluno aluno2 = new Aluno("Ana Losnak", 5617);
            Aluno aluno3 = new Aluno("Rafael Nercessian", 17645);

            cSharpColecoes.Matricula(aluno1);
            cSharpColecoes.Matricula(aluno2);
            cSharpColecoes.Matricula(aluno3);

            Console.WriteLine("Imprimindo alunos matriculados");
            foreach (var aluno in cSharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine($"O Aluno {aluno1.Nome} está matriculado?!");
            Console.WriteLine(cSharpColecoes.EstaMatriculado(aluno1));

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);

            Console.WriteLine(
                                "Tonini está matriculada?! "
                                + cSharpColecoes.EstaMatriculado(tonini) 
                             );

            Console.WriteLine("Tonini == Aluno1? " + (tonini == aluno1));

            Console.WriteLine("Tonini equals Aluno1? " + (tonini.Equals(aluno1)));


        }

        private static void Aula01()
        {
            ISet<string> alunos = new HashSet<string>();

            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            Console.WriteLine(string.Join(", ", alunos));

            List<string> alunosEmLista = new List<string>(alunos);

            alunosEmLista.Sort();

            Console.WriteLine(string.Join(", ", alunosEmLista));
        }
    }
}
