public class StudentEvaluation
{
    public double CalculateAverage(int[] marks)
    {
        int total = 0;
        foreach (int mark in marks)
        {
            total += mark;
        }
        return total / 5.0;
    }

    public void Run()
    {
        int[] marks = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"📚 Enter mark for subject {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        double avg = CalculateAverage(marks);
        Console.WriteLine($"📈 Average: {avg}");

        if (avg >= 40)
            Console.WriteLine("✅ Passed");
        else
            Console.WriteLine("❌ Failed");
    }
}
