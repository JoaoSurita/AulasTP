public class Equipamento
{
    public Equipamento(string nome, DateTime datafabricacao)
    {
        Nome = nome;
        DataFabricacao = datafabricacao;
    }
    public string Nome { get; set; }
    public DateTime DataFabricacao { get; set; }
}

public class Maquina : Equipamento
{
    public Maquina(string nome, DateTime dataFabricacao, string modelo, string horaoperacao) : base(nome, dataFabricacao)
    {
        Modelo = modelo;
        HoraOperacao = horaoperacao;
    }
    public string Modelo { get; set; }
    public string HoraOperacao { get; set; }
    public Guid NumeroSerie { get; } = Guid.NewGuid();

    private string _observacao;
    public string Observacao
    {
        set { _observacao = value; }
    }
}

public class Fabrica
{
    public Fabrica(string nome)
    {
        Nome = nome;
        Maquinas = new List<Maquina>();
    }

    public string Nome { get; set; }
    public ICollection<Maquina> Maquinas { get; set; }

    public void AdicionarMaquina(Maquina maquina)
    {
        Maquinas.Add(maquina);
    }
    public void ListarMaquinas()
    {
        foreach (var m in Maquinas)
        {
            Console.WriteLine($"Nome: {m.Nome}, Modelo: {m.Modelo}, Data: {m.DataFabricacao:dd/MM/yyyy}, Série: {m.NumeroSerie}");
        }
    }
    public Maquina BuscarMaquinaPorModelo(string modelo)
    {
        return Maquinas.FirstOrDefault(m => m.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));
    }
}

public class Operador
{
    public Operador(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public async Task OperarMaquinaAsync(Fabrica fabrica, string modelo)
    {
        Console.WriteLine($"{Nome} está tentando operar a máquina modelo {modelo}");
        await Task.Delay(2000);

        var maquina = fabrica.BuscarMaquinaPorModelo(modelo);

        if (maquina == null)
        {
            throw new MaquinaNaoEncontradaException($"Máquina Modelo {modelo} não encontrada na Fábrica {fabrica.Nome}");
        }

        Console.WriteLine($"{Nome} agora está operando a máquina modelo {maquina.Modelo}");
        await Task.Delay(3000);
    }
}

public class MaquinaNaoEncontradaException : Exception
{
    public MaquinaNaoEncontradaException(string message) : base(message) { }
}

class Program
{
    static async Task Main(string[] args)
    {
        Fabrica minhaFabrica = new Fabrica("Industrial Brasil");

        Maquina m1 = new Maquina("Prensa 01", DateTime.Now, "CNC-2024", "08:00-18:00");
        minhaFabrica.AdicionarMaquina(m1);

        Operador op = new Operador("Ricardo");

        try
        {
            await op.OperarMaquinaAsync(minhaFabrica, "CNC-2024");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro: {ex.Message}");
        }
    }
}