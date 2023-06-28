using static System.Formats.Asn1.AsnWriter;

namespace RockPaperScissorsGame;
class Program
{
    const string ROCK = "Rock";
    const string PAPER = "Paper";
    const string SCISSORS = "Scissors";
    const string YES = "Yes";
    const string NO = "No";


    static void Main(string[] args)
    {
        //Only code the user sees
        Game.GameHandler(Game.PlayerChoice(),Game.ComputerChoice());

    }

    public class Game
    {
        public int score { get; set; } = 0;

        public static void GameHandler(string playerChoice, string computerChoice)
        {
            //Define variables
            string result;

            Console.WriteLine("You chose: " + playerChoice);
            Console.WriteLine("Computer chose: " + computerChoice);

            if (playerChoice == ROCK && computerChoice == SCISSORS || playerChoice == PAPER && computerChoice == ROCK || playerChoice == SCISSORS && computerChoice == PAPER)
            {
                result = "You win!";
                //score++;
            }
            else if (playerChoice == SCISSORS && computerChoice == ROCK || playerChoice == ROCK && computerChoice == PAPER || playerChoice == PAPER && computerChoice == SCISSORS)
            {
                result = "You lose!";
                //score = 0;
            }
            else
            {
                result = "It's a draw";
                //score = 0;
            }
            Console.WriteLine($"{result} Your score is: {null}");
            ContinueHandler();
        }

        public static string PlayerChoice()
        {
            string playerChoice;
            do
            {
                Console.Write("Enter [Rock|Paper|Scissors]: ");
                playerChoice = Console.ReadLine();
            } while (playerChoice != ROCK && playerChoice != PAPER && playerChoice != SCISSORS);
            return playerChoice;
        }
        public static string ComputerChoice()
        {
            string[] possibleComputerChoices = { "Rock", "Paper", "Scissors" };
            Random random = new Random();
            return possibleComputerChoices[random.Next(0, 3)];
        }

        private static void ContinueHandler()
        {
            string wantToContinue;
            do
            {
                Console.Write("Enter [Yes|No]: ");
                wantToContinue = Console.ReadLine();
            } while (wantToContinue != YES && wantToContinue != NO);

            if (wantToContinue == YES) GameHandler(PlayerChoice(), ComputerChoice());
            else Console.WriteLine("Well Played!");
        }
    }
}

