// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

void Zadacha03_1()
{
    Console.Write("Введите число N: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number2 == 1)
    {
        Console.WriteLine(" Введено неверное число");
    }
    for (int i = 2; i <= number2; i = i + 2)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}


void Zadacha03_2()
{
    Console.Write("Введите число N: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int i = 2;
    if (number2 == 1)
    {
        Console.WriteLine(" Введено неверное число");
    }
    
    while (i <= number2)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
        i = i + 2;
    }
}


//Zadacha03_1();
Zadacha03_2();

