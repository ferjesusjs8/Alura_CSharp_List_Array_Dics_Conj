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
            String aula1 = "aula 1";
            String aula2 = "aula 2";
            String aula3 = "aula 3";

            // String[] aulas = new String[]
            // {
            //     aula1,
            //     aula2,
            //     aula3
            // };

            String[] aulas = new String[3];
            aulas[0] = aula1;
            aulas[1] = aula2;
            aulas[2] = aula3;
            Imprimir(aulas);
            Imprimir2(aulas);

            Console.WriteLine(aulas[aulas.Length - 1]);

            Console.WriteLine("Aula 2 está no indíce: " + Array.IndexOf(aulas, aula2));

            Console.WriteLine(Array.LastIndexOf(aulas, aula2));

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Reverse(aulas);
            Imprimir2(aulas);

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            Array.Sort(aulas);
            Imprimir(aulas);

            string[] copia = new string[2];

            /**/
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);
            /**/

            string[] clone = aulas.Clone() as string[];

            Imprimir(clone);

            Array.Clear(clone, 1, 2);
            Imprimir2(clone);
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
