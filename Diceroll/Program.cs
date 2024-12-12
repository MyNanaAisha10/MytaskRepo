namespace TempDice;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of time you want to p");
        string playerChoice;
         //DiceEngine(); // Method 1
        
        {
            //DiceEngine();// Method 1
            Console.WriteLine("Do you want to roll the dice again? \nEnter 'Y' to continue or 'N' to Exit");
            playerChoice = Console.ReadLine()!;
            while (playerChoice!.ToUpper() != "Y" && playerChoice.ToUpper() != "N")
            {
                Console.WriteLine("Invalid player choice . Enter valid choice 'Y' or 'N'");
                playerChoice = Console.ReadLine()!;
            }
        }   while (playerChoice.ToUpper() == "Y");
            Console.WriteLine("Game ended");
    }
}
