var pagamento = new Pagamento();

Console.WriteLine("Hello, World!");

// private - Visível apenas dentro da classe de definição
// protected - Visível pela classe de definição e suas filhas
// internal -  Visível para um mesmo Assembly
// public - Visível para tudo
public class Pagamento
{
    // Propriedades
    protected DateTime Vencimento;

    // Métodos
    private void Pagar() { }
}

class PagamentoBoleto : Pagamento
{
    public PagamentoBoleto()
    {
        Vencimento = DateTime.Now;
    }
}