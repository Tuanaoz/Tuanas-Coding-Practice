using System;

class HowFitAreYou
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your height:");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your weight:");
        double weight = Convert.ToDouble(Console.ReadLine());
        double ke;
        ke = weight / height * height;

        if (ke < 18.5)
        {
            Console.WriteLine("You are under weight.");
        }
        else if (ke <= 25)
        {
            Console.WriteLine("You are normal.");
        }
        else if (ke <= 30)
        {
            Console.WriteLine("You are fat.");
        }
        else
        {
            Console.WriteLine("You are obese.");
        }
    }
}
