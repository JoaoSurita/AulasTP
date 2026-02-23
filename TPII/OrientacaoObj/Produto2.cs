using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObj
{
    class Produto2
    {

        public Produto2(string? nome, double preco, int estoqueminimo)
        {
            Nome = nome;
            Preco = preco;
            EstoqueMinimo = estoqueminimo;
        }

        public void Exibir()
        {
            Console.WriteLine($"{Nome}\n{Preco.ToString("c")}\n{PrecoFinal.ToString("c")}\n{minimo}");
        }

        private string? nome; 
        public string? Nome
        {
            get { return nome?.ToUpper(); }
            set { nome = value; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set
            {
                if (preco < 5.00)
                {
                    preco = 5.00;
                }
                else
                {
                    preco = value;
                }
            }
        }

        private double desconto = 0.05;
        public double Desconto
        {
            get { return desconto; }
        }
        public double PrecoFinal
        {
            get{ return Preco - (Preco * Desconto); }
        }

        private int minimo;
        public int EstoqueMinimo
        {
            set{ minimo = value; }
        }
    }
}
