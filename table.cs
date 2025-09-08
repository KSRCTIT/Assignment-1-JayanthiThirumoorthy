public class MultiplicationTable
{
    public void PrintTable(int number)
    {
        Console.WriteLine($"📊 Multiplication Table for {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }

    public void Run()
    {
        string choice;
        do
        {
            Console.Write("🔢 Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            PrintTable(num);

            Console.Write("🔁 Want another table? (Y/N): ");
            choice = Console.ReadLine().ToUpper();
        } while (choice == "Y");
    }
}
