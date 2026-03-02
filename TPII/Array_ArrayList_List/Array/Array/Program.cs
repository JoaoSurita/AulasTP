// Array - Não Cresce Dinamicamente, só um tipo

int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] valores;
valores = new int[2] { 20, 10 };
string[] nomes = new string[5] { "Maria", "Paulo", "Pedro", "Joao", "Carolina" };

// Classe Array

// Mostra o Array de trás pra frente
Array.Reverse(numeros);

// Organiza o Array do menor para o maior
Array.Sort(nomes);

// Mostra o índice do valor buscado
int indice = Array.BinarySearch(nomes, "Pedro");
Console.WriteLine($"Encontrou Pedro no índice {indice}");

//Mostrar com foreach
foreach(var dado in nomes)
{
    Console.WriteLine(dado);
}

/*
Arrumar depois
for (int x = 0; x < 2; x++) ;
{
    Console.WriteLine(valores[x]);
}
*/

// Matriz de mais do que uma dimensão

// Formas de atribuir valores para a matriz
int[,] Mat1;
Mat1 = new int[2, 3];
Mat1[0, 0] = 1;

int[,] Mat2 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

// Métodos de Busca
for (int lin = 0; lin < Mat2.GetLength(0); lin++)
{
    for (int col = 0; col < Mat2.GetLength(1); col++)
    {
        Console.WriteLine(Mat2[lin, col]);
    }
}

foreach(var dado in Mat2)
{
    Console.WriteLine(dado);
}