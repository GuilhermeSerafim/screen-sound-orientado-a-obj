// Desafio 1
class ContaBancaria
{
    public int numIndicador;
    public string titular;
    public double saldo;
    public string senha;

    public void ExibirInformacoesDaConta()
    {
        Console.WriteLine($"Número Indicador: {numIndicador}");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo da conta: {saldo}");
        Console.WriteLine($"Senha: {senha}");
    }
}