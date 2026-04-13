ArCondicionado ar = new ArCondicionado();
ar.AlarmeTemperatura += Monitor.Alerta;
ar.AjustarTemperatura(32);

delegate void AlarmeHandler(string msg);

class ArCondicionado
{
    public double LimiteSuperior { get; set; } = 30;
    public double LimiteInferior { get; set; } = 15;

    public event AlarmeHandler? AlarmeTemperatura;

    public void AjustarTemperatura(double temp)
    {
        Console.WriteLine($"Temperatura atual: {temp}°C");
        if (temp > LimiteSuperior || temp < LimiteInferior)
        {
            AlarmeTemperatura?.Invoke($"ALERTA: Temperatura fora dos limites! ({temp}°C)");
        }
    }
}

class Monitor
{
    public static void Alerta(string mensagem) => Console.WriteLine(mensagem);
}