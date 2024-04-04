// Desafio 2
class Carro
{
    public double Preco { get; set; }
    public string Modelo { get; set; }
    public string Fabricante{ get; set; }
    private int _anoDoCarro; // Convenção
    public int AnoDoCarro
    {
        get { return _anoDoCarro; }
        set
        {
            if (value >= 1900 && value <= DateTime.Now.Year) // Ano atual
            {
                _anoDoCarro = value;
            }
            else
            {
                Console.WriteLine("Ano inválido");
            }
        }
    }
    public string DescricaoDetalhada =>
        $"O carro {Modelo} fabricado em {AnoDoCarro} e do fabricante {Fabricante}";

    public void Acelerar()
    {
        Console.WriteLine("Acelerando");
    }
    public void Freiar()
    {
        Console.WriteLine("Freiando");
    }
    public void Buzinando()
    {
        Console.WriteLine("Buzinando");
    }

    public void ExibirFichaDoCarro()
    {
        Console.WriteLine(DescricaoDetalhada);
    }
}