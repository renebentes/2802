var person = new Person();
var payment = new Payment();
var context = new DataContext<Person>();
context.Save(person);

// Erro - Cada instância aceita um tipo por vez
context.Save(payment);

// É possível ter múltiplos tipos
// class DataContext<TPerson, TPayment>
class DataContext<T>
{
    public void Save(T entity) { }
}

class Person { }

class Payment { }

class Subscription { }