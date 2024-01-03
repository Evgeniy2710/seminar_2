// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int a = 7;
int b = 23;
int num = Convert.ToInt32(Console.ReadLine());
if(num % a == 0 && num % b == 0){
    Console.WriteLine($"Число {num}, кратно {a} и {b}");
}
else
{
    if(num % a == 1 || num % b == 0){
    Console.WriteLine($"Число {num}, не кратно {a}, но кратно {b}");
    }
    if (num % a == 0 || num % b == 1)
    {
        Console.WriteLine($"Число {num}, кратно {a}, но не кратно {b}");
    }
}