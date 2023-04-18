/* 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
declarado. */

// ENTREDA
// digigitar os 15 numeros e armazenar no vetor

int [] num = new int [5];

//PROCESSAMENTO

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i+1}º número:");
    num[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(@$"
--------------
Ordem Inversa:
--------------");

Array.Reverse(num);
foreach (var mun in num)
{
    Console.WriteLine($"{mun} ");
    
}