using System;
using System.Collections.Generic;
using System.Text;

namespace Lista7AcadDotNet
{
    internal class Carro
    {
        private double consumo = 10.2;
        private string placa = "123ABC123";
        private string fabricante = "Honda";
        private string cor = "Verde";

        public Carro(double consumo, string placa, string fabricante, string cor)
        { 
            this.consumo = consumo;
            this.placa = placa;
            this.fabricante = fabricante;
            this.cor = cor;
        }

        public string getCor()
        {
            return cor;
        }
        public double getConsumo()
        {
            return consumo;
        }
        public string getPlaca()
        {
            return placa;
        }
        public string getFabricante()
        {
            return fabricante;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }
    }
}
