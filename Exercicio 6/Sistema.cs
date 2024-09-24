using System;
using System.Collections.Generic;


public class ItemEstoque
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public ItemEstoque(string nome, int quantidade)
    {
        Nome = nome;
        Quantidade = quantidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Item: {Nome}, Quantidade: {Quantidade}");
    }
}

public class ControleEstoque
{
    private List<ItemEstoque> _itensEstoque;


    public ControleEstoque()
    {
        _itensEstoque = new List<ItemEstoque>();
    }

    public void AdicionarItem(string nome, int quantidade)
    {
            _itensEstoque.Add(new ItemEstoque(nome, quantidade));
    }

    public void RemoverItem(string nome, int quantidade)
    {
        ItemEstoque item = _itensEstoque.Find(i => i.Nome == nome);

        if (item == null)
        {
            Console.WriteLine($"O item '{nome}' não está no estoque.");
            return;
        }

        _itensEstoque.Remove(item);
        Console.WriteLine($"O item '{nome}' foi removido completamente do estoque.");
        
    }


    public void ListarItens()
    {
        if (_itensEstoque.Count == 0)
        {
            Console.WriteLine("O estoque está vazio.");
            return;
        }

        Console.WriteLine("Itens em estoque:");
        foreach (ItemEstoque item in _itensEstoque)
        {
            item.ExibirInformacoes();
        }
    }
}