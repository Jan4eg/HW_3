/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

double Read(string arg)
{
    System.Console.Write($"Введите {arg}: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

double x1 = Read("x1");
double y1 = Read("y1");
double z1 = Read("z1");
double x2 = Read("x2");
double y2 = Read("y2");
double z2 = Read("z3");

void Calc(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double a = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
    System.Console.WriteLine(a);
}

Calc(x1, y1, z1, x2, y2, z2);