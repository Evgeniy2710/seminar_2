// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

//Способ Первый
// //Вводим число
// int input = int.Parse(Console.ReadLine());
// //Получаем первую цифру.
// int ThirdNumber = input %10;
// Console.WriteLine(ThirdNumber); 
// //Получаем вторую цифру
// //Число XYZ = X*100+Y*10+Z. Y = (XYZ-X*100-Z)/100 
// int SecondNumber = (input - (input/100 * 100) - input%10) / 10;
// Console.WriteLine("Второе Число: "+SecondNumber+" ,Третье число: "+ThirdNumber );
// Console.WriteLine("Результат возведения в степень: "+ SecondNumber + "^ " +ThirdNumber+ " => " +Math.Pow(SecondNumber, ThirdNumber));


//Способ второй.

int n = new Random().Next(100, 1000);
//Находим второе число.
int a = n % 100;
Console.WriteLine(n);
Console.WriteLine (a);
a = a / 10;
//Находим третье число.
int b = n % 10;
Console.WriteLine(b);
//Находим результат возведения в степень, для чего создаем переменную "с"
double c = Math.Pow(a, b);
Console.WriteLine($"{n} => {a}^{b} => {c}");
