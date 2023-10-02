﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Input 2 numberos: ");

// int num1 = Convert.ToInt32(Console.ReadLine());

// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1>num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input 3 numberos: ");

// int num1 = Convert.ToInt32(Console.ReadLine());

// int num2 = Convert.ToInt32(Console.ReadLine());

// int num3 = Convert.ToInt32(Console.ReadLine());

// int max=num1;

// if(num1>num2){
//     max = num1;
// }
// else{
//     max=num2;
// }
// if(num3 > max){
//     max=num3;
// }

// Console.WriteLine(max);



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Input number: ");

// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2==0){
//     Console.WriteLine("да");
// }
// else{
//     Console.WriteLine("нет");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите натуральное число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// int count = 2;

// while (count < number)
// {
//     Console.Write(count);
//     Console.Write(", ");
//     count = count + 2;
// }
// if(number%2==0){
//     Console.WriteLine(number);
// }




// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int EnterNum(string messige)
// {
//     Console.WriteLine($"{messige}");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int AverageFigure(int num)
// {
//     int avg = (num % 100 - num % 10) / 10;
//     return avg;
// }
// int number = EnterNum("Enter a three-digdt number: ");

// if (number >= 100 && number < 1000)
// {
//     int aver = AverageFigure(number);
//     Console.Write($"Average figure is {aver}");
// }
// else
// {
//     Console.WriteLine("The number is not three digits");
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int EnterNum(string messige)
// {
//     Console.WriteLine($"{messige}");
//     return Convert.ToInt32(Console.ReadLine());
// }

// void ThreeFigureMoreThous(int num)
// {
//    while(num > 999)
//    {
//     num = num / 10;
//    }
//    num = num % 10;
//    Console.WriteLine($"Third digit of the number is {num}");
// }

// void ThreeFigureLessThous(int numeric)
// {
//     if(numeric >= 100)
//     {
//         int third = numeric % 10;
//         Console.WriteLine($"Third digit of the number is {third}");
//     }
//     else
//     {
//         Console.WriteLine("Третьей цифры нет.");       
//     }
// }

// int number = EnterNum("Enter the number: ");

// if(number >= 1000)
// {
//     ThreeFigureMoreThous(number);
// }
// else
// {
//     ThreeFigureLessThous(number);
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int EnterNum(string messige)
// {
//     Console.WriteLine($"{messige}");
//     return Convert.ToInt32(Console.ReadLine());
// }

// void DayOff(int num)
// {
//     if(num>=6)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }
// int numday = EnterNum("Enter the day of the week number: ");

// if(numday>0&&numday<8)
// {
//     DayOff(numday);
// }
// else
// {
//     Console.WriteLine("День недели с таким номером неизвестен.");
// }




//3 ДОМАШНЯЯ РАБОТА

//1 задача

// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.

// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False

// int num, r, sum = 0, t;

// void IsPalindrome(int number)
// {
//         for (t = number; number != 0; number = number / 10)
//         {
//             r = number % 10;
//             sum = sum * 10 + r;
//         }
//         if (t == sum)
//             Console.Write("True");
//         else
//             Console.Write("False");
// }

// Console.Write("Введите пятизначное число: ");
// num = Convert.ToInt32(Console.ReadLine());

//     if(num==null)
//     Console.WriteLine("False");

// if(num>9999&&num<100000)
// {
//     IsPalindrome(num);
// }
// else
// {
//     Console.WriteLine("Число не пятизначное");
//     Console.WriteLine("False");
// }

// ПРОГРАММА РАБОТАЕТ, НО НЕ В ТОМ КОМПИЛЯТОРЕ, КОТОРЫЙ ПРЕДЛАГАЕТСЯ НА САЙТЕ


//2 задача

// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.


// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// void PrintDist(int Ax, int Ay, int Az, int Bx, int By, int Bz)
// {
//     int x=(Ax-Bx)*(Ax-Bx);
//     int y=(Ay-By)*(Ay-By);
//     int z=(Az-Bz)*(Az-Bz);

//     double distance = Math.Sqrt(x + y + z);
//     Console.WriteLine($"Distance between boints A and B is {distance}");
// }

// Console.WriteLine("Enter three coordinates point A: ");
// int A1 = Convert.ToInt32(Console.ReadLine());
// int A2 = Convert.ToInt32(Console.ReadLine());
// int A3 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter three coordinates point B: ");
// int B1 = Convert.ToInt32(Console.ReadLine());
// int B2 = Convert.ToInt32(Console.ReadLine());
// int B3 = Convert.ToInt32(Console.ReadLine());

// PrintDist(A1, A2, A3, B1, B2, B3);

// ПРОГРАММА РАБОТАЕТ, НО НЕ В ТОМ КОМПИЛЯТОРЕ, КОТОРЫЙ НА САЙТЕ


// 3 задача

// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.


// N = 3 
// /*
// 1
// 8
// 27
// */

// N = 5
// /*
// 1
// 8
// 27
// 64
// 125
// */

// void ShowCube(int num)
// {
//     for(int i=0; i<=num; i++)
//     {
//         int cube = i*i*i;
//         Console.WriteLine(cube);
//     } 
// }

// Console.WriteLine("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("cubes of numbers from 1 to N: ");
// ShowCube(number);

// ПРОГРАММА РАБОТАЕТ, НО НЕ В ТОМ КОМПИЛЯТОРЕ, КОТОРЫЙ НА САЙТЕ


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void ADegreeB(int numA, int numB)
// {
//     int degree = 1;
//     for(int i=1; i<=numB; i++)
//     {
//         degree = degree*numA;
//     }
//     Console.WriteLine($"number A degree of number B is {degree}");
// }

// Console.WriteLine("Enter number A and number B: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// ADegreeB(a, b);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void SumDigit(int number)
// {
//     int rem = 0;
//     while(number>0)
//     {
//         rem = rem + (number%10);
//         number = number/10;
//     }
//     Console.WriteLine($"Sum of digits in a number is {rem}");
// }

// Console.WriteLine("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// SumDigit(num);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] CreateRandomArray(int size){
//     int [] array = new int [size];
//     for (int i = 0; i<size; i++){
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     Console.Write("[");
//     for(int i = 0; i<array.Length-1; i++){
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write(array[array.Length-1]);
//     Console.WriteLine("]");
//     Console.WriteLine();
// }

// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter elements of array:");

// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);