using (var pagamento = new Pagamento()) { }

Console.WriteLine("Hello, World!");
public class Pagamento : IDisposable
{
    public Pagamento()
    {
        Console.WriteLine("Iniciando pagamento");
    }

    public void Dispose()
    {
        Console.WriteLine("Finalizando pagamento");
    }
}