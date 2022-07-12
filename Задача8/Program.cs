/* Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.
*/

void Zadacha8()
{
    Console.Write("Введите длину стороны 1 треугольника, см: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите длину стороны 2 треугольника, см: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите длину стороны 3 треугольника, см: ");
    int number3 = Convert.ToInt32(Console.ReadLine());

    
    /*if (number1+number2>number3 || number1+number3> number2 || number2+number3> number1)
    {
        Console.WriteLine("Введены неверные длины сторон");
    }

    else*/
    if(number1 == number2 || number1 == number3 || number2 == number3)
    {
        Console.WriteLine("Треугольник с заданными сторонами является равнобедренным");
    }
    else
    {
        Console.WriteLine("Треугольник с заданными сторонами не является равнобедренным");
    }
}

Zadacha8();
