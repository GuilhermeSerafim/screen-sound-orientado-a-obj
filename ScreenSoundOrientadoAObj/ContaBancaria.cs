// Desafio 1
class ContaBancaria
{
    public int NumIndicador { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibirInformacoesDaConta()
    {
        Console.WriteLine($"Número Indicador: {NumIndicador}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo da conta: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }
}