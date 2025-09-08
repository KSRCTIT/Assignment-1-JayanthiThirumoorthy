using System.Text.RegularExpressions;

public class NameValidator
{
    public bool IsValidName(string name)
    {
        return Regex.IsMatch(name, @"^[A-Za-z\s]+$");
    }

    public void Run()
    {
        Console.Write("🧾 Enter your name: ");
        string name = Console.ReadLine();

        if (IsValidName(name))
            Console.WriteLine("✅ Name is valid for ID card");
        else
            Console.WriteLine("❌ Invalid name. No digits or special characters allowed.");
    }
}
