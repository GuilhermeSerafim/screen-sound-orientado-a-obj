class EstoqueDeProdutos
{
    private List<Produto> Produtos { get; set; } = new List<Produto>(); // Lista de produtos

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque\n");
    }

    public void ExibirProdutos()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }
        else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach (var produto in Produtos)
            {
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}