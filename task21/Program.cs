//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату точки х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коордитату точки Z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Х2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки z2");
int z2 = Convert.ToInt32(Console.ReadLine());
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
//Math.Round ( ,2) округление
double s =Convert.ToDouble(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)));
Console.WriteLine($"Расстояние между точками = {Math.Round (s,2)}");
