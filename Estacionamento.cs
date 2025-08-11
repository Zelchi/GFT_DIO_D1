namespace DesafioFundamentos;

public class Estacionamento(decimal PrecoInicial, decimal PrecoPorHora)
{
    private readonly List<string> Veiculos = [];

    public void AdicionarVeiculo()
    {
        Console.Clear();
        Veiculos.Add(Input.LerString("Digite a placa do veículo para estacionar:"));
        Input.Await();
    }

    public void RemoverVeiculo()
    {
        Console.Clear();
        string placa = Input.LerString("Digite a placa do veículo para remover: ");
        if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            int horas = Input.LerInt("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            decimal valorTotal = PrecoInicial + (PrecoPorHora * horas);
            Veiculos.Remove(placa);
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
        Input.Await();
    }

    public void ListarVeiculos()
    {
        Console.Clear();
        if (Veiculos.Count != 0)
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var v in Veiculos)
            {
                Console.WriteLine(v);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
        Input.Await();
    }
}