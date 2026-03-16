Console.WriteLine("Café da Manhã Sincrono");
await cafeDaManhaAsync();
Console.WriteLine("Fim do Café da Manhã");

static async Task cafeDaManhaAsync()
{
    Console.WriteLine("Preparar o café");
    var TarefaCafe = PrepararCafeAsync();
    Console.WriteLine("\nPreparar o pão");
    var TarefaPao = PrepararPaoAsync();
    var cafe = await (TarefaCafe);
    var pao = await (TarefaPao);
    ServirCafeAsync(cafe, pao);
}

static void ServirCafeAsync(Cafe cafe, Pao pao)
{
    Console.WriteLine("\nServindo café da manhã");
    Thread.Sleep(2000);
    Console.WriteLine("\nCafé da manhã servido");
}
static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("\nPartir o pão");
    await Task.Delay(2000);
    Console.WriteLine("\nPassar manteiga");
    await Task.Delay(2000);
    return new Pao();
}
static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("\nFerver a água");
    await Task.Delay(2000);
    Console.WriteLine("\nCoar o café");
    await Task.Delay(2000);
    return new Cafe();
}

internal class Pao
{

}
internal class Cafe
{

}