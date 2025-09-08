public class QuizScoreTracker
{
    public void Run()
    {
        int score = 50;
        Console.WriteLine(" Starting score: " + score);

        score += 10;
        Console.WriteLine("Correct answer (+10): " + score);

        score -= 5;
        Console.WriteLine(" Wrong answer (-5): " + score);

        score *= 2;
        Console.WriteLine("🎁 Bonus round (x2): " + score);

        score -= 3;
        Console.WriteLine("🗨️ No comment (-3): " + score);

        score -= 7;
        Console.WriteLine("⏭️ Skipped question (-7): " + score);
    }
}
