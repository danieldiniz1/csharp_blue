using System;

//3.Algoritmo para definir um array de números com tamanho e valores
//definidos pelo usuário e apresentá-lo em tela ordenado de forma
//crescente.

Console.WriteLine("Quantos números deseja ter em seu conjunto? ");
int qtde = Convert.ToInt32(Console.ReadLine());
int[] values = new int[qtde]; // Criar um array vazio de tamanho fixo determinado pelo qtde

for (int i = 0; i < qtde; i++)
{
    Console.WriteLine($"Digite o {i + 1}º valor: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    values[i] = numero;
}

// Ordenar a lista
Array.Sort(values);

Console.WriteLine("[{0}] {1}", string.Join(", ", values), "é a lista ordenada!");