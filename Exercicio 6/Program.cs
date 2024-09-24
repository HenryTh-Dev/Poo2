namespace Poo2
{
    internal class Program
    {
        static void Main()
        {
            ControleEstoque estoque = new ControleEstoque();

            estoque.AdicionarItem("caixa", 200);
            estoque.AdicionarItem("papel", 300);
            estoque.AdicionarItem("Monitor", 5);

            estoque.ListarItens();


            estoque.RemoverItem("caixa", 5);
            estoque.RemoverItem("Monitor", 10);
            estoque.RemoverItem("dvd", 10);

            estoque.ListarItens();
        }
    }
}
