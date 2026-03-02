// List - Cresce dinamicamente, vários tipos

// Formas de criar uma List 
var lista = new List<string>();
List<int> lista2 = new();
var lista3 = new List<string>() { "Brasil", "Portugal", "Espanha" };

List<Carro> carros = new List<Carro>();

// Atribuindo Valores na List
lista.Add("Laranja");
carros.Add(new Carro("Chevrolet", "Vectra", 2000));
public class Carro
{
    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public int Ano { get; set; }
}