namespace RockPaperScissorsGame;

class Program
{
    static void Main(string[] args)
    {
        string playerInput, cpuInput;
        int randomInt;

        bool playAgain = true;

        while (playAgain)
        {
            int playerScore = 0;
            int cpuSCORE = 0;

            while (playerScore < 3 && cpuSCORE < 3)
            {
                Console.WriteLine("Choose ROCK, PAPER, or SCISSORS:");
                playerInput = Console.ReadLine();
                playerInput = playerInput.ToUpper();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        cpuInput = "ROCK";
                        Console.WriteLine("The computer chose ROCK");
                        if (playerInput == "ROCK")
                        {
                            Console.WriteLine("It's a draw! You both chose rock.");
                        }
                        else if (playerInput == "PAPER")
                        {
                            Console.WriteLine("YOU WIN!\n\n");
                            playerScore++;
                        }
                        else if (playerInput == "SCISSORS")
                        {
                            Console.WriteLine("You lose! The computer chose rock!");
                            cpuSCORE++;
                        }

                        break;

                    case 2:
                        cpuInput = "PAPER";
                        Console.WriteLine("Computer chose PAPER");
                        if (playerInput == "PAPER")
                        {
                            Console.WriteLine("It's a draw! You both chose paper.");
                        }
                        else if (playerInput == "ROCK")
                        {
                            Console.WriteLine("Computer wins! Paper covers rock!");
                            cpuSCORE++;
                        }
                        else if (playerInput == "SCISSORS")
                        {
                            Console.WriteLine("You win! Scissors cut paper!");
                            playerScore++;
                        }

                        break;

                    case 3:
                        cpuInput = "SCISSORS";
                        if (playerInput == "PAPER")
                        {
                            Console.WriteLine("You lose! The computer chose scissors!");
                            cpuSCORE++;
                        }
                        else if (playerInput == "ROCK")
                        {
                            Console.WriteLine("You win! The computer chose scissors!");
                            playerScore++;
                        }
                        else if (playerInput == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw! You both chose scissors.");
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid entry. Please only enter ROCK, PAPER, or SCISSORS.");
                        break;
                }

                Console.WriteLine("\n\nSCORES: \tYOU:\t{0}\tCOMPUTER\t{1}", playerScore, cpuSCORE);
            }

            if (playerScore == 3)
            {
                Console.WriteLine("You won! Great job!");
            }

            else if (cpuSCORE == 3)
            {
                Console.WriteLine("You lose! The computer won.");
            }
            else
            {
            }

            Console.WriteLine("Do you want to play again? (y/n)");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                playAgain = true;
                Console.Clear();
            }
            else if (loop == "n")
            {
                playAgain = false;
            }
            else
            {

            }

        }
    }
}



        
            