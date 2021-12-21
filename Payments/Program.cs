var pagamento = new Pagamento();

Console.WriteLine("Hello, World!");
public class Pagamento
{
    public Pagamento()
    {
        Console.WriteLine("Iniciando pagamento");
    }
}

// Disponível para a toda a aplicação
// Qualquer valor alterado serve para todos
public static class Settings
{
    public static string Url { get; set; }
}