using System;




/* 
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 
*/

// int[,] CreateRandomArray()
// {
//     Console.WriteLine("input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("input a number of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colums];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {   
//     Console.WriteLine("--------------------------");

//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {   
//             Console.Write(array[i,j] + "\t");
//         }

//        Console.WriteLine(); 

//     }

//     Console.WriteLine("--------------------------");

// }


// void SortArrayRow(int[,] array)
// {    

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          for (int k = 0; k < array.GetLength(1) - 1; k++)
//          {      
//             if (array[i, k] < array[i, k + 1])
//             {
//                  int tmp = array[i, k + 1];
//                  array[i, k + 1] = array[i, k];
//                  array[i, k] = tmp;
//             }     

//          }
//       }
//    }

// }

// int[,] myArray = CreateRandomArray();
// Show2dArray(myArray);
// SortArrayRow(myArray);
// Show2dArray(myArray);



/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/



        // int[,] CreateRandomArray()
        // {
        //     Console.WriteLine("input a number of rows: ");
        //     int rows = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("input a number of colums: ");
        //     int colums = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("input a min possible value: ");
        //     int minValue = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("input a max possible value: ");
        //     int maxValue = Convert.ToInt32(Console.ReadLine());

        //     int[,] array = new int[rows, colums];

        //     for (int i = 0; i < rows; i++)
        //     {
        //         for (int j = 0; j < colums; j++)
        //         {
        //             array[i, j] = new Random().Next(minValue, maxValue);
        //         }
        //     }
        //     return array;
        // }

        // void Show2dArray(int[,] array)
        // {
        //     Console.WriteLine("--------------------------");

        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             Console.Write(array[i, j] + "\t");
        //         }

        //         Console.WriteLine();

        //     }

        //     Console.WriteLine("--------------------------");
        // }

        // void PrintArray(int[] array)
        // {
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         Console.Write(array[i] + "\t");
        //     }
        //     Console.WriteLine();
        // }


        // int[] SumElementsRow(int[,] array)
        // {
        //     int[] myArr = new int[array.GetLength(0)];

        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         int sum = 0;

        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             sum += array[i, j];
        //         }

        //         myArr[i] = sum;
        //     }

        //     return myArr;

        // }

        // void CheckMinSumElementRow(int[] array)
        // {
        //     int min = array[0];
        //     int index = 0;
         
                
        //        if (array[0] < min) min = array[0];
        //        if (array[1] < min) min = array[1];
        //        if (array[2] < min) min = array[2];
        //        if (array[3] < min) min = array[3];

        //        for (int i = 0; i < array.Length; i++)
        //        {
        //             if (array[i] == min)
        //             {
        //               index = i;
        //             }
        //        }


                
        //     Console.Write($"\n {index + 1} row with the smallest sum ({min}) elements "); 

        // }

        // int[,] myArray = CreateRandomArray();
        // Show2dArray(myArray);
        // int[] sumRowArray = SumElementsRow(myArray);
        // PrintArray(sumRowArray);
        // CheckMinSumElementRow(sumRowArray);
    




/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/



// void CreateRandomArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1,10);
//     }
//   }
// }

// void Show2dArray(int[,] array)
// {   
//     Console.WriteLine("--------------------------");

//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {   
//             Console.Write(array[i,j] + "\t");
//         }

//        Console.WriteLine(); 

//     }

//     Console.WriteLine("--------------------------");

// }

// void MatrixMult(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secondMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// Console.WriteLine("---Set parameters for future matrices---");
// Console.WriteLine("input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input a number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());



// int[,] firstMartrix = new int[rows,colums];
// CreateRandomArray(firstMartrix);
// Console.WriteLine("First matrix:");
// Show2dArray(firstMartrix);

// int[,] secondMartrix = new int[rows,colums];
// CreateRandomArray(secondMartrix);
// Console.WriteLine("Second matrix:");
// Show2dArray(secondMartrix);

// int[,] resultMatrix = new int[rows,colums];
// MatrixMult(firstMartrix, secondMartrix, resultMatrix);
// Console.WriteLine("The result of multiplying two matrices:");
// Show2dArray(resultMatrix);





/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
















/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


void FillSquad2DArray(int[,] array)
{
  
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;

     if (i <= j + 1 && i + j < array.GetLength(1) - 1)
         j++;
     else if (i < j && i + j >= array.GetLength(0) - 1)
         i++;
     else if (i >= j && i + j > array.GetLength(1) - 1)
         j--;
     else
         i--;

    }

}


int[,] Create2DArray()
{
        Console.WriteLine("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("input a number of colums: ");
        int colums = Convert.ToInt32(Console.ReadLine());


        int[,] array = new int[rows, colums];
            
        return array;

}
 

void Show2dArray(int[,] array)
{   
    Console.WriteLine("--------------------------");

    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   
               Console.Write(array[i,j] + "\t");     
        }

       Console.WriteLine(); 

    }

    Console.WriteLine("--------------------------");

}



int[,] squareArray = Create2DArray();
FillSquad2DArray(squareArray);
Show2dArray(squareArray);

