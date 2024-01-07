// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

// Console.WriteLine("Введите число: ");
// string num = Console.ReadLine();
// int num_len = num.Length; 
// Console.WriteLine(num_len);


// if(num_len < 3){
//     Console.WriteLine("Третьей цифры нет");
// }
// else{
//     string num1 = Convert.ToString(num[2]);
//     Console.WriteLine($"Третья с начала {num1}");
//     string num2 = Convert.ToString(num[num_len - 3]);
//     Console.WriteLine($"Третья с конца {num2}");

// }


//Второй способ
// Console.WriteLine("Введите число: ");
// string num = Console.ReadLine();
// int num_len = num.Length;
// int n = Convert.ToInt32(num);
// int b;
// int a = n / 100;
// if (a < 1){
//     Console.WriteLine("Третьей цифры нет");
// }
// else{
//     a = a %10;
//     Console.WriteLine($"{n} => {a}");
//     b = n / Convert.ToInt32(Math.Pow(10, (num_len -3)));
//     b = b % 10;
//     Console.WriteLine($"{n} => {b}");
// }


// //Третий способ
// Console.WriteLine("Введите число: ");
// string s = Console.ReadLine();
// if(s.Length < 3){
//     Console.WriteLine("Третьего числа нет");
//     return;
// }

// int i = Convert.ToInt32(s);
// int ThirdFirst = i / (int)Math.Pow(10, s.Length - 3);
// // Console.WriteLine(ThirdFirst);
// ThirdFirst = ThirdFirst - ThirdFirst / 10 * 10;
// Console.WriteLine(ThirdFirst);

// int ThirdLast = i / 100;
// // Console.WriteLine(ThirdLast);
// ThirdLast = ThirdLast - ThirdLast / 10 * 10;
// Console.WriteLine("Для числа: " + i + " Третье число слева это: " + ThirdFirst + " , а Третье число справа это: " + ThirdLast);
// string s = "Привет!";

// for (int i = 0; i == s.Length; i++) {
               
//             Console.Write($"{s[i]} ,");
        
//     }


string s = "Привет!";
int i = 0;
int l = s.Length;
if (i < l)
{
    for (i; i < s.Length; i++){
     Console.Write($"{s[i]} ,");
    }
} 














