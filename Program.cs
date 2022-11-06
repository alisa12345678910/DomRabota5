// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[]CreateFillArray(int x) 
// {
// int[]Array = new int[x]; 
// for (int i=0; i<x; i++)
// {
//     Array[i] = new Random().Next(100, 999);
//     Console.Write($"{Array[i]} ");
// }
// return Array; 
// }

// void NumberOfEvenNumbers(int[] Array)
// {
// int evenCount=0;
// foreach (int el in Array)
// {
//     if (el % 2 == 0) evenCount++;
// }
// Console.WriteLine($"Количество четных чисел равно {evenCount}");
// }
// int[] mas = CreateFillArray(10);
// NumberOfEvenNumbers(mas);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[]CreateFillArray(int x) 
// {
// int[]Array = new int[x]; 
// for (int i=0; i<x; i++)
// {
//     Array[i] = new Random().Next(100, 999);
//     Console.Write($"{Array[i]} ");
// }
// return Array; 
// }
// void SummOfOddNumbersPosition(int[] Array)
// {
// int summ=0;
// for (int i=0; i<Array.Length; i++)
// {
//     if (i % 2 == 0) summ = summ + Array[i];
// }
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна  {summ}");
// }
// int[] mas = CreateFillArray(3);
// SummOfOddNumbersPosition(mas);
