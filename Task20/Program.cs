// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 3D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
double Length(int xA, int yA, int xB, int yB, int zA, int zB)
{
    double DistanceBetweenPoints = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
    return DistanceBetweenPoints;
} 

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinateB = Convert.ToInt32(Console.ReadLine());

double result = Length(xCoordinateA, yCoordinateA, zCoordinateA, xCoordinateB, yCoordinateB, zCoordinateB);
Console.WriteLine($"Расстояние между точками -> {Math.Round(result, 2, MidpointRounding.ToZero)}");