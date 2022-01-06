Console.WriteLine("Hello, World!");

// sealed - Impede que seja possível derivar uma classe
public sealed class Pagamento
{
    public Pagamento()
    {
        Console.WriteLine("Iniciando pagamento");
    }
}