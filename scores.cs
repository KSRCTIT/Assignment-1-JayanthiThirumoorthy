public class ScoreComparison
{
    public void Run()
    {
        int playerA = 20, playerB = 15;
        Console.WriteLine(" Player A scored more than B: " + (playerA > playerB));
        Console.WriteLine(" Scores are equal: " + (playerA == playerB));
        Console.WriteLine(" Did any player fail to grant other: " + (playerA < playerB || playerB < playerA));
    }
}