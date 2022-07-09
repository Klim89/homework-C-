// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2 && number_1 > number_3)
{
Console.WriteLine("Максимальное число = " + number_1); 
}
else if (number_2 > number_3)
{
Console.WriteLine("Максимальное число = " + number_2);
}
else
{
Console.WriteLine("Максимальное число = " + number_3);
}