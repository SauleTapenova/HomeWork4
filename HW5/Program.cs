// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Polindrom(int num)
{
    int count = 0;
    int a = num;
    int firstNumber = 0;
    int lastNumber = 0; 
      
   while (num > 0)
   {
     num = num / 10;
     count ++;
   }

    while (count > 1)
    {
        int c = count -1;
        int i = Convert.ToInt32(Math.Pow(10, c));
        firstNumber = a / (i);
        a= a - (firstNumber * i);
        lastNumber = a % 10;
        a = a / 10;

        count= count -2;

    }
    if (firstNumber == lastNumber) Console.WriteLine("да");
    else Console.WriteLine("нет");

}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Polindrom( number);
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*double FindDist(double x1,double y1,double z1,double x2,double y2,double z2)
{
    double dist = 0;
    dist = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
    dist = Math.Round(dist, 2);
    return dist;
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(FindDist(x1,y1,z1,x2,y2,z2));
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void FindCub(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine(Math.Pow(count,3));
        count ++;
    }
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindCub(number);
*/