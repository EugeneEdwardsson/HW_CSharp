using System;


/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
*/

void PrintNumbers(int num)
{   
    if (num > 0)
    {  
       Console.Write(num + " ");
       PrintNumbers(num - 1);
    }
     
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(n);



/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  
*/




    void SumNumbers(int n, int m)
    {

      int res = 1;

      while (res < n) 
      {
        Console.WriteLine(" ");
        res++; 
      }
        
    }
    
    Console.Write("Enter number N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    SumNumbers(n,m);




/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
*/