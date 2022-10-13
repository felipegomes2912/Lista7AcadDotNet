using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7AcadDotNet
{
    internal class Pessoa
    {
        public int altura, peso;
        public string corDosOlhos, corDoCabelo;

        public Pessoa(int altura, int peso, string corDosOlhos, string corDoCabelo)
        {
            this.altura = altura;
            this.peso = peso;
            this.corDosOlhos = corDosOlhos;
            this.corDoCabelo = corDoCabelo;
        }   
        public void getAltura()
        {
            Console.WriteLine("Altura digitada: " + altura);
        }
        public void getPeso()
        {
            Console.WriteLine("Peso digitada: " + peso);
        }
        public void getCorDosOlhos()
        {
            Console.WriteLine("Cor dos olhos digitada: " + corDosOlhos);
        }
        public void getCorDoCabelo()
        {
            Console.WriteLine("Cor do cabelo digitada: " + corDoCabelo);
        }
    }
}
