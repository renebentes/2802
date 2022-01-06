Console.WriteLine("Hello, World!");

public interface IPagamento
{
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
}

public abstract class Pagamento : IPagamento
{
    public DateTime Vencimento { get; set; }

    public virtual void Pagar(double valor)
    {
        throw new NotImplementedException();
    }

    class PagamentoBoleto : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    class PagamentoCartaoCredito : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    class PagamentoApplePay : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }
}