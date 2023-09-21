// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Input 2 numberos: ");

int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Input 3 numberos: ");

int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = Convert.ToInt32(Console.ReadLine());

int num3 = Convert.ToInt32(Console.ReadLine());

int max=num1;

if(num1>num2){
    max = num1;
}
else{
    max=num2;
}
if(num3 > max){
    max=num3;
}

Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Input number: ");

int number = Convert.ToInt32(Console.ReadLine());

if(number % 2==0){
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число: ");

int number = Convert.ToInt32(Console.ReadLine());

int count = 2;

while (count < number)
{
    Console.Write(count);
    Console.Write(", ");
    count = count + 2;
}
if(number%2==0){
    Console.WriteLine(number);
}
