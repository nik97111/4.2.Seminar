// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A(3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты точки A(x): ");
int coordinatesFirstPointX = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A(y): ");
int coordinatesFirstPointY = int.Parse(Console.ReadLine());
Console.Write("Введите кооррдинаты точки B(x): ");
int coordinatesSecondPointX = int.Parse(Console.ReadLine());
Console.Write("Введите кооррдинаты точки B(y): ");
int coordinatesSecondPointY = int.Parse(Console.ReadLine());

int ac = Math.Abs(coordinatesFirstPointY - coordinatesSecondPointY);
int bc = Math.Abs(coordinatesFirstPointX - coordinatesSecondPointX);
int sqrAC = ac * ac;
int sqrBC = bc * bc;
double res = Math.Sqrt(sqrAC + sqrBC);
Console.WriteLine($"Расстояние между точками: {res}");



