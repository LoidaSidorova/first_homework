// Домашняя работа №1


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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



// Домашняя работа №2


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



// Домашняя работа №4




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




// 5 домашняя работа

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int [] CreateRandomArray(int min, int max, int size){
//     int [] array = new int [size];
//     for (int i = 0; i<size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for(int i = 0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void Evens(int[] array){
//     int count = 0;
//     for(int i=0; i<array.Length; i++){
//         if(array[i]%2==0) count++;
//     }
//     Console.WriteLine($"number of even numbers is {count}");
// }

// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(min,max,size);
// ShowArray(newArray);
// Evens(newArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int min, int max, int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SumOddPos(int[] array)
// {
//     int sumOdd = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if ((i % 2) == 1) sumOdd = sumOdd + array[i];
//     }
//     Console.WriteLine($"Sum elements on odd position is {sumOdd}");
// }

// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// Console.WriteLine();
// SumOddPos(newArray);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] CreateRandomArray(double min, double max, int size)
// {
//     double[] array = new double[size];
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.NextDouble()*100;
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i].ToString("F2"));//2 знака после запятой
//     }
//     Console.WriteLine();
// }

// void DifMinMax(double[] array){
//     double min = array[1];
//     double max = array[1];
//     for(int i=0; i<array.Length; i++){
//         if(array[i]>max) max = array[i];
//         if(array[i]<min) min = array[i];
//     }
//     Console.WriteLine($"Difference between maximum and minimum elements is {(max-min).ToString("F2")}");
// }

// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// double[] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// Console.WriteLine();
// DifMinMax(newArray);



// 6 домашняя работа

//Задача с семинара

// Нужно найти 2 максимальных элемента произвольного массива

// int[] CreateRandomArray(int min, int max, int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void TwoMax(int[] array)
// {
//     int max1 = array[1];
//     int max2 = array[1];
//     for(int i=0; i<array.Length; i++)
//     {
// if(array[i]>max1)
// {
//     max2 = max1;//перезаписываем второй максимум
//     max1 = array[i];//перезаписываем первый максимум
// }
// else if (array[i] > max2 && array[i] != max1)
// {
//     max2 = array[i];
// }
//     }
//     Console.WriteLine($"The two largest numbers in the array is {max1} and {max2}");
// }

// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// Console.WriteLine();
// TwoMax(newArray);




// //Домашние задачки

// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3


// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     Console.WriteLine("Enter elements of array:");
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int count = 0;

// void MoreZeroNum(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) { if (array[i] > 0) count++; }
//     Console.WriteLine($"Quantity of numbers greater than zero is {count}");
// }

// Console.WriteLine("Enter size of array:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);
// Console.WriteLine();
// MoreZeroNum(newArray);


// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void LineS(double k1, double b1, double k2, double b2)
// {
//     if (k1 != k2)
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = x * k1 + b1;
//         Console.WriteLine($"Point of intersection of two lines is ({x};{y})");
//     }
//     if (b1 == b2 && k1 == k2) Console.WriteLine("Lines coincide!");
//     else if (k1 == k2 && b1 != b2) Console.WriteLine("Lines are parallel!");
// }

// Console.WriteLine("Enter b1, k1 and b2, k2");
// double b1 = Convert.ToDouble(Console.ReadLine());
// double k1 = Convert.ToDouble(Console.ReadLine());

// double b2 = Convert.ToDouble(Console.ReadLine());
// double k2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine();
// Console.WriteLine($"Equation of the first line is y={k1}x+{b1}; Equation of the second line is y={k2}x+{b2}");
// Console.WriteLine();
// LineS(k1, b1, k2, b2);


//Домашняя работа №7

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размерность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

// Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы. Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.

// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

// 0,5    7    -2    -0,2
// 1    -3,3    8    -9,9
// 8    7,8    -7,1    9





// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размерность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

// Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы. Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.

// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

// 0,5    7    -2    -0,2
// 1    -3,3    8    -9,9
// 8    7,8    -7,1    9

// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.

// Пример


// n = 3;
// m = 4;
// k = 2;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintListAvr(FindAverageInColumns(result));

// /*
// 1   3   5   7   
// 9   11  13  15  
// 17  19  21  23  
// The averages in columns are:
// 9.00    11.00   13.00   15.00
// */





//Домашняя работа №8

// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он принимает на вход двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую 
//строку матрицы так, чтобы элементы в каждой строке шли по убыванию.

// Аргументы, передаваемые в метод/функцию:

// '9, 1, 7; 1, 2, 3; 4, 5, 6'
// На выходе:


// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   

// Матрица с упорядоченными по убыванию строками:
// 9   7   1   
// 3   2   1   
// 6   5   4

int [,] CreateMatrix(int min, int max, int row, int col){
    int [,] array = new int [row,col];
    for(int i = 0; i<row; i++){
       for(int j=0; j<col; j++){
        array[i,j] = new Random().Next(min,max+1);
       } 
    }
    return array;
}

void PrintMatrix(int[,] matrix){
    for(int i=0; i<Get.Length(0); i++){
        for(int j=0; j<Get.Length(1); j++){
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter number of rows in array:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of col in array:");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value in array:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value in array:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = CreateMatrix(min,max,row,col);
PrintMatrix(array);
Console.WriteLine();
// ShowSum(array);

