namespace DesafioFundamentos;

public static class Menu
{
    private static Estacionamento? Es;

    public static void ConfigInicial()
    {
        Console.WriteLine("Olá, bem-vindo ao sistema de estacionamento!");
        decimal precoPorHora = Input.LerDecimal("Por favor, insira o preço por hora: ");
        decimal precoInicial = Input.LerDecimal("Por favor, insira o preço inicial: ");
        Es = new Estacionamento(precoInicial, precoPorHora);

        Console.Clear();
    }

    public static void ExibirMenu()
    {
        ConfigInicial();
        if (Es == null)
        {
            Console.WriteLine("Sistema não foi configurado corretamente, por favor reinicie o programa.");
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==================================================================");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
            Console.WriteLine("==================================================================");

            switch (Input.LerInt("Por favor, escolha uma opção: "))
            {
                case 1:
                    Es.AdicionarVeiculo();
                    break;
                case 2:
                    Es.RemoverVeiculo();
                    break;
                case 3:
                    Es.ListarVeiculos();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}