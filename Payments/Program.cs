Console.WriteLine("Hello, World!");

public interface IPagamento
{
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
}

public class Pagamento : IPagamento
{
    public DateTime Vencimento { get; set; }

    public void Pagar(double valor)
    {
        throw new NotImplementedException();
    }
}