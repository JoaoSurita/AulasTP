Console.WriteLine("Café da Manhã Sincrono");
cafeDaManha();
Console.WriteLine("Fim do Café da Manhã");

static void cafeDaManha()
{
    Console.WriteLine("Prepara o café");
    var cafe = PrepararCafe();
    Console.WriteLine("\nPreparar o pão");
    var pao = PrepararPao();
    ServirCafe(cafe, pao);
}

static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\nServindo café da manhã");
    Thread.Sleep(2000);
    Console.WriteLine("\nCafé da manhã servido");
}
static Pao PrepararPao()
{
    Console.WriteLine("\nPartir o pão");
    Thread.Sleep(2000);
    Console.WriteLine("\nPassar manteiga");
    Thread.Sleep(2000);
    return new Pao();
}
static Cafe PrepararCafe()
{
    Console.WriteLine("\nFerver a água");
    Thread.Sleep(2000);
    Console.WriteLine("\nCoar o café");
    Thread.Sleep(2000);
    return new Cafe();
}

internal class Pao
{

}
internal class Cafe
{

}