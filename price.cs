using System;

class Program
{
    static void Main()
    {
        double price = 1000.0;      // double literal
        double discount = 10.0;     // percentage

        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price: " + finalPrice);
    }
}
