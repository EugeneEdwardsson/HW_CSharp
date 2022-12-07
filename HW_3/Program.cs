using System;



//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.





























//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


        Console.Write("Введите координаты xA: ");
        double firstX = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты yA: ");
        double firstY = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты zA: ");
        double firstZ = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты xB: ");
        double secondX = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты yB: ");
        double secondY = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты zB: ");
        double secondZ = Convert.ToDouble(Console.ReadLine());


    double FindDistance3D(double xA, double yA,  double zA, double xB, double yB, double zB)
    {
        double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
        return Math.Round(distance, 2);
    }


    
    double distance3D = FindDistance3D(firstX,secondX,firstY,secondY,firstZ,secondZ);

    Console.WriteLine($"Distance between two points in 3D space: {distance3D}");




//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.