using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2.Exercicio_3
{


    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }


        public virtual void Acelerar()
        {
            Console.WriteLine("O veículo acelerou");
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca do veiculo: {Marca}, Modelo do veiculo: {Modelo}");
        }
    }

    public class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("O carro acelerou");
        }

        public void AbrirPorta()
        {
            Console.WriteLine($"as {NumeroDePortas} portas abriram");
        }
    }
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("A moto aacelerou");
        }
        public void Empinar()
        {
            Console.WriteLine("A moto está empinando!");
        }
    }
}
