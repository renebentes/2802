var person = new Person();
var payment = new Payment();
var subscription = new Subscription();
var context = new DataContext<Person, Payment, Subscription>();
context.Save(person);
context.Save(payment);
context.Save(subscription);

// Limitando tipos aceitos
class DataContext<TPerson, TPayment, TSubscription>
    where TPerson : Person
    where TPayment : Payment
    where TSubscription : Subscription
{
    public void Save(TPerson entity) { }

    public void Save(TPayment entity) { }

    public void Save(TSubscription entity) { }
}

class Person { }

class Payment { }

class Subscription { }