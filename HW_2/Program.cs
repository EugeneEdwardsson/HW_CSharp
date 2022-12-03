using System;


//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.



// int numberRandom = new Random().Next(100,1000);
// Console.WriteLine($"Random three digit number: {numberRandom}");

// int ShowTwoDigit(int number)
// {
// int div = number / 10;

// return div % 10;

// }

// int twoDigit = ShowTwoDigit(numberRandom);
// Console.WriteLine($"Second digit number: {twoDigit}");




//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Input the number: ");
int givenNumber = Convert.ToInt32(Console.ReadLine());

bool ShowThreeDigit(int number)
{
 string anyNumberString = Convert.ToString(number);
 if (anyNumberString.Length > 2)
 {
    Console.WriteLine($"Three digit number: {anyNumberString[2]}");
    return true;
 }
 else
 {
    Console.WriteLine("Entered number less than three digits: ");
    return false;
 }
}


Console.WriteLine(ShowThreeDigit(givenNumber));











//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Input the number of the day of the week: ");
// int inputNumber = Convert.ToInt32(Console.ReadLine());

// bool CheckDay(int number)
// {
//     if (number == 6 || number == 7)
//     {
//         Console.WriteLine("Six day!!! Satuday - day off");
//         return true;
//     } 
//     else if (number < 1 || number > 7)
//     {
//         Console.WriteLine("Incorrect entry in week 7 days!!!");
//         return false;
//     } 
//     else
//     {
//         Console.WriteLine("Week day!!! Work nigga! ");
//         return false;
//     }
    

// }


// bool dayWeek = CheckDay(inputNumber);
// Console.WriteLine(dayWeek);

