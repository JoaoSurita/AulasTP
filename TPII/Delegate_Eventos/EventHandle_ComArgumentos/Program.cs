Console.WriteLine("Usando evento");
Pedido pedido = new Pedido();
// Registrar as classes assinantes
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;
pedido.criarPedido("joao@gmail.com", "14999999999");

Console.WriteLine("Fim do Pedido");

Console.ReadLine();

class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

class Pedido
{
    public event EventHandler<PedidoEventArgs>? OnCriarPedido;
    public void criarPedido(string email, string telefone)
    {
        Console.WriteLine("Iniciando o criar pedido");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs
            {
                Email = email,
                Telefone = telefone
            });
        }
    }
}

class EnviarEmail
{
    public static void email(Object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Email enviado para: {e.Email}");
    }
}

class EnviarSMS
{
    public static void sms(Object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"SMS enviado para: {e.Telefone}");
    }
}