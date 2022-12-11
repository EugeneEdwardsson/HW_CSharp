using System;

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// Console.Write("Input number A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int Exponent(int numA, int numB)
// {

//     int res = 1;

//     for (int i = 1; i <= numB; i++)
//     {
//         res = res * numA;
//     }

//     return res;

// }


// int exp = Exponent(numberA, numberB);
// Console.WriteLine($"{numberA} raised to the power {numberB} = {exp}");


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());


int sumDigitInNum(int num)
{
    int digit = 0;
    int sum = 0;

    for (int i = 0; i < 10; i++)
    {
        digit = num % 10;
        sum = sum + digit;
        num = num / 10;
    }
    return sum;
}


int sumDigit = sumDigitInNum(number);
Console.WriteLine($"Sum digit: {sumDigit}");


















//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.