using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A03_Sets;

namespace A03
{
    public class Curso
    {
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(", ", aulas)}";
        }

        public Boolean EstaMatriculado(Aluno aluno)
        {
            return Alunos.Contains(aluno);
        }
    }
}
