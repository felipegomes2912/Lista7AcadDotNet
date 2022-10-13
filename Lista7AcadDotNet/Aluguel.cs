using Lista7AcadDotNet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lista7AcadDotNet
{
    internal class Aluguel
    {
        private string dataInicio = "07/10/2022", dataFim = "10/10/2022"; 
        public Carro carro;
        public Cliente cliente;

        public Aluguel(Carro carro, string dataInicio, string dataFim, Cliente cliente)
        {
            this.carro = carro;
            this.dataFim = dataFim;
            this.dataInicio = dataInicio;
            this.cliente = cliente;
        }

        public string getdataInicio()
        {
            return dataInicio;
        }
        public string getdataFim()
        {
            return dataFim;
        }

    }
}
