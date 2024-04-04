using Microsoft.VisualBasic;

class Restaurante
{
    public string Nome { get; set; }
    public int CPFCNPj { get; set; }
    public DateTime DataReserva { get; set; }

    public void MensagemFinal()
    {
        Console.WriteLine($"Obrigado pela preferência, {Nome}!");
        Console.WriteLine($"Sua reserva foi feita para o dia {DataReserva:d}.");
    }
    public void IniciarReserva()
    {
        Console.WriteLine(@"Bem vindos ao 
        ░█████╗░██╗░░██╗███████╗███████╗██╗░██████╗  ██╗░░██╗░█████╗░██╗░░░██╗███████╗███╗░░██╗
        ██╔══██╗██║░░██║██╔════╝██╔════╝╚█║██╔════╝  ██║░░██║██╔══██╗██║░░░██║██╔════╝████╗░██║
        ██║░░╚═╝███████║█████╗░░█████╗░░░╚╝╚█████╗░  ███████║███████║╚██╗░██╔╝█████╗░░██╔██╗██║
        ██║░░██╗██╔══██║██╔══╝░░██╔══╝░░░░░░╚═══██╗  ██╔══██║██╔══██║░╚████╔╝░██╔══╝░░██║╚████║
        ╚█████╔╝██║░░██║███████╗██║░░░░░░░░██████╔╝  ██║░░██║██║░░██║░░╚██╔╝░░███████╗██║░╚███║
        ░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░░░░╚═════╝░  ╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝");
        Console.WriteLine();

        Console.WriteLine("Faça sua reserva: \n");

        Console.Write("Informe seu nome: ");
        Nome = Console.ReadLine()!;
        Console.WriteLine();

        Console.Write("Informe seu CPF/CNPJ: ");
        CPFCNPj = int.Parse(Console.ReadLine()!);
        Console.WriteLine();


        Console.Write("Informe a data da reserva (DD/MM/AAAA): ");
        DataReserva = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null);
        Console.WriteLine();


        Console.WriteLine("Dados registrados com sucesso!");
        Thread.Sleep(1000);
        Console.Clear();

        // Reservar de mesas
        Mesas mesas = new Mesas();
        Console.WriteLine("Quantas mesas gostaria de reservar?");
        mesas.MesasASeremReservadas = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Gostaria de reservar na sala premium de mesas de vidro? Digite 'sim' ou 'não'");
        mesas.MesasDeVidro = Console.ReadLine() == "sim" ? true : false;
        Console.WriteLine("Reserva de mesas realizada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();

        // Cardápio
        Cardapio cardapio = new Cardapio();
        Console.WriteLine("Gostaria de fazer reserva de algum item do cardápio? Digite 'sim' ou 'não'");
        cardapio.reservaDeCardapio = Console.ReadLine() == "sim" ? true : false;
        if (cardapio.reservaDeCardapio)
        {
            Console.WriteLine("Qual seria o nome do pedido");
            cardapio.NomePedido = Console.ReadLine()!;
            Console.WriteLine("Alguma preferência em relação ao pedido?");
            cardapio.DescPedido = Console.ReadLine()!;
        }
        Console.WriteLine("Reserva finalizada!");
        Thread.Sleep(2000);
        Console.Clear();
        MensagemFinal();
    }
}