double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x1 - x2;
    double yDistance = y1 - y2;
    double zDistance = z1 - z2;
    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
}
double xA, yA, zA, xB, yB, zB;
Console.WriteLine("Введите координату x для точки A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y для точки A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z для точки A: ");
zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x для точки B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y для точки B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z для точки B: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Растояние между точками А и В равно: " + Distance(xA, yA, zA, xB, yB, zB));