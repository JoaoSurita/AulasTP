Fornecedor forn1 = new Fornecedor("Empresa1", "11111111");
Produto prod1 = new Produto("Produto1", 10.20);
Categoria cat1 = new Categoria("Categoria1");

// Bilateral produto->fornecedor
prod1.Fornecedores.Add(forn1);

// Agregação Unilateral
prod1.CategoriaProduto = cat1;

// Associação Bilateral fornecedor->produto
Fornecedor forn2 = new Fornecedor("Empresa2", "22222222");
Produto prod2 = new Produto("Produto2", 15.50);
Produto prod3 = new Produto("Produto3", 100);

forn2.Produtos.Add(prod2);
forn2.Produtos.Add(prod3);

Console.WriteLine($"Nome: {prod1.Nome}\n Preço: {prod1.Preco}\n Categoria: {prod1.CategoriaProduto.Descritivo}");
foreach (var dado in prod1.Fornecedores)
{
    Console.WriteLine($"Razão Social: {dado.RazaoSocial}\n CNPJ: {dado.Cnpj}");
}

Console.WriteLine("Outro lado do Bilateral");
Console.WriteLine($"Razão Social: {forn2.RazaoSocial}\n CNPJ: {forn2.Cnpj}");
foreach (var dado in forn2.Produtos)
{
    Console.WriteLine($"Nome: {dado.Nome} - Preço: {dado.Preco}");
}

public class Produto
{
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string? Nome { get; set; };
    public double Preco { get; set; };
    public Categoria CategoriaProduto { get; set; }
    public List<Fornecedor> Fornecedores = new List<Fornecedor>();
}

public class Categoria
{
    public Categoria(string descritivo)
    {
        Descritivo = descritivo;
    }
    public string? Descritivo { get; set; }
}

public class Fornecedor
{
    public Fornecedor(string razaoSocial, string cnpj)
    {
        RazaoSocial = razaoSocial;
        Cnpj = cnpj;
    }
    public string? RazaoSocial { get; set; }
    public string? Cnpj { get; set; }
    public List<Produto> Produtos = new List<Produto>();
}