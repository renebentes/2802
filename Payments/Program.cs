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
    Address BillingAddress;

    // Métodos
    private void Pagar() { }
}

// Tipos Complexos - classes ou structs
public struct Address
{
    string ZipCode;
}