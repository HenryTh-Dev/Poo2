using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2.exercicio_7
{
    internal class Program
    {
        static void Main()
        {

            List<Transacao> transacoes = new List<Transacao>
        {
            new Transacao("Venda de produto A", 1000m),
            new Transacao("Compra de material", -500m),
            new Transacao("Recebimento de cliente", 700m),
            new Transacao("Despesa com manutenção", -200m)
        };


            RelatorioFinanceiro relatorio = new RelatorioFinanceiro();
            relatorio.ExibirRelatorio(transacoes);
        }

    }
}
