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
            String aula1 = "Aula Intro";
            String aula2 = "Modelando classes";
            String aula3 = "Trabalhando com Conjuntos";

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

            Console.WriteLine("A Primeira aula é '" + aulas[0] +"'");
            Console.WriteLine($"A Última aula é '{aulas[aulas.Count - 1]}'");

            Console.WriteLine();

            Console.WriteLine("A Primeira aula é " + aulas.First());
            Console.WriteLine("A Última aula é " + aulas.Last());
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
    }
}
