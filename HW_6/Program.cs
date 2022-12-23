using System;

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int CounterNumbers(int num)
// {
//         int count = 0;

//         if (num > 0)
//         {  
//            count++;
//         }

//         return count;

//     }      


// void ShowCheckNumbers()
// {    
//     int result = 0;
//     Console.WriteLine("Input numbers count:");
//     int numbers = Convert.ToInt32(Console.ReadLine());

//         for (int i = 0; i < numbers; i++)
//         {
//             Console.WriteLine("Input number: ");
//             int number = Convert.ToInt32(Console.ReadLine());
//             result = result + CounterNumbers(number);
//             Console.WriteLine($"The number of elements entered by the user: {result}");

//         }

        

// }        


// ShowCheckNumbers();



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double[] FindPointIntersectionTwoLine(double b1 ,double k1, double b2, double k2)
{   
    double[] array = new double[2];
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    array[0] = Math.Round(x, 3);
    array[1] = Math.Round(y, 3);;

    return array;
}


void CheckingPointsForPosition(double b1 ,double k1, double b2, double k2)
{

if(k1 == k2 && b1 == b2)

    Console.WriteLine("Direct lines coincide relative to each other!");

else if(k1 == k2)

    Console.WriteLine("The lines are parallel to each other!");

else
{
    double[] points = FindPointIntersectionTwoLine(k1, b1, k2, b2);
    Console.WriteLine( $"Point of intersection of two lines: ({points[0]}  {points[1]})");
}

}


Console.WriteLine("Input point k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input point b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input point k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input point b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

CheckingPointsForPosition(k1,b1,b2,k2);
