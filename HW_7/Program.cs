using System;



//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandomArray(int rows, int colums)
// {
//     double[,] array = new double[rows, colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colums; j++)
//         {    
//              array[i,j] = new Random().NextDouble() * 1000 / 10;
//         }
//     }
//     return array;
// }
// void PrintArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0;j < array.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(array[i,j], 2) + "\t");
//         }

//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }
//     Console.WriteLine("input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("input a number of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     double[,] myArray = CreateRandomArray(rows, colums);
//     PrintArray(myArray);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandomArray()
{
    Console.WriteLine("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{   
    Console.WriteLine("----------------------");

    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   
            Console.Write(array[i,j] + "\t");
        }
       
       Console.WriteLine(); 
       
    }

    Console.WriteLine("----------------------");
}


void FindElementPosition(int[,] array, int row, int column)
{
    if (array.GetLength(0) > row - 1 && array.GetLength(1) > column - 1)
    {
        Console.Write($"The value of the element at the selected position: {array[row - 1,column - 1]}");
    }
    else
    {
        Console.Write("The indexes entered are not in the array!!!");
    }           
}

int[,] myArray = CreateRandomArray();
Show2dArray(myArray);

Console.WriteLine("input a index position of row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a index position of column: ");
int column = Convert.ToInt32(Console.ReadLine());
FindElementPosition(myArray, row, column);



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.





