var cliente1 = new Cliente { Nome = "João", Cpf = "12345678901" };
var cliente2 = new Cliente { Nome = "Maria", Cpf = "45678912329" };

var p1 = new Produto { Nome = "Monitor", Preco = 600.00 };
var p2 = new Produto { Nome = "Mouse", Preco = 50.00 };

var listaPedidos = new List<Pedido>
{
    new Pedido { Cliente = cliente1, Produto = p1, Quantidade = 1, DataPedido = DateTime.Now },
    new Pedido { Cliente = cliente1, Produto = p2, Quantidade = 2, DataPedido = DateTime.Now },
    new Pedido { Cliente = cliente2, Produto = p1, Quantidade = 2, DataPedido = DateTime.Now }
};

var pedidosAgrupados = listaPedidos.GroupBy(p => p.Cliente.Nome);

foreach (var grupo in pedidosAgrupados)
{
    Console.WriteLine($"Cliente: {grupo.Key}");
    foreach (var pedido in grupo)
    {
        Console.WriteLine($"- {pedido.Produto.Nome} ({pedido.Quantidade}x)");
    }
}

// b. Trazer os nomes dos clientes que têm pedidos acima de R$ 500
var clientesPremium = listaPedidos
    .Where(p => p.ValorTotalPedido > 500)
    .Select(p => p.Cliente.Nome)
    .Distinct()
    .ToList();

// c. Calcular o valor total de pedidos por cliente
var totalPorCliente = listaPedidos
    .GroupBy(p => p.Cliente.Nome)
    .Select(g => new
    {
        Cliente = g.Key,
        TotalGeral = g.Sum(p => p.ValorTotalPedido)
    });

Console.WriteLine("Clientes com pedidos acima de R$ 500");
clientesPremium.ForEach(nome => Console.WriteLine($"Cliente Premium: {nome}"));

Console.WriteLine("Valor Total por Cliente");
foreach (var item in totalPorCliente)
{
    Console.WriteLine($"Cliente: {item.Cliente} | Total gasto: R$ {item.TotalGeral:F2}");
}

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

public class Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
}

public class Pedido
{
    public int Quantidade { get; set; }
    public DateTime DataPedido { get; set; }
    public Produto Produto { get; set; }
    public Cliente Cliente { get; set; }

    public double ValorTotalPedido => Quantidade * Produto.Preco;
}