var pagamento = new Pagamento();

Console.WriteLine("Hello, World!");

// private - Visível apenas dentro da classe de definição
// protected - Visível pela classe de definição e suas filhas
// internal - Visível para um mesmo Assembly
// public - Visível para tudo
public class Pagamento
{
    // Propriedades - Permite interação antes de obter ou atribuir valor
    public DateTime Vencimento { get; set; }
    public DateTime DataPagamento { get; private set; }
    private DateTime _dataAbertura;
    public DateTime DataAbertura
    {
        get { return _dataAbertura; }
        set { _dataAbertura = value; }
    }

    // Variáveis - Acesso direto para obter e atribuir valor
    Address BillingAddress;

    // Métodos
    private void Pagar() { }
}

// Tipos Complexos - classes ou structs
public struct Address
{
    string ZipCode;
}