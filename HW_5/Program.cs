using System;



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

// int GetSumOfNegativePosition(int[] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.Length; i = i + 2)
//     {
//         sum = sum + array[i];
//     }        
//     return sum;
// }


// Console.Write("Input number elements: ");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(lenght, min, max);
// PrintArray(myArray);
// int result = GetSumOfNegativePosition(myArray);
// Console.WriteLine($"Sum of elements in negative position is equal to {result}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



double[] CreateRandomArray(int size)
{
     double[] array = new double[size];
     

    for(int i = 0; i < array.Length; i++)
    {    
        array[i] = new Random().NextDouble() * 1000 / 10;    
    }    

    for(int j = 1; j < array.Length; j++)
    {   
         
        double arr = array[j];
        array[j] = new Random().NextDouble();
        array[0] = Math.Round(arr, 2);
        array[j] = Math.Round(arr, 2);
    }
    
    return array;


}


void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }    
    Console.WriteLine();
}

void DiffMinMaxValues(double[] array)
{
      double minVal = array[0];
      double maxVal = minVal;

      for (int i = 0; i < array.Length; i++)
      {
         if (array[i] < minVal)
         {
             minVal = array[i];
         }
         if (array[i] > maxVal)
         {
             maxVal = array[i];
         }
      }
    Console.WriteLine($"Difference between: {maxVal - minVal}");
}


  Console.Write("Input number elements: ");
  int lenght = Convert.ToInt32(Console.ReadLine());
  double[] myArray = CreateRandomArray(lenght);
  PrintArray(myArray);
  DiffMinMaxValues(myArray);
  


  