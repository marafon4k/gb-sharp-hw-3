// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Enter point X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter point X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double LongXY(int x1n, int y1n, int z1n, int x2n, int y2n, int z2n)
{
    return Math.Sqrt((x1n - x2n) * (x1n - x2n) + (y1n - y2n) * (y1n - y2n) + (z1n - z2n) * (z1n - z2n));
    // return Math.Sqrt((x1n - x2n) * (x1n - x2n) + (y1n - y2n) * (y1n - y2n) + (z1n - z1n) * (z1n - z1n));
}

double result = LongXY(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(result, 2));