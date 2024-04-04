// Desafio 6
class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
    public string Nome { get; }
    public string Cpf { get; }
    public string Endereco { get; }
    public string InformacoesDoTitular =>
        $"Nome do titular: {Nome}\nCpf do titular: {Cpf}\nEndereco do titular: {Endereco}";

}