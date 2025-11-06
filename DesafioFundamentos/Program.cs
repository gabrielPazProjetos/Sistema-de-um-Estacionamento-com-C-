using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial;
decimal precoPorHora;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

while (true)
{
    Console.Write("Digite o preço inicial: ");
    if (decimal.TryParse(Console.ReadLine(), out precoInicial) && precoInicial >= 0)
        break;
    Console.WriteLine("Valor inválido. Tente novamente.");
}

while (true)
{
    Console.Write("Digite o preço por hora: ");
    if (decimal.TryParse(Console.ReadLine(), out precoPorHora) && precoPorHora >= 0)
        break;
    Console.WriteLine("Valor inválido. Tente novamente.");
}

var estacionamento = new Estacionamento(precoInicial, precoPorHora);

while (true)
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    Console.Write("Opção: ");
    string opcao = Console.ReadLine()?.Trim();

    switch (opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            Console.WriteLine("Encerrando o programa...");
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
