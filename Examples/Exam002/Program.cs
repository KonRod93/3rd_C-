// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Формула вычисления расстояния между двумя точками в пространстве A(xa, ya, za) и B(xb, yb, zb) в пространстве: AB = √(xB - xB)^2 + (yB - yA)^2 + (zB - zA)^2

Console.WriteLine("Введите координату X точки А");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X точки B");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
double zB = Convert.ToDouble(Console.ReadLine());

double segmentLength = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

Console.WriteLine($"Длина отрезка {segmentLength}");