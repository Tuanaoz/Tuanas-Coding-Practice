using System;
class TotalNumber
{
    public static void Main(string[] args)
    {

        int x, y;

        Console.WriteLine("Enter a number:");

        y = Convert.ToInt32(Console.ReadLine());

        int total = 0;

        for (x = 1; x <= y; x++)
        {

            total = total + x;

        }

        Console.WriteLine(total);

    }

}