/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
////////////
//  Решил через while

Console.Write($"Данно число: ");
int N = new Random().Next(1, 10);
int i = 1;
Console.WriteLine(N);
Console.Write($"Кубы множества от 1 до {N}: ");
while (i <= N)
{
    Console.Write($"{Math.Pow(i,3)} ");
    i ++;
}
//////////////////////////
//Вариант, как на занятии
int RandomNumber(int min, int max) 
{
    int result = new Random().Next(min,max+1);
    return result;
   
} 
void Print (string text)
{ 
    Console.WriteLine(text); 
} 
void GetSquare(int rand){ 
    for (int i=1;i<=rand;i++)
    { 
        Console.Write($"{Math.Pow(i,3)}, "); 
    } 
} 
int rand = RandomNumber(1, 10); 
Print($"{rand}"); 
GetSquare(rand);
