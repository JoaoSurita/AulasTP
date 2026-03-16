public class Fabrica
{
    public Fabrica(string? nome)
    {
        Nome = nome;
    }
    public string? Nome { get; set; }

    public void AdicionarMaquina()
    {

    }
    public void ListaMaquina()
    {

    }
    public void BuscarMaquinaPorModelo()
    {

    }
}

public class Operador
{
    public Operador(string? nome)
    {
        Nome = nome;
    }
    public string? Nome { get; set; }

    public void OperarMaquinaAsync()
    {

    }
}

public class Maquina
{
    public Maquina(string? modelo, string? horaoperacao, Guid numeroserie, string? observacao)
    {
        Modelo = modelo;
        HoraOperacao = horaoperacao;
        NumeroSerie = numeroserie;
        _observacao = observacao;
    }
    public string? Modelo { get; set; }
    public string? HoraOperacao { get; set; }
    public Guid NumeroSerie { get; private set; }
    private string? _observacao;
    public string? Observacao
    {
        set { _observacao = value; }
    }
}

public class Equipamento
{
    public Equipamento(string? nome, DateTime datafabricacao)
    {
        Nome = nome;
        DataFabricacao = datafabricacao;
    }
    public string? Nome { get; set; }
    public DateTime DataFabricacao { get; set; }
}