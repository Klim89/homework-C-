// Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

void Zadacha8()
{
    Console.Write("Введите длину стороны 1 треугольника, см: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите длину стороны 2 треугольника, см: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите длину стороны 3 треугольника, см: ");
    int number3 = Convert.ToInt32(Console.ReadLine());
    
    if (number1+number2<number3 || number1+number3<number2|| number2+number3<number1)
    {
        Console.WriteLine("Введены неверные длины сторон");
    }

    else if(number1 == number2 || number1 == number3 || number2 == number3)
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

//DateTime _Dt = new DateTime(1984, 9, 11);
//Console.WriteLine(DateTime.Now.Subtract(_Dt));
//Console.ReadKey();

//Console.Write("Введите дату рождения в формате ДД.ММ.ГГГГ: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите длину стороны 1 треугольника, см: ");
//string = new DateTime(Console.ReadLine());
// The following method call displays 1/1/0001 12:00:00 AM.
//string numberText = Convert.ToString(number);

//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.

void Zadacha8_1()
{
Console.Write("Введите количество месяцев для расчета депозита: ");
int n = Convert.ToInt32(Console.ReadLine());
double dep = 1000;
double proz = 0.015;
for (int i = 1; i <= n; i=i+1)
    {
        dep = dep*proz+dep;
    }
Console.WriteLine(dep);
}  
//Zadacha8_1();


//Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.

int a = 1234;
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
    b[i] = int.Parse(str[i].ToString());
}