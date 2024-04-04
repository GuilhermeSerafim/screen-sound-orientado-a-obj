// Desafio 6

class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    private string InformacoesDaConta => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações da conta");
        Console.WriteLine(InformacoesDaConta);
        Console.WriteLine("\nInformações do Titular");
        Console.WriteLine(Titular.InformacoesDoTitular);
    }
}