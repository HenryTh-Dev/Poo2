using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2.Models
{
    internal class Fornecedor
    {

        private string _nome;
        private double _valorMinimoProduto;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double ValorMinimoProduto
        {
            get { return _valorMinimoProduto; }
            set
            {
                if (value >= 0)
                {
                    _valorMinimoProduto = value;
                }
                else
                {
                    Console.WriteLine("O valor mínimo do produto não pode ser meor que 0.");
                }
            }
        }

    }
}
