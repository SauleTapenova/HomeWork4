// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int FindSecondDigit( int num)
{
    int a = num / 10;
    int b = a % 10;
    return b;
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int SecondDigit = FindSecondDigit( number);

Console.WriteLine("Second digit: " + SecondDigit);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void FindThirddDigit(int num)
{
    int count = 0;
    int a = num;
    int b = 0;
    int c =0;
  
   while (num > 0)
   {
     num = num / 10;
     count ++;
   }
   
   if(count > 2)
   {
    count =count -2;
    int i = Convert.ToInt32(Math.Pow(10, count));
    c = a / (i);
    b = a - (c*i);
    b = b / (i/10);

    Console.WriteLine(b); 
   }
   else
   {
    Console.WriteLine("Третьей цифры нет"); 
   }
  
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindThirddDigit(number);
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void HolidaysDay (int num)
{
  if (num==6 || num==7)
  {
    Console.WriteLine("Да");
  }
  else
  {
    Console.WriteLine("Нет");
  }
}
Console.Write("Input day's number: ");
int number = Convert.ToInt32(Console.ReadLine());
HolidaysDay(number);
*/
