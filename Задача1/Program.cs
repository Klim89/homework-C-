// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

void Zadacha01()
{
Console.Write("Введите число 1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_2 == number_1)
{
Console.WriteLine(" Введено неверное число");
}
else if (number_2 > number_1)

{
    Console.WriteLine(number_2  + " - Наибольшее число");
    Console.WriteLine(number_1  + " - Наименьшее число");
}
else
{
    Console.WriteLine(number_1  + " - Наибольшее число");
    Console.WriteLine(number_2  + " - Наименьшее число");
}
}

Zadacha01();
