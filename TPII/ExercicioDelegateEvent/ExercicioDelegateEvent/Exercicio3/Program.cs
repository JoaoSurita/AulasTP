Botao btn = new Botao();
ContadorCliques contador = new ContadorCliques();
btn.Clique += contador.SomarClique;

btn.SimularClique();
btn.SimularClique();

delegate void CliqueEvent();

class Botao
{
    public event CliqueEvent? Clique;
    public void SimularClique() => Clique?.Invoke();
}

class ContadorCliques
{
    private int qtd = 0;
    public void SomarClique()
    {
        qtd++;
        Console.WriteLine($"Quantidade de cliques: {qtd}");
    }
}