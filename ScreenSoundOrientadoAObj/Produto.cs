// Desafio 5
class Produto
{
    public string Nome { get; set; }
    private int _estoque;
    public int Estoque
    {
        get { return _estoque; } 
        set 
        { 
            if(value > 0)
            {
                _estoque = value;
            } else
            {
                Console.WriteLine("O estoque deve ser maior que 0");
            }
        }
    }
    public string Marca { get; set; }
    private double _preco;
    public double Preco
    {
        get { return _preco; }
        set
        {
            if (value > 0)
            {
                _preco = value;
            }
            else
            {
                Console.WriteLine("O preço deve ser maior que 0");
            }
        }
    }
    public string DescricaoDetalhadaProduto => $" Temos {Estoque} de estoque produto {Nome} da marca {Marca} no preco {Preco}";

    public void MostrarProduto()
    {
        Console.WriteLine(DescricaoDetalhadaProduto);
    }
}