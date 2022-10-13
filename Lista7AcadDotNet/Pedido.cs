using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7AcadDotNet
{
    internal class Pedido
    {
        private double preco;
        private int quantEscolhida;
        private string formaDePagamento;
        public Produto produto;

        public void setPreco(double preco) 
        {
            this.preco = preco;
        }
        public double getPreco()
        {
            return preco;
        }
        public int getQuantEscolhida()
        {
            return quantEscolhida;
        }
        public void setQuantEscolhida(int quantEscolhida)
        {
            this.quantEscolhida = quantEscolhida;
        }
        public void setFormaDePagamento(string formaDePagamento)
        {
            this.formaDePagamento = formaDePagamento;
        }
        public string getFormaDePagamento()
        {
            return formaDePagamento;
        }
    }
}
