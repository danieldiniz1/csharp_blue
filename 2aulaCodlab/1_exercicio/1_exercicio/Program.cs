using System;

//Algoritmo para calcular fatorial de um número informado pelo usuário//

Console.WriteLine("Digite um número para descobrir seu fatorial");
long numero = Convert.ToInt64(Console.ReadLine());
long fatorial = 1;

for (int i = Convert.ToInt32(numero); i > 1; i--)
    {
    fatorial = fatorial * i;
    Console.WriteLine(fatorial);
    }

Console.WriteLine($"o fatorial do número {numero} é {fatorial}.");

