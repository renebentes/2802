var payment = new Payment();

// Com o var sempre teremos um objeto do tipo List
var payments = new List<Payment>();
payments.Add(payment);
payments.Remove(payment);

// Ao usar o tipo explícito, o objeto será limitado ao tipo
// definido. Só os métodos do tipo serão permitidos
IEnumerable<string> strings = new List<string>();

class Payment { }