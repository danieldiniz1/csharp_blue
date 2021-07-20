using System;
using System.Collections.Generic;
using System.Linq;



//2. Algoritmo para encontrar o maior valor de uma lista de números com
//tamanho e valores definidos por usuário.

Console.WriteLine("Digite o tamanho da lista de números: ");
int tamanhoLista = Convert.ToInt32(Console.ReadLine());

List<int> listaNumeros = new List<int> { };

while (listaNumeros.Count < tamanhoLista)
{
    Console.WriteLine("Digite o número que deseja adicionar a lista: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    listaNumeros.Add(numero);
}

int maiorValor = listaNumeros.Max();

Console.WriteLine($"O maior valor da lista é {maiorValor}");








