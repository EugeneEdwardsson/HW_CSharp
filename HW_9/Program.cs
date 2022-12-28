using System;


/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
*/

// void PrintNumbers(int num)
// {   
//     if (num > 0)
//     {  
//        Console.Write(num + " ");
//        PrintNumbers(num - 1);
//     }
     
// }

// Console.Write("Input a number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(n);



/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  
*/




    // int SumNumbers(int m, int n)
    // {
    //      if(m < n)
    //      { 
    //         return m + SumNumbers(m + 1,n);
    //      }
    //      if(m > n)
    //      {  
    //         return m + SumNumbers(m - 1,n);
    //      }

    //    return n;       
    // }
    
    // Console.Write("Enter number M: ");
    // int m = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Enter number N: ");
    // int n = Convert.ToInt32(Console.ReadLine());
    // int res = SumNumbers(m,n);
    // Console.WriteLine("Sum: " + (res));




/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
*/

    int Ackermann(int m, int n)
    {
         
            if (m == 0)
            {
               return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            else
            {
               return Ackermann(m - 1, Ackermann(m, n - 1));
            }
              
    }
    
    Console.Write("Enter number M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int res = Ackermann(m,n);
    Console.WriteLine("A: " + (res));
