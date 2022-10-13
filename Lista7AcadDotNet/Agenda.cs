using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7AcadDotNet
{
    internal class Agenda
    {
        static List<Pessoas> agenda = new List<Pessoas>();
        public string nome;

        public Agenda(string nome)
        {
            this.nome = nome;
        }

        public void addPessoas(int idade, int altura, string nome)
        {
            Pessoas pessoas = new Pessoas(altura, idade, nome);
            agenda.Add(pessoas);
        }
        public Pessoas buscaPessoas(string nome)
        {
            Pessoas p = null;
            foreach (Pessoas pessoas in agenda)
            {
                if (pessoas.nome.Equals(nome))
                {
                    p = pessoas;
                }
            }
            return p;
        }
        

    }
}
