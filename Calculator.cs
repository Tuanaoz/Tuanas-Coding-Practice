using System;

class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter and interger:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another integer:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What do you want to do?(Enter either one of these: +,-,*,/,%)");
        string islem = Console.ReadLine();
        if (islem == "+")
        {
            Console.WriteLine("Addition=" + (sayi1 + sayi2));
        }
        else if (islem == "-")
        {
            Console.WriteLine("Substruction=" + (sayi1 - sayi2));
        }
        else if (islem == "*")
        {
            Console.WriteLine("Multiplication=" + (sayi1 * sayi2));
        }
        else if (islem == "/")
        {
            Console.WriteLine("Division=" + (sayi1 / sayi2));
        }
        else if (islem == "%")
        {
            Console.WriteLine("Modulo=" + (sayi1 % sayi2));
        }
    }
}
}
