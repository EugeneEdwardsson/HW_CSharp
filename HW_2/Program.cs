using System;


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input the number of the day of the week: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

bool CheckDay(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Six day!!! Satuday - day off");
        return true;
    } 
    else if (number < 1 || number > 7)
    {
        Console.WriteLine("Incorrect entry in week 7 days!!!");
        return false;
    } 
    else
    {
        Console.WriteLine("Week day!!! Work nigga! ");
        return false;
    }
    

}


bool dayWeek = CheckDay(inputNumber);
Console.WriteLine(dayWeek);

