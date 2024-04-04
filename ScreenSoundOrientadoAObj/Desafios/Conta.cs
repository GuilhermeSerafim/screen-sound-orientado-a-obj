class Conta
{
    public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        Limite = limite;
    }
    public Titular Titular { get; }
    public int Agencia { get; }
    public int NumeroDaConta { get; }
    public double Saldo { get; }
    public double Limite { get; }

    private string InformacoesDaConta => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações da conta");
        Console.WriteLine(InformacoesDaConta);
        Console.WriteLine("\nInformações do Titular");
        Console.WriteLine(Titular.InformacoesDoTitular);
    }
}