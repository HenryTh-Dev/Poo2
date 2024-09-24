using System;
using System.Collections.Generic;


public class Transacao
{
    public string Descricao { get; set; }
    public decimal Valor { get; set; }


    public Transacao(string descricao, decimal valor)
    {
        Descricao = descricao;
        Valor = valor;
    }
}


public class RelatorioFinanceiro
{

    public decimal CalcularSaldoFinal(List<Transacao> transacoes)
    {
        decimal saldoFinal = 0;

        foreach (var transacao in transacoes)
        {
            saldoFinal += transacao.Valor;
        }

        return saldoFinal;
    }


    public void ExibirRelatorio(List<Transacao> transacoes)
    {
        Console.WriteLine("Relatório de Transações:");
        foreach (var transacao in transacoes)
        {
            Console.WriteLine($"{transacao.Descricao}: {transacao.Valor:C}");
        }

        decimal saldoFinal = CalcularSaldoFinal(transacoes);
        Console.WriteLine($"\nSaldo Final: {saldoFinal:C}");
    }
}
