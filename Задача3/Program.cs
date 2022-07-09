// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number_2; i = i + 2)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}

Console.Write("Введите число N: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
int i  = 2;
while (i <= number_2)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
i = i + 2;
}



