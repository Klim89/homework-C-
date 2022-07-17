// Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

void Zadacha8()
{
    Console.Write("Введите длину стороны 1 треугольника, см: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите длину стороны 2 треугольника, см: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите длину стороны 3 треугольника, см: ");
    int number3 = Convert.ToInt32(Console.ReadLine());

    if (number1 + number2 < number3 && number1 + number3 < number2 && number2 + number3 < number1)
    {
        Console.WriteLine("Введены неверные длины сторон");
    }
    else if (number1 == number2 || number1 == number3 || number2 == number3)
    {
        Console.WriteLine("Треугольник с заданными сторонами является равнобедренным");
    }
    else
    {
        Console.WriteLine("Треугольник с заданными сторонами не является равнобедренным");
    }
}

//Zadacha8();

//Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.

void Zadacha8_2()
{
    Random rand = new Random();
    int day = rand.Next(1, 26);
    int month = rand.Next(1, 13);
    int year = rand.Next(2000, 2022);
    int age = 2022 - year;
    Console.WriteLine($"Человек родился {day}.{month}.{year}");
    if (month > 6 || (month == 6 && day > 1))
    {
        age--;
    }
    Console.WriteLine("Возраст человека: " + age);
}

//Zadacha8_2();

//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.

void Zadacha8_3()
{
    Random rand = new Random();
    double dep = 1000;
    int month = rand.Next(10, 1000);
    for (int i = 0; i < month; i++)
    {
        dep *= 1.015;
    }
    Console.WriteLine(
        $"Сумма депозита через {month} месяца (-ев) составит {Math.Round(dep, 2)} рублей (-я)"
    );
}

//Zadacha8_3();


//Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.

void Zadacha8_4()
{
    int number = 697284105;
    int max = -1;
    int min = 10;
    int positionMax = 0;
    int positionMin = 0;
    int count = 1;
    Console.Write($"В числе {number} ");

    while (number > 0)
    {
        int digit = number % 10;
        if (digit > max)
        {
            max = digit;
            positionMax = count;
        }
        else if (digit < min)
        {
            min = digit;
            positionMin = count;
        }
        count++;
        number /= 10;
    }

    if (positionMax > positionMin)
    {
        Console.WriteLine($"цифра {max} стоит левее цифры {min}");
    }
    else
    {
        Console.WriteLine($"цифра {min} стоит левее цифры {max}");
    }
}

Zadacha8_4();
