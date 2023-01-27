// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Координаты первой точки: ({X1};{Y1};{Z1})");
Console.WriteLine();
Console.Write("Введите X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Координаты первой точки: ({X2};{Y2};{Z2})");
int D = Convert.ToInt32(Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2)));
Console.WriteLine();
Console.Write($"Расстояние между точками ({X1};{Y1};{Z1}) и ({X2};{Y2};{Z2}) = {D}");

