Console.WriteLine("Usando evento");
Pedido pedido = new Pedido();
// Registrar as classes assinantes
pedido.onCriarPedido += EnviarEmail.email;
pedido.onCriarPedido += EnviarSMS.sms;

pedido.criarPedido();
Console.WriteLine("Fim do Pedido");

Console.ReadLine();
delegate void PedidoEvent();

class Pedido
{
    public event PedidoEvent? onCriarPedido;
    public void criarPedido()
    {
        Console.WriteLine("Iniciando o criar pedido");
        if (onCriarPedido != null)
        {
            onCriarPedido();
        }
    }
}

class EnviarEmail
{
    public static void email()
    {
        Console.WriteLine("Email Enviado");
    }
}

class EnviarSMS
{
    public static void sms()
    {
        Console.WriteLine("SMS Enviado");
    }
}