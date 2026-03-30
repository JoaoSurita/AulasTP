ContaBancaria conta = new ContaBancaria(300.00m);

try
{
    conta.Sacar("100");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro de Saldo: {ex.Message}");
}

try
{
    conta.Sacar("500");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro de Saldo: {ex.Message}");
}

try
{
    conta.Sacar("feijao com farinha");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}

public class ContaBancaria
{
    public decimal Saldo { get; set; }

    public ContaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Sacar(string valorTexto)
    {
        try
        {
            decimal valor = decimal.Parse(valorTexto);
            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException($"Saldo Insuficiente. Saldo atual: R${Saldo}\nTentativa de saque no valor de R${valor}");
            }
            Saldo -= valor;
            Console.WriteLine($"Saldo atual: R${Saldo}");
        }
        catch (Exception fe)
        {
            throw new ApplicationException("Erro ao converter o valor do saque", fe);
        }
        finally
        {
            Console.WriteLine("Fim do saque");
        }
    }
}

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() { }
    public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
    public SaldoInsuficienteException(string mensagem, Exception innerException) : base(mensagem, innerException) { }
}