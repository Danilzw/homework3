// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

System.Console.WriteLine("Введите первую координату x:");
int first = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите вторую координату x:");
int first1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите первую координату z:");
int first2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите первую координату y:");
int second = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите вторую координату y:");
int second1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите вторую координату z:");
int second2 = int.Parse(Console.ReadLine());

double number(int first1,int first,int second2,int second1, int second,int first2)
{
    int x = first1 - first;
    int y = second1 - second;
    int z = second2 - first2;
    double x1 = Math.Pow(x,2);
    double y1 = Math.Pow(y,2);
    double z1 = Math.Pow(z,2);
    double result1 = x1 + y1 + z1;
    double result = Math.Sqrt(result1);
    return result;
}

double result = number(first,first1,first2,second,second1,second2);
System.Console.WriteLine(result);