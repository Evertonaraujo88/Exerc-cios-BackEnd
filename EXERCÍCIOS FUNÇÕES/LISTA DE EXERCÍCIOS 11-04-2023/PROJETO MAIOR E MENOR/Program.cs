﻿/* Estruturas de repetição:
4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
menor valor lido.
 */

int[] numeros = new int[10];
 for (int i = 0; i < 10; i++)
 {
    Console.WriteLine($"Digite o {i+1}º numero: ");
    numeros[i] = int.Parse(Console.ReadLine());

 }
 
 Console.WriteLine($"O maior número é o {numeros.Max()}");
  Console.WriteLine($"O menor número é o {numeros.Min()}");