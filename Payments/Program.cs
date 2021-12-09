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
    public void Pagar()
    {
        ConsultarSaldoDoCartao("12345");
    }

    public void ConsultarSaldoDoCartao(string numero) { }
}

class PagamentoBoleto : Pagamento
{
    public string NumeroBoleto;
}

class PagamentoCartaoDeCredito : Pagamento
{
    public string Numero;
}
