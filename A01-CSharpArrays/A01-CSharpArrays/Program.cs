using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_CSharpArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var aula1 = new Aula("Introdução a coleções", 20);
            var aula2 = new Aula("Modelando a Classe Aula", 18);
            var aula3 = new Aula("Trabalhando com Conjuntos", 16);

            Curso cSharpColecoes = new Curso("C# Collections", "Marcel Oliveira");
            cSharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 20));
            ImprimirAula(cSharpColecoes.Aulas);

            // adicionar 2 aulas
            cSharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            cSharpColecoes.Adiciona(new Aula("Modelando com coleções", 19));

            // imprimir as aulas
            ImprimirAula(cSharpColecoes.Aulas);

            // ordenar lista de aulas

            //copiar esta lista para uma nova lista
            List<Aula> aulasCopiadas = new List<Aula>(cSharpColecoes.Aulas);

            // ordenar a copia
            aulasCopiadas.Sort();

            ImprimirAula(aulasCopiadas);

            // totalizar o tempo do curso
            Console.WriteLine(cSharpColecoes.TempoTotal);

            Console.WriteLine(cSharpColecoes);

        }

        #region Aulas

        private static void AulaAnterior(Aula aula1, Aula aula2, Aula aula3)
        {
            List<Aula> aulas = new List<Aula>();

            aulas.Add(aula1);
            aulas.Add(aula2);
            aulas.Add(aula3);

            ImprimirAula(aulas);

            //aulas.Sort();

            ImprimirAula(aulas);

            aulas.Sort((x, y) => x.Tempo.CompareTo(y.Tempo));

            ImprimirAula(aulas);

            TesteAulas teste1 = new TesteAulas("Pessoa", 123456);
            TesteAulas teste2 = new TesteAulas("Siclano", 654321);
            TesteAulas teste3 = new TesteAulas("Beltrano", 987654321);

            List<TesteAulas> listaTeste = new List<TesteAulas>();

            listaTeste.Add(teste1);
            listaTeste.Add(teste2);
            listaTeste.Add(teste3);

            TesteImprimir(listaTeste);

            listaTeste.Sort();
            TesteImprimir(listaTeste);
        }

        private static void TesteImprimir(List<TesteAulas> listaTeste)
        {
            Console.WriteLine();

            foreach (var teste in listaTeste)
            {
                Console.WriteLine(teste);
            }
        }

        class TesteAulas : IComparable
        {
            private string nome;
            private int cpf;

            public TesteAulas(string nome, int cpf)
            {
                this.nome = nome;
                this.cpf = cpf;
            }

            public string Nome { get => nome; set => nome = value; }
            public int Cpf { get => cpf; set => cpf = value; }

            public int CompareTo(object obj)
            {
                TesteAulas castObj = obj as TesteAulas;
                return Nome.CompareTo(castObj.Nome);
            }

            public override string ToString()
            {
                return $"Nome: {Nome}, CPF: {Cpf}";
            }

        }

        private static void ImprimirAula(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }

        private static void Aula02(string aula1, string aula2, string aula3)
        {
            List<string> aulas = new List<string>();

            aulas.Add(aula1);
            aulas.Add(aula2);
            aulas.Add(aula3);
            //{
            //    aula1,
            //    aula2,
            //    aula3
            //};

            ImprimirLista(aulas);

            Console.WriteLine("A Primeira aula é '" + aulas[0] + "'");
            Console.WriteLine($"A Última aula é '{aulas[aulas.Count - 1]}'");

            Console.WriteLine();

            Console.WriteLine("A Primeira aula é " + aulas.First());
            Console.WriteLine("A Última aula é " + aulas.Last());

            aulas[0] = "Trabalhando com Listas";

            Console.WriteLine("A primeira aula 'Trabalhando' é:" + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A última aula 'Trabalhando' é:" + aulas.Last(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A primeira ou default aula 'contém' é:" + aulas.FirstOrDefault(aula => aula.Contains("Contem")));

            aulas.Reverse();
            ImprimirLista(aulas);
            Console.WriteLine();

            aulas.Reverse();
            ImprimirLista(aulas);

            Console.WriteLine();
            aulas.RemoveAt(aulas.Count - 1);
            ImprimirLista(aulas);

            aulas.Add("Conclusão");
            ImprimirLista(aulas);

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);

            ImprimirLista(copia);

            List<string> clone = new List<string>(aulas);

            ImprimirLista(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            ImprimirLista(clone);

            aulas.Sort();
            ImprimirLista(aulas);
        }

        private static void AulaArrays(out string aula1, out string aula2, out string aula3)
        {
            aula1 = "aula 1";
            aula2 = "aula 2";
            aula3 = "aula 3";

            // String[] aulas = new String[]
            // {
            //     aula1,
            //     aula2,
            //     aula3
            // };

            String[] aulasArray = new String[3];
            aulasArray[0] = aula1;
            aulasArray[1] = aula2;
            aulasArray[2] = aula3;
            Imprimir(aulasArray);
            Imprimir2(aulasArray);

            Console.WriteLine(aulasArray[aulasArray.Length - 1]);

            Console.WriteLine("Aula 2 está no indíce: " + Array.IndexOf(aulasArray, aula2));

            Console.WriteLine(Array.LastIndexOf(aulasArray, aula2));

            Array.Reverse(aulasArray);
            Imprimir(aulasArray);

            Array.Reverse(aulasArray);
            Imprimir2(aulasArray);

            Array.Resize(ref aulasArray, 2);
            Imprimir(aulasArray);

            Array.Resize(ref aulasArray, 3);
            Imprimir(aulasArray);

            aulasArray[aulasArray.Length - 1] = "Conclusão";

            Array.Resize(ref aulasArray, 3);
            Imprimir(aulasArray);

            Array.Sort(aulasArray);
            Imprimir(aulasArray);

            string[] copia = new string[2];

            /**/
            Array.Copy(aulasArray, 1, copia, 0, 2);
            Imprimir(copia);
            /**/

            string[] clone = aulasArray.Clone() as string[];

            Imprimir(clone);

            Array.Clear(clone, 1, 2);
            Imprimir2(clone);
        }

        /// <summary>
        /// Imprime os items de uma lista no console.
        /// </summary>
        /// <param name="lista">Recebe como parâmetro uma lista de string.</param>
        private static void ImprimirLista(List<string> lista)
        {
            // foreach (string item in lista)
            // {
            //     Console.WriteLine(item);
            // }

            lista.ForEach(item =>
            {
                Console.WriteLine(item);
            });
        }

        private static void Imprimir(string[] aulas)
        {
            foreach (string aula in aulas) Console.WriteLine(aula);
        }

        private static void Imprimir2(string[] aulas)
        {
            for (int i = 0; i < aulas.Length; i++) Console.WriteLine(aulas[i]);
        }

        #endregion
    }
}
