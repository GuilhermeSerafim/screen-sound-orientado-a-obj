// Desafio 6
class Titular
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
    public string InformacoesDoTitular =>
        $"Nome do titular: {Nome}\nCpf do titular: {Cpf}\nEndereco do titular: {Endereco}";

}