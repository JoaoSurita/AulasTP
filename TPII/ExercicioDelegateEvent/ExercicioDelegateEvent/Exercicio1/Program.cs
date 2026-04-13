// Exercicio 1

Operacao soma = (a, b) => a + b;
Operacao sub = (a, b) => a - b;
Operacao mult = (a, b) => a * b;
Operacao div = (a, b) => b != 0 ? a / b : 0;

Console.WriteLine($"Soma: {soma(10, 5)}");
Console.WriteLine($"Subtração: {sub(10, 5)}");
Console.WriteLine($"Multiplicação: {mult.Invoke(10, 5)}");
Console.WriteLine($"Divisão: {div(10, 5)}");

Console.ReadKey();

public delegate double Operacao(double num1, double num2);