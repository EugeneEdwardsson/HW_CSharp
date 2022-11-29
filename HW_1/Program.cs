

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter First number. ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Second number. ");
int numberTwo = Convert.ToInt32(Console.ReadLine());


if (numberOne > numberTwo)
{
   Console.Write("Max = " + numberOne + " " + "Min = " + numberTwo);
}
else
{
   Console.Write("Max = " + numberTwo + " " + "Min = " + numberOne); 
}