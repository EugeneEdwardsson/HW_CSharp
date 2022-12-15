﻿using System;



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }    
//     Console.WriteLine( );
// }

// int GetCountOfPositive(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }        
//     return count;
// }

// Console.Write("Input number elements: ");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(lenght, min, max);
// PrintArray(myArray);
// int result = GetCountOfPositive(myArray);
// Console.WriteLine($"Amount of positive elements is {result}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }    
    Console.WriteLine( );
}

int GetSumOfNegativePosition(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 1)
        {
            sum ++;
        }
    }        
    return sum;
}


Console.Write("Input number elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(lenght, min, max);
PrintArray(myArray);
int result = GetSumOfNegativePosition(myArray);
Console.WriteLine($"Sum of positive elements is {result}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.