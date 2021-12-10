var pagamentoBoleto = new PagamentoBoleto
{
    Vencimento = DateTime.Now,
    NumeroBoleto = "12345"
};

pagamentoBoleto.Pagar();

var pagamento = new Pagamento
{
    Vencimento = DateTime.Now
};

pagamento.Pagar();

Console.WriteLine("Hello, World!");

class Pagamento
{
    // Propriedades
    public DateTime Vencimento;

    // Métodos
    public virtual void Pagar() { }

    public override string ToString() => Vencimento.ToString("dd/MM/YYYY");
}

class PagamentoBoleto : Pagamento
{
    public string NumeroBoleto;

    public override void Pagar()
    {
        // Regra para boleto
    }
}

class PagamentoCartaoDeCredito : Pagamento
{
    public string Numero;
}
