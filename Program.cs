// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var result = new DiceRoll();
result.DiceEngine();
public class DiceRoll
{
    public  void DiceEngine()
    {
        Random random = new();

        int dice1 = random.Next(1, 7);
        int dice2 = random.Next(1, 7);
        int dice3 = random.Next(1, 7);
        const int doubleScore = 2;
        const int tripleScore = 6;
        const int tresholdPoint = 15;

        Console.WriteLine($"Dice 1: {dice1} Dice 2: {dice2} Dice 3: {dice3}");

        int totalRolled = dice1 + dice2 + dice3; // D1: 1, D2: 5, D3: 1

        if (dice1 == dice2 && dice1 == dice3)
        {
            totalRolled += tripleScore;
            Console.WriteLine($"You rolled a triple. You have been awarded +{tripleScore} points");
        }
        else if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3)
        {
            totalRolled += doubleScore;
            Console.WriteLine($"You rolled a double. You have been awarded +{doubleScore} points");
        }

        string finalMessage = (totalRolled < tresholdPoint) ? $"Total Point: {totalRolled} - You failed to hit the threshold!" : $"Total Point: {totalRolled} - Welldone boss!";

        Console.WriteLine(finalMessage);
    }
}

Private static (int totalPoint, string message) DiceEngine()
{
    Random random = new();

    int dice1 = random.Next(1, 7);
    int dice2 = random.Next(1, 7);
    int dice3 = random.Next(1, 7);
    const int doubleScore = 2;
    const int tripleScore = 6;
    const int tresholdPoint = 15;

    StringBuilder string = new();

    StringBuilder stringBuilder new();

    stringBuilder.Append($"Dice 1: {dice1} Dice 2: {dice2} Dice 3: {dice3}\n");

    int totalRolled = dice1 + dice2 + dice3;

    if (dice1 == dice2 && dice2 == dice3)
    {
        totalRolled += triplescore;
        stringBuilder.Append()
    }
}