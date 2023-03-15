//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да

System.Console.WriteLine("Введите ваше число:");
int number = int.Parse(Console.ReadLine());

bool allowed(int number)
{
    if(number > 99999 ^ number < 9999)
    {
        System.Console.WriteLine("Ваше число не пятизначное");
        return false;
    }
    return true;
}

if(allowed(number))
{
   int number1 = number % 10;
   int number2 = number / 100 / 10 / 10;
   int number3 = number % 100 / 10;
   int number4 = number / 10 / 10 / 10 % 10;

   if(number1 == number2)
   {
        if(number3 == number4)
        {
            System.Console.WriteLine("Все ок");
        }
   } 
   else
   {
    System.Console.WriteLine("Не ок");
   }
}
