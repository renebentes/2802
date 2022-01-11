var pessoaA = new Pessoa(1, "Rene");
var pessoaB = new Pessoa(1, "Rene");

Console.WriteLine(pessoaA.Equals(pessoaB));

class Pessoa : IEquatable<Pessoa>
{
    public Pessoa(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public int Id { get; set; }
    public string Nome { get; set; }

    public bool Equals(Pessoa? other) => Id == other?.Id;
}