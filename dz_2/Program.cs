﻿// Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Введите значение <<X>> координаты: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение <<Y>> координаты: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0)
{
Console.Write("Значения координат не могут быть равны 0, введидите другие значения");    
}
else
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine($"Введенные координаты {x} и {y} принадлежат координатной плоскости № 1");   
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine($"Введенные координаты {x} и {y} принадлежат координатной плоскости № 2");
    }
    if (x <0 && y <0)
    {
        Console.WriteLine($"Введенные координаты {x} и {y} принадлежат координатной плоскости № 3");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine($"Введенные координаты {x} и {y} принадлежат координатной плоскости № 4");
    }
}