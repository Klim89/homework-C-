/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

void Zadacha5()
{
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int tens = number / 10;
    int hungs = number / 100;

    if (number > 100 && number < 1000)
    {
    int resultNumber = tens - hungs * 10;
    Console.WriteLine("Вторая цифра трехзначного числа = " + resultNumber);
    }
    else 
    {
        Console.WriteLine("Введите трехзначное число");
    }
}
Zadacha5();
