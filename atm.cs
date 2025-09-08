public class ATMSystem
{
    private const int CorrectPIN = 1234;

    public void Run()
    {
        int attempts = 0;
        while (attempts < 3)
        {
            Console.Write("🔢 Enter your PIN: ");
            string input = Console.ReadLine();
            int enteredPIN;

            if (int.TryParse(input, out enteredPIN) && enteredPIN == CorrectPIN)
            {
                Console.WriteLine("✅ Access Granted");
                return;
            }
            else
            {
                Console.WriteLine("❌ Incorrect PIN");
                attempts++;
            }
        }
        Console.WriteLine("🚫 Card Blocked");
    }
}
