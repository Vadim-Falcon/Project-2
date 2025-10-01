using System;

class Program
{
    static void Main()
    {
        //Змінна 1
        Console.WriteLine("Введiть a (long): ");

        long a = long.Parse(Console.ReadLine());

        Console.WriteLine("Введiть x (long): ");

        long x = long.Parse(Console.ReadLine());

        Console.WriteLine("Введiть t (double): ");
        
        double t = double.Parse(Console.ReadLine());

        long r1 = (long)(a * x * t);

        long r2 = (long)(a * (a + x) / t);

        double r3 = a / t * (a + x / t);

        Console.WriteLine("result1 = " + r1);

        Console.WriteLine("result2 = " + r2);

        Console.WriteLine("result3 = " + r3.ToString("F5"));

        //Змінна 2
        Console.WriteLine("Введiть a1 (byte): ");

        byte a1 = byte.Parse(Console.ReadLine());

        Console.WriteLine("Введiть b (double): ");

        double b = double.Parse(Console.ReadLine());

        byte r21 = (byte)(a * b);  

        double r22 = a / b + 7;

        Console.WriteLine("result21 = " + r21);

        Console.WriteLine("result22 = " + r22.ToString("F8"));
    }

}
