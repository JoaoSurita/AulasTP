List<int> listaNumeros = new List<int> { 1, 2, 3, 4, 5, 6 };

int somaImpares = listaNumeros.SomarImpares();

Console.WriteLine($"Soma dos ímpares: {somaImpares}");

public static class ListExtensions
{
    public static int SomarImpares(this List<int> lista)
    {
        return lista.Where(n => n % 2 != 0).Sum();
    }
}