/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write($"Ведите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number >= 100000)
{
   Console.Write($"Ошибка!!! число {number} не пятизначное. Введите пятизначное число: ");
   return; 
}

int num1 = number / 10000;
int num2 = number /1000 % 10;
int num4 = number /10 % 10;
int num5 = number % 10;
////// Не обязательные строки
/*
Console.WriteLine($"Первая цифра {number} - {num1}");
Console.WriteLine($"Вторая цифра {number} - {num2}");
Console.WriteLine($"Четвертая цифра {number} - {num4}");
Console.WriteLine($"Пятая цифра {number} - {num5}");
*/
if (num1==num5 & num2==num4)
{
    Console.WriteLine($"Число {number} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом.");
}
