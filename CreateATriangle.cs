using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Assing first side of the triangle:");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Assing second side of the triangle:");
        int side2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Assign third side of the triangle:");
        int side3 = Convert.ToInt32(Console.ReadLine());

        if (side1 == side2 & side1 == side3 & side2 == side3)
        {
            Console.WriteLine("It is an equilateral triangle.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("It is an isosceles triangle.");
        }
        else
        {
            Console.WriteLine("It is neither an equilateral triangle nor isosceles triangle.");
        }
    }
}