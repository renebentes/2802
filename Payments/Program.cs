Console.WriteLine("Hello, World!");

// Upcast
var pessoa = new Pessoa();
pessoa = new PessoaFisica();
pessoa = new PessoaJuridica();

// Downcast
var pessoaFisica = new PessoaFisica();
pessoaFisica = (PessoaFisica)pessoa;

var pessoaJuridica = new PessoaJuridica();
pessoaJuridica = (PessoaJuridica)pessoa;

class Pessoa
{
    public string Nome { get; set; }
}

class PessoaFisica : Pessoa
{
    public string Cpf { get; set; }
}

class PessoaJuridica : Pessoa
{
    public string Cnpj { get; set; }
}