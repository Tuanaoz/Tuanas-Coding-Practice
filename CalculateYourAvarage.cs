using System;

class CalculateYourAvarage
{
    public static void Main(string[] args)
    {
        Console.WriteLine("please enter your full name");
        string isim = Console.ReadLine();
        Console.WriteLine("your first exam grade");
        int not1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("your second exam grade");
        int not2 = Convert.ToInt32(Console.ReadLine());
        int ort = (not1 + not2) / 2;

        if (ort <= 50)
        {
            Console.WriteLine("FF");
        }
        else if (ort <= 60)
        {
            Console.WriteLine("DD");
        }
        else if (ort <= 70)
        {
            Console.WriteLine("CC");
        }
        else if (ort <= 85)
        {
            Console.WriteLine("BB");
        }
    }
}