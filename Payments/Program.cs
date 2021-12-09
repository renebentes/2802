// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Pagamento
{
    // Propriedades
    DateTime Vencimento;

    // Métodos
    void Pagar()
    {
        ConsultarSaldoDoCartao("12345");
    }

    public void ConsultarSaldoDoCartao(string numero) { }
}
