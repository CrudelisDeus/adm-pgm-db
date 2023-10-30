/*
   Швиденко Дмитро Юрійович (ІШІ-501)

   task:
   23 в списку був / 3 - варіант
   Описати клас, що представляє трикутник. Передбачити методи для створення об’єктів,
   переміщення на площині, зміни розмірів і обертання на заданий кут. При неможливості
   побудови трикутника викидається виключення.
   Написати програму, яка демонструвала б всі розроблені елементи класу.
*/

using System;

class Triangle
{
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("[!] According to the given sides, it is impossible to construct a triangle");
        }

        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void Move(double dx, double dy)
    {
        Console.WriteLine($"[>] Moved to ({dx}, {dy})");
    }

    public void Resize(double factor)
    {
        Console.WriteLine($"[>] Resize by factor {factor}");
    }

    public void Rotate(double angle)
    {
        Console.WriteLine($"[>] Reversed to {angle} degrees");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Triangle triangle = new Triangle(3, 4, 5);

            triangle.Move(1, 2);
            triangle.Resize(1.5);
            triangle.Rotate(45);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
