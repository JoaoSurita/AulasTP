try
{
    Console.WriteLine("Digite o Dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o Divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    var resultado = dividendo / divisor;
    Console.WriteLine($"O resultado de {dividendo}/{divisor} = {resultado}");
}
catch (FormatException)
{
    Console.WriteLine("Entre com um valor inteiro");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine($"Entre com um valor inteiro - when:{ex.Message}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Divisor não pode ser zero");
}
catch (Exception ex)
{
    Console.WriteLine($"Problema na divisão: {ex.Message}");
}
finally
{
    Console.WriteLine("Divisão concluída");
}