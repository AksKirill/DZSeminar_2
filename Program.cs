// // Задача 10 - программа, которая на вход принимает трехзначное число и на выход дает вторую цифру
// Console.WriteLine("введите трехзначное число a: ");
// int a=Convert.ToInt32(Console.ReadLine());

// int b=a/10;
// int c=a/100;
// int d=b-c*10;

// Console.WriteLine("Средняя цифра: "+d);

//////////////////////////////////////////////////////////////
// //Задача 13 - программа находит третью цифру числа или сообщает, что ее нет

// Console.WriteLine("введите число: ");
// int a=Convert.ToInt32(Console.ReadLine());

// string b=Convert.ToString(a);
// Console.WriteLine(b);

// if (b.Length>2) 
// {
// Console.WriteLine("Третья цифра " +b[2]);
// }
// else 
// {
// Console.WriteLine("Третьей цифры нет");
// }

//////////////////////////////////////////////////////////////
// Задача 15 - программа после ввода исла проверяет его соответствие выходному дню

Console.WriteLine("Программа проверяет соответсиве числа дню недели. Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());

 if (a==6) 
{
  Console.WriteLine("этот день суббота");
}
else if (a==7)
{
  Console.WriteLine("этот день воскресение");
}
else if (a>=1 && a<=6)
{
  Console.WriteLine("этот день будний");
}
else
{
  Console.WriteLine("это не день недели");
}
//////////////////////////////////////////////////////////////
