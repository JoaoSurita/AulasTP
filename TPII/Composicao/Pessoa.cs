using Composicao;

// Composição do lado de Pessoa(Bilateral) Pessoa->Celular
Pessoa pessoa1 = new Pessoa("Joao", 14, "999999999");
pessoa1.SetCelular(14, "988888888");
Console.WriteLine("Composição do lado do Todo(Pessoa-Celular)");
Console.WriteLine($"Nome: {pessoa1.Celulares}");
foreach (var dado in pessoa1.Celulares)
{
    Console.WriteLine($"({dado.DDD}) - {dado.Numero}");
}

// Composição do lado do Celular(Bilateral) Celular->Pessoa
Pessoa pessoa2 = new Pessoa("Paulo");
Celular cel1 = new Celular(14, "997777777", pessoa2);
Console.WriteLine("Composição do lado da Parte(Celular-Pessoa)");
Console.WriteLine($"Nome: {cel1.ProprietarioCelular.Nome} - Celular: ({cel1.DDD}){cel1.Numero}");

namespace Composicao
{
    class Pessoa
    {
        public Pessoa(string? nome, int ddd, string numero)
        {
            Nome = nome;
            Celulares.Add(new Celular(ddd, numero));
        }

        public void SetCelular(int ddd, string numero)
        {
            Celulares.Add(new Celular(ddd, numero));
        }

        public string? Nome { get; set; }
        public List<Celular> Celulares = new List<Celular>();
    }

    class Celular
    {
        public Celular(int ddd, string numero)
        {
            DDD = ddd;
            Numero = numero;
        }

        public Celular(int ddd, string numero, Pessoa pessoa)
        {
            DDD = ddd;
            Numero = numero;
            ProprietarioCelular = pessoa;
        }
        public int DDD { get; set; }
        public string Numero { get; set; }
        public Pessoa ProprietarioCelular { get; set; }
    }
}
