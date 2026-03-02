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