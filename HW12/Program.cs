//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNum(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNum(n -1);
}
ShowNum(8);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumDistance(int m, int n )
{
    if(m > n) return SumDistance(m - 1,n) + m;

    if(m < n) return SumDistance(m ,n-1) + n;

    if(m==n) return m;

    return 0;
}

 int num = SumDistance(4,8);
 Console.WriteLine(num);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    {
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
    }
 }
 int num = Akkerman (3,2);
 Console.WriteLine(num);