// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Zadacha9()
{
    Console.Write("Введите пятизначное число: ");
    string number = Console.ReadLine();

    if (number.Length != 5)
    {
        Console.WriteLine("Введено неверное число, введите пятизначное число");
    }
    else if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine(number + " - является палиндромом");
    }
    else
    {
        Console.WriteLine(number + " - не является палиндромом");
    }
}

//Zadacha9();

void Zadacha9_1()
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int first = number / 10000;
    int second = (number / 1000) % 10;
    int fourth = (number % 100) / 10;
    int fifth = number % 10;

    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Введено неверное число, введите пятизначное число");
    }
    else if ((first - fifth) == 0 && (second - fourth) == 0)
    {
        Console.WriteLine(number + " - является палиндромом");
    }
    else
    {
        Console.WriteLine(number + " - не является палиндромом");
    }
}
Zadacha9_1();
