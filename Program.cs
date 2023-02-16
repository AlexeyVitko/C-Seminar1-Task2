//Задача 2. Напишите программу, которая на вход принимает два числа, 
// а на выход выдает, какое из чисел большее, а какое меньшее.
// a=5;  b=7
// a=2;  b=10
// a=-9; b=-3

Console.WriteLine("Ведите число a");
int numbera=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите число b");
int numberb=Convert.ToInt32(Console.ReadLine());

if (numbera >numberb)
{
Console.WriteLine("a=max");
Console.WriteLine("b=min");
}
else
{
 Console.WriteLine("a=min");
 Console.WriteLine("b=max");
}



