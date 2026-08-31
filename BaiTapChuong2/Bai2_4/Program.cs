// See https://aka.ms/new-console-template for more information
Console.WriteLine("Phuong trinh ax^2 + bx + c = 0");
double a, b, c;
Console.Write("Nhap a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Nhap b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Nhap c: ");
c = double.Parse(Console.ReadLine());

if (a == 0)
{
    if (b == 0)
    {
        if (c == 0)
        {
            Console.WriteLine("Phuong trinh vo so nghiem");
            return;
        }
        Console.WriteLine("Phuong trinh vo nghiem");
        return;
    }
    Console.WriteLine("x = " + (-c / b));
    return;
}
else
{
    double delta = b * b - 4 * a * c;
    if (delta == 0)
    {
        Console.WriteLine("x1 = x2 = " + (-b / (2*a)));
    }
    else if (delta < 0)
    {
        Console.WriteLine("Phuong trinh vo nghiem");
    }
    else
    {
        Console.WriteLine("x1 = "+ ( (-b+ Math.Sqrt(delta))/(2*a) ));
        Console.WriteLine("x2 = " + ((-b - Math.Sqrt(delta)) / (2 * a)));
    }
}

//if (-0 == 0) Console.WriteLine("0");