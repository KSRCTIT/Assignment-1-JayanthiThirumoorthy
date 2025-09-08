using System;

public class ElectionBooth
{
    // Function to check eligibility
    public void CheckEligibility(int age)
    {
        if (age >= 18)
        {
            Console.WriteLine("✅ Eligible to Vote");
        }
        else
        {
            Console.WriteLine("❌ Not Eligible");
        }
    }

    // Main runner for 5 people
    public void Run()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"👤 Person {i}, enter your age: ");
            string input = Console.ReadLine();
            int age;

            // Validate input
            if (int.TryParse(input, out age))
            {
                CheckEligibility(age);
            }
            else
            {
                Console.WriteLine("⚠️ Invalid input. Please enter a valid number.");
                i--; // Retry this person
            }
        }
    }
}
