var payments = new List<Payment>();
payments.Add(new Payment(1));
payments.Add(new Payment(2));
payments.Add(new Payment(3));
payments.Add(new Payment(4));
payments.Add(new Payment(5));
payments.Add(new Payment(6));

foreach (var p in payments)
{
    Console.WriteLine(p.Id);
}

// Adiciona uma lista à lista
var paidPayments = new List<Payment>();
paidPayments.AddRange(payments);

// Pesquisar um elemento - algumas formas
// .Where - Retorna um IEnumerable
// .First/.FirstOrDefault - Retorna o elemento, o primeiro dá erro se não achar
var payment = payments.FirstOrDefault(x => x.Id == 3);
Console.WriteLine(payment);

// Removendo elementos
// .RemoveRange
// .Clear
payments.Remove(payment);

// .Skip - Pula a quantidade de itens informada
// .Take - Retorna a quantidade de itens informada

class Payment
{
    public int Id { get; set; }

    public Payment(int id)
    {
        Id = id;
    }
}