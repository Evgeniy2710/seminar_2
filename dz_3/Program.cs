// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 40 => 4
// 96 => 9 40 => 4
// 72 => 7
int num = new Random().Next(10, 100);
Console.WriteLine(num);
int num1 = num / 10; 
int num2 = num %10;   
//Console.WriteLine(num1);
//Console.WriteLine(num2);
if (num1 > num2)
{
    Console.WriteLine($"{num} => {num1}");
}
else
{
    Console.WriteLine($"{num} => {num2}");
}