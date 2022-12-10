using System;

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write("Input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponent(int numA, int numB){

    int res = 1;

    for (int i = 1; i <= numB; i++)
    {
        res = res * numA;
    }

    return res;

}


int exp = Exponent(numberA, numberB);
Console.WriteLine($"{numberA} raised to the power {numberB} = {exp}");



//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
























//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.