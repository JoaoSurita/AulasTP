// Usando
using OrientacaoObj;

Produto prod1 = new Produto();
prod1.Nome = "Caderno";
prod1.Preco = 24.99;

Produto prod2 = new Produto("Lápis", 1.50);

// objeto prod1
Console.WriteLine("Nome: " + prod1.Nome);
Console.WriteLine($"Preço: {prod1.Preco}");

// objeto prod2
Console.WriteLine("Nome: " + prod2.Nome);
Console.WriteLine($"Preço: {prod2.Preco}");

// objeto Produto2
Produto2 prod3 = new Produto2("Borracha", 4.50, 100);
prod3.Exibir();

// Declarando
public class Produto
{

    public Produto() { }
    // Método Constutor
    public Produto(string nome, double Preco)
    {
        Nome = nome;
        // Caso coloque o atributo igual o nome do parâmetro
        this.Preco = Preco;
    }
    public string? Nome { get; set; }
    public double Preco { get; set; }
}
