namespace DesafioFundamentos;

public static class Input
{
    public static decimal LerDecimal(string mensagem)
    {
        try
        {
            Console.Write(mensagem);
            return Convert.ToDecimal(Console.ReadLine());
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico.\n");
            return LerDecimal(mensagem);
        }
    }

    public static string LerString(string mensagem)
    {
        try
        {
            Console.Write(mensagem);
            var input = Console.ReadLine() ?? throw new Exception();
            return input;
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Entrada inválida. Por favor, insira um texto válido.\n");
            return LerString(mensagem);
        }
    }

    public static int LerInt(string mensagem)
    {
        try
        {
            Console.Write(mensagem);
            return Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.\n");
            return LerInt(mensagem);
        }
    }
}