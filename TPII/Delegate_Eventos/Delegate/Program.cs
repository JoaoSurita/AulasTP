// Segunda Etapa
MeuDelegate del1 = new MeuDelegate(MeuMetodo);
MeuDelegate del2 = MeuMetodo;
MeuDelegate del3 = (msg) => Console.WriteLine(msg);

// Terceira Etapa
del1.Invoke("Minha Mensagem 1");
del2("Minha Mensagem 2");
del3("Minha Mensagem 3");

static void MeuMetodo(string mensagem)
{
    Console.WriteLine(mensagem);
}
Console.ReadKey();

// Primeira etapa
public delegate void MeuDelegate(string msg);

