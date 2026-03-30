try
{
    A.executandoA();
}
catch (Exception ex)
{
    Console.WriteLine($"A exceção foi tratada em A: {ex.Message}");
}

class A
{
    public static void executandoA()
    {
        //try
        //{
        B.executandoB();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"A exceção foi tratada em A: {ex.Message}");
        //}
    }
}
class B
{
    public static void executandoB()
    {
        //try
        //{
        C.executandoC();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"A exceção foi tratada em B: {ex.Message}");
        //}
    }
}
class C
{
    public static void executandoC()
    {
        throw new NotImplementedException("O método não foi implementado em C");
    }
}