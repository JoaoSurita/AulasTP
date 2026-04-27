using System.Text.Json;
var caminho = "pessoas.json";
List<Pessoa> lista = new List<Pessoa>
{
    new Pessoa{Nome="Ana", Idade=28},
    new Pessoa{Nome="Carlos", Idade=21},
    new Pessoa{Nome="Sandra", Idade=19}
};

// serialização em arquivo
if (!File.Exists(caminho))
{
    string jsonString = JsonSerializer.Serialize(lista, new JsonSerializerOptions {WriteIndented = true});

    File.WriteAllText(caminho, jsonString);
    Console.WriteLine("Arquivo json gravado");
}

if (File.Exists(caminho))
{
    string conteudo = File.ReadAllText(caminho);
List<Pessoa> listaConteudo = JsonSerializer.Deserialize<List<Pessoa>>(conteudo);
    Console.WriteLine("Lista de Pessoas");
    foreach(var Pes in listaConteudo)
    {
        Console.WriteLine($"Nome:{Pes.Nome} - Idade:{Pes.Idade}");
    }
}

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // construtor padrão(Sem argumentos) obrigatório para a desserialização
    public Pessoa() { }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}