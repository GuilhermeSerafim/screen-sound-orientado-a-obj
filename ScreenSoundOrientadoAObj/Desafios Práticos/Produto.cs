// Desafio 5
class Produto
{
    public string Nome { get; set; }
    private int _estoque;
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
                _preco = 0;
            }
        }
    }
    public int Estoque
    {
        get => _estoque;
        set
        {
            if (value > 0)
                _estoque = value;
            else
            _estoque = 0;

        }
    }

    public string Descricao => $"{this.Nome} {this.Marca} - {(this.Preco > 0 ? this.Preco : "Preço inválido")} - Quantidade: {this.Estoque}"; // Expressão lambda

    public void MostrarProduto()
    {
        Console.WriteLine(Descricao);
    }
}