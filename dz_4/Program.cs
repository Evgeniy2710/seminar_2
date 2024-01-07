// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

Console.WriteLine("Введите число: ");

string num = Console.ReadLine();
char s2 = ',';

for (int i = 0; i < num.Length; i++) {


    
    Console.Write($"{num[i]} ");
    
    if (i < num.Length-1){
 
    Console.Write(Convert.ToString(s2));
    }
}

