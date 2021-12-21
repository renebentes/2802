var pagamento = new Pagamento(DateTime.Now);

Console.WriteLine("Hello, World!");

// private - Visível apenas dentro da classe de definição
// protected - Visível pela classe de definição e suas filhas
// internal - Visível para um mesmo Assembly
// public - Visível para tudo
public class Pagamento
{
    // Propriedades - Permite interação antes de obter ou atribuir valor
    public Pagamento(DateTime vencimento)
    {
        Vencimento = vencimento;
    }
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
    public virtual void Pagar() { }

    // Sobrecarga
    public void Pagar(string numero) { }
}

public class PagamentoCartao : Pagamento
{
    public PagamentoCartao(DateTime vencimento)
    : base(vencimento)
    {

    }
    // Sobrescrita
    public override void Pagar()
    {
        base.Pagar();
    }
}

// Tipos Complexos - classes ou structs
public struct Address
{
    string ZipCode;
}