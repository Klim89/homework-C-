/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*void Zadacha6()
{
    Console.Write("Введите число: ");
    string number = Console.ReadLine();

    if (number.Length > 2)
    {
        Console.WriteLine("Третья цифра числа = " + numberText[2]);
    }
    else
    {
        Console.WriteLine("Третья цифра отсутствует");
    }
}
Zadacha6();
*/

void Zadacha6_1()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int number = Math.Abs(number);
    if (number > 99)
    {
        int result = Temp(number);
        Console.WriteLine("Третья цифра числа = " + result);
    }
    else
    {
        Console.WriteLine("Третья цифра отсутствует");
    }
}
Zadacha6_1();


int Temp(int number)
{
    while (number > 999) number /= 10; 
    int temp = number % 10;
    return temp;
}


