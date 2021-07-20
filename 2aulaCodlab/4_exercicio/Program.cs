using System;

//4.Altere o algoritmo anterior para que os números sejam inseridos no
//array aleatoriamente: utilizar o objeto Random(). A aplicação também
//deve apresentar o número que tem a maior frequência.

Console.WriteLine("Quantos números deseja ter em seu conjunto? ");
int qtde = Convert.ToInt32(Console.ReadLine());
int[] values = new int[qtde]; // Criar um array vazio de tamanho fixo determinado pelo qtde

var aleatorio = new Random(); // Instanciando Objeto do tipo Random

for (int i = 0; i < qtde; i++)
{
    values[i] = aleatorio.Next(1, 100);
}

// Ordenar a lista
Array.Sort(values);

Console.WriteLine("[{0}] {1}", string.Join(", ", values), "é a lista ordenada!");