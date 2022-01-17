static void RealizarPagamento(double valor) => Console.WriteLine($"Pago o valor de {valor}");

var pagar = new Pagamento.Pagar(RealizarPagamento);
pagar(25);

class Pagamento
{
    public delegate void Pagar(double valor);
}