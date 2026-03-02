// ArrayList - Cresce Dinamicamente, vários tipos

using System.Collections;

// Formas para definir tamanho
ArrayList lista = new ArrayList(5);
ArrayList lista2 = new (2);

// Atribuindo Valores. Pode ser diversos tipos
lista.Add("Maria");
lista.Add(18);
lista.Add(1.65);
lista.Add(true);
lista.Add(null);
// Atribui um elemento no meio do ArrayList se localizando pelo índice
lista.Insert(3, 65);

int[] array1 = { 1, 2, 3 };
// Adiciona uma coleção no final do ArrayList
lista.AddRange(array1);
// Atribui uma coleção no meio do ArrayList se localizando pelo índice
lista.InsertRange(0, array1);

// remove - remove um elemento da ArrayList específico
lista.Remove("Maria");

// removeAt - remove de um índice especificado
lista.RemoveAt(1);

// removeRange - remove um conjunto de elementos
// especificado pelos índices
lista.RemoveRange(2, 4);

// foreach
foreach(var dado in lista)
{
    Console.WriteLine(dado);
}

// Inicialização direta com valores (Collection Initializer)
var lista3 = new ArrayList() { "Maria", "Paulo", "Ana", "a" };

// Sort - Organiza os elementos em ordem alfabética ou crescente
lista3.Sort();

// Contains - Verifica se um elemento exato existe na lista (Retorna true ou false)
var res1 = lista3.Contains("a");

// Percorre a lista já ordenada e imprime cada nome
foreach (var dado in lista3)
{
    Console.WriteLine(dado);
}

// Lógica condicional baseada no resultado do Contains
if (res1)
{
    Console.WriteLine("Contém");
}
else
{
    Console.WriteLine("Não Contém");
}

// Clear - Remove TODOS os elementos da ArrayList de uma vez, deixando-a vazia
lista3.Clear();

// Este foreach não executará nada, pois a lista agora está vazia (Count = 0)
foreach (var dado in lista3)
{
    Console.WriteLine(dado);
}