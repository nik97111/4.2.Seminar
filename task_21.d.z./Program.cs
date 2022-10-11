// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// А (3,6,8); B (2,1,-7) -> 15.84
// А (7,-5,0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки A(x): ");
int coordinatesFirstPointX = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A(y): ");
int coordinatesFirstPointY = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A(z): ");
int coordinatesFirstPointZ = int.Parse(Console.ReadLine());
Console.Write("Введите кооррдинаты точки B(x): ");
int coordinatesSecondPointX = int.Parse(Console.ReadLine());
Console.Write("Введите кооррдинаты точки B(y): ");
int coordinatesSecondPointY = int.Parse(Console.ReadLine());
Console.Write("Введите кооррдинаты точки B(z): ");
int coordinatesSecondPointZ = int.Parse(Console.ReadLine());

int x = Math.Abs(coordinatesFirstPointX - coordinatesSecondPointX);
int y = Math.Abs(coordinatesFirstPointY - coordinatesSecondPointY);
int z = Math.Abs(coordinatesFirstPointZ - coordinatesSecondPointZ);

int sqrX = x * x;
int sqrY = y * y;
int sqrZ = z * z;
double res = Math.Sqrt(sqrX + sqrY + sqrZ);
Console.WriteLine($"Расстояние между точками: {res}");
