var caminho = @"C:\Users\0201392511020\Desktop\AulasTP\TPII\ManipulacaoDeArquivos\ManipulacaoDeArquivos\arquivo1.txt";

if (!File.Exists(caminho))
{
    File.WriteAllText(caminho, "Autor Desconhecido");
}

var novoTexto = "\r\nQuem canta seus vales espanta" + Environment.NewLine +
    "Água mole em pedra durta tanto bate até que fura \r\n Casa de ferreiro espeto é";
File.AppendAllText(caminho, novoTexto);
string conteudo = File.ReadAllText(caminho);
Console.WriteLine(conteudo);