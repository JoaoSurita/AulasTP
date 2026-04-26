List<int> numeros = new List<int> { 5, 12, 8, 20, 3, 15, 7 };

// a. Obter o maior número
int maiorNumero = numeros.Max();

// b. Somar todos os valores maiores que 10
int somaMaioresQueDez = numeros.Where(n => n > 10).Sum();

Console.WriteLine($"Maior Número: {maiorNumero}");
Console.WriteLine($"Soma dos números maiores que 10: {somaMaioresQueDez}");