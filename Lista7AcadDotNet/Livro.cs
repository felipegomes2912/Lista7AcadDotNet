using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7AcadDotNet
{
    internal class Livro
    {
        public string capa;
        public string tema;
        public int faixaEtaria;
        public Livro(string capa, string tema, int faixaEtaria)
        {
            this.capa = capa; 
            this.tema = tema;
            this.faixaEtaria = faixaEtaria;
        }
    }
}
