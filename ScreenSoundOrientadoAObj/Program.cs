//Musica musica1 = new Musica();
//musica1.Nome = "Wonderful Life";
//musica1.Artista = "Bring Me The Horizon";
//musica1.Duracao = 273;
//musica1.Disponivel = true;

//Musica musica2 = new Musica();
//musica2.Nome = "Metallica";
//musica2.Artista = "Enter Sandman";
//musica2.Duracao = 310;
//musica2.Disponivel = false;

//musica1.ExibirFichaTécnica();
//musica2.ExibirFichaTécnica();

// Desafio 1
//ContaBancaria contaBancaria1 =  new ContaBancaria();
//contaBancaria1.numIndicador = 1;
//contaBancaria1.titular = "Guiler";
//contaBancaria1.saldo = 1200000.50;
//contaBancaria1.senha = "DarkCat!203";
//contaBancaria1.ExibirInformacoesDaConta();

// Desafio 2
//Carro carro1 = new Carro();
//carro1.Acelerar();
//carro1.Buzinando();
//carro1.Freiar();

// Desafio 3
//Carro carro =  new Carro();
//carro.AnoDoCarro = 2025;
//carro.Preco = 22.2;
//carro.Modelo = "Fuscão Preto";
//carro.Fabricante = "Airton Senna";
//carro.ExibirFichaDoCarro();


//Album albumDoQueen = new Album();
//albumDoQueen.Nome = "A night at the opera";

//Musica musica1 = new Musica();
//musica1.Nome = "Love of my life";
//musica1.Duracao = 213;

//Musica musica2 =  new Musica();
//musica2.Nome = "Bohemian Rhapsody";
//musica2.Duracao = 354;

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//albumDoQueen.ExibirMusicasDoAlbum();

//// Desafio prático (perdi as contas)
//Titular guiler = new Titular();
//guiler.Cpf = "13213-123";
//guiler.Nome = "Guilherme";
//guiler.Endereco = "Rua camasati";
//Conta contaGui = new Conta();
//contaGui.Titular = guiler;
//contaGui.Agencia = 0001;
//contaGui.NumeroDaConta = 1;
//contaGui.Saldo = 0.10;
//contaGui.Limite = 1111111111000000000000.10;
//contaGui.ExibirInformacoes(); 


//// Desafio prático - Estoque de produtos
//Produto produto = new Produto();
//produto.Nome = "Leite";
//produto.Marca = "Leitosa";
//produto.Preco = -2;
//produto.Estoque = 2;
//Produto produto2 = new Produto();
//produto2.Nome = "Faca";
//produto2.Marca = "Afiada";
//produto2.Preco = 10.10;
//produto2.Estoque = 2;



//EstoqueDeProdutos estoqueDeProdutos = new EstoqueDeProdutos();
//estoqueDeProdutos.AdicionarProduto(produto);
//estoqueDeProdutos.AdicionarProduto(produto2);
//estoqueDeProdutos.ExibirProdutos();

// Desafio da Escola
// Inicialização simplicaficada
Aluno aluno1 = new Aluno
{
    Nome = "Gui",
    Idade = 19,
    Notas = new List<double> { 9, 10, 8}
};
Aluno aluno2 = new Aluno
{
    Nome = "Theus",
    Idade = 19,
    Notas = new List<double> { 9, 6, 8}
};

Disciplina disciplina = new Disciplina
{
    NomeDisciplina = "Matemática"
};
disciplina.AdicionarAluno(aluno1);
disciplina.AdicionarAluno(aluno2);
disciplina.MostrarAlunosDisciplina();
