// ====Building a Dice Roll Game====

// We need a three die to roll. Understanding that each die has six faces (1 - 6).

// The dice are rolled together, the sum of each die is calculated to arrive at a result. 

// If the two dice out of the total three has the same value, 2 extra point (a double) is awarded and added to the total sum rolled.

// If the all dice have the same value, 6 extra point (a triple) is awarded and added to the total sum rolled.

// If the total calculated after a roll is less than 15pts. Print Message in this format "Total Point: 9 - You failed to hit the threshold" Otherwise print: "Total point 17 - Welldone boss"

// Console.ForegroundColor();

public class DiceRoll
{
    public static void DiceEngine()
    {
        Random random = new();

        int dice1 = random.Next(1, 7);
        int dice2 = random.Next(1, 7);
        int dice3 = random.Next(1, 7);
        const int doubleScore = 2;
        const int tripleScore = 6;
        const int tresholdPoint = 15;

        // DiceRoll.PrintColoredOutput($"Dice 1: {dice1} Dice 2: {dice2} Dice 3: {dice3}");
        
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


    public void PrintColoredOutput(string inputString)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(inputString);
        Console.ResetColor();
        Console.WriteLine();
    }
}