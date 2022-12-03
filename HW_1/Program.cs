

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Enter First number: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter Second number: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());

// int EqualNumbers(int numOne, int numTwo ){

//  if (numOne > numTwo)
//  {
//     Console.Write($"Max = {numOne}, Min = {numTwo}");
//     return numberOne;

//  }
//  else
//  {

//     Console.Write($"Max = {numTwo}, Min = {numOne}"); 
//     return numTwo;

//  }
// }

// int result = EqualNumbers(numberOne, numberTwo);




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Enter First number. ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Second number. ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Third number. ");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = numberOne;

if (numberOne > max) max = numberOne;
if (numberTwo > max) max = numberTwo;
if (numberThree > max) max = numberThree;

Console.WriteLine("Max = " + max);



//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.Write("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0) 
// {
//     Console.Write("Entered number is even" + number);
// } 
//  else
// {
//     Console.Write("Entered number is odd" + number);
// }



//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


// Console.Write("Enter number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int res = 1;

// while (res < n) 
// {
//     if (res % 2 == 0)
//     {
//         Console.Write(" " + res);
//     } 
    
//     res++;
// }

        

