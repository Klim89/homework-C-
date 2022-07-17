// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Zadacha10()
{
    Console.WriteLine("Введите координаты первой точки");
    double x1 = Convert.ToInt32(Console.ReadLine());
    double y1 = Convert.ToInt32(Console.ReadLine());
    double z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки");
    double x2 = Convert.ToInt32(Console.ReadLine());
    double y2 = Convert.ToInt32(Console.ReadLine());
    double z2 = Convert.ToInt32(Console.ReadLine());
    
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine("Расстояние между точками:" + " " + Math.Round(dist,2));

}

Zadacha10();
