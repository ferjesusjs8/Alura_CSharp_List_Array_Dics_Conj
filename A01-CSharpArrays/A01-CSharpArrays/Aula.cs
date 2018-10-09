using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_CSharpArrays
{
    public class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return this.Titulo.CompareTo(that.Titulo);
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Tempo: {Tempo}";
        }

        public void SortTempo(List<Aula> aulas)
        {
            aulas.Sort((x, y) => x.Tempo.CompareTo(y.tempo));
            foreach (var aula in aulas)
            {
                Console.WriteLine(aulas);
            }
        }
    }
}
