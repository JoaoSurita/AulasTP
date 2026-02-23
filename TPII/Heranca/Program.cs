
Aluno aluno1 = new Aluno("Paulo", "111.111.111-11", "0201392511020");

Console.WriteLine($"Nome:{aluno1.Nome}\nCPF:{aluno1.Cpf}\nRA:{aluno1.Ra}");
Console.WriteLine();

Console.Write("Digite o nome do Professor: ");
var nomeProf = Console.ReadLine();

Console.Write("Digite o CPF do Professor: ");
var cpfProf = Console.ReadLine();

Console.Write("Digite a Titulação do Professor: ");
var titulacaoProf = Console.ReadLine();

Professor prof1 = new Professor(nomeProf, cpfProf, titulacaoProf);
Professor.Exibir(prof1);


public class Pessoa
{
    public Pessoa(string? nome, string? cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
}

public class Aluno : Pessoa
{
    public Aluno(string? nome, string? cpf, string? ra) : base(nome, cpf)
    {
        Ra = ra;
    }
    public string? Ra { get; set; }
}

public class Professor : Pessoa
{
    public Professor(string? nome, string? cpf, string? titulacao) : base(nome, cpf)
    {
        Titulacao = titulacao;
    }
    public string? Titulacao { get; set; }

    public static void Exibir(Professor prof) => Console.WriteLine($"Nome:{prof.Nome}\nCPF:{prof.Cpf}\nRA:{prof.Titulacao}");
}