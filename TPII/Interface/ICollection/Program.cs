// ICollection herda de IEnumerable e permite alteração na coleção
ICollection<string> nomes = new List<string> { "Selma", "Paulo" };
nomes?.Add("Maria");
string[] array = new string[nomes.Count];
nomes.CopyTo(array, 0);

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

foreach (var nome in array)
{
    Console.WriteLine(nome);
}