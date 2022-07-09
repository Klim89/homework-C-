// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_1 = 1;

for (int i = number_1; i <= number_2; i++)
    {
    if (i % 2 == 0) 
    {
        Console.Write(i + " ");
    }
    }
     
    

