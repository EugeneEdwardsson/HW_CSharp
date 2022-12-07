using System;



//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.




 Console.Write("Input number: ");
 int numberInput = Convert.ToInt32(Console.ReadLine());

    void Pallindrom(int num)
    {
        int pal = 0;
        int number = num;

        while (num > 0) 
        {
             pal = pal * 10 + num % 10; 
             num /= 10;
        }

        if (number == pal)
        {
           Console.WriteLine("Palindrom");
        }
        else
        {
           Console.WriteLine("Not palindrom");   
        }
    
    }


    Pallindrom(numberInput);




// //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


//         Console.Write("Введите координаты xA: ");
//         double firstX = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Введите координаты yA: ");
//         double firstY = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Введите координаты zA: ");
//         double firstZ = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Введите координаты xB: ");
//         double secondX = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Введите координаты yB: ");
//         double secondY = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Введите координаты zB: ");
//         double secondZ = Convert.ToDouble(Console.ReadLine());


//         double FindDistance3D(double xA, double yA,  double zA, double xB, double yB, double zB)
//         {
//             double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
//             return Math.Round(distance, 2);
//         }
     
//         double distance3D = FindDistance3D(firstX,secondX,firstY,secondY,firstZ,secondZ);
//         Console.WriteLine($"Distance between two points in 3D space: {distance3D}");




//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    // Console.Write("Enter number N: ");
    // int numberN = Convert.ToInt32(Console.ReadLine());


    // void tableSquareN(int n)
    // {

    //   int res = 1;

    //   while (res < n) 
    //   {
    //     Console.WriteLine(" " + Math.Pow(res, 3));
    //     res++; 
    //   }
        
    // }
    
    // Console.WriteLine($"Table of cubes of the entered number: {numberN}");
    // tableSquareN(numberN);
    