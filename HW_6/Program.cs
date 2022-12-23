using System;

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CounterNumbers(int num)
{
        int count = 0;

        if (num > 0)
        {  
           count++;
        }

        return count;

    }      


void ShowCheckNumbers()
{    
    int result = 0;
    Console.WriteLine("Input numbers count:");
    int numbers = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numbers
        ; i++)
        {
            Console.WriteLine("Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            result = result + CounterNumbers(number);
            Console.WriteLine($"The number of elements entered by the user: {result}");

        }

        

}        


ShowCheckNumbers();



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

