//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//5 -> 1, 8, 27, 64, 125
System.Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());

for(int i =1;i<number+1;i++)
{
    System.Console.WriteLine(i*i*i);
}