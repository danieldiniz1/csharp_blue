using System;

// FUNÇÕES / MÉTODOS

int eleva2(int x)
{
    int y = x ^ 2;
    return y;
}                  


void imprimir(int n, string palavra)
{
    Console.WriteLine($"O número é {n}");
    Console.WriteLine($"A palavra é {palavra}");
}

Console.WriteLine(eleva2(7));
imprimir(10, "doce");
