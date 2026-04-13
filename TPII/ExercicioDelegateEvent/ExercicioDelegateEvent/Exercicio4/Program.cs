Estoque est = new Estoque { NomeProduto = "Processador i9" };
est.EstoqueBaixo += AlertaSistema.Mensagem;
est.VerificarEstoque(3);

class EstoqueArgs : EventArgs
{
    public string Nome { get; set; }
    public int Qtd { get; set; }
}

class Estoque
{
    public string NomeProduto { get; set; } = "Produto";
    public event EventHandler<EstoqueArgs>? EstoqueBaixo;

    public void VerificarEstoque(int quantidade)
    {
        if (quantidade < 5)
        {
            EstoqueBaixo?.Invoke(this, new EstoqueArgs { Nome = NomeProduto, Qtd = quantidade });
        }
    }
}

class AlertaSistema
{
    public static void Mensagem(Object? sender, EstoqueArgs e)
    {
        Console.WriteLine($"ALERTA DE ESTOQUE: O produto {e.Nome} está com apenas {e.Qtd} unidades!");
    }
}