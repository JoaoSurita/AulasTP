List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa { Nome = "João", Idade = 17 },
    new Pessoa { Nome = "Maria", Idade = 22 },
    new Pessoa { Nome = "Carlos", Idade = 30 }
};

// Pessoas com idade maior que 18
var maioresDeIdade = pessoas.Where(p => p.Idade > 18).ToList();

// Nomes das pessoas ordenados alfabeticamente
var nomesOrdenados = pessoas.OrderBy(p => p.Nome).Select(p => p.Nome).ToList();

Console.WriteLine("Maiores de Idade:");
foreach (var p in maioresDeIdade)
{
    Console.WriteLine($"{p.Nome} ({p.Idade} anos)");
}

Console.WriteLine("Nomes em ordem alfabética:");
foreach (var nome in nomesOrdenados)
{
    Console.WriteLine(nome);
}
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}
