using System;

class Program
{
    static void Main()
    {
        int age = 25;
        float temperature = 98.6f;
        char grade = 'A';
        bool isPassed = true;

        Console.WriteLine($"{age} - {age.GetType()}");
        Console.WriteLine($"{temperature} - {temperature.GetType()}");
        Console.WriteLine($"{grade} - {grade.GetType()}");
        Console.WriteLine($"{isPassed} - {isPassed.GetType()}");
    }
}
