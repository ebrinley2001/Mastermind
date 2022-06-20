using Mastermind.Bc;

MastermindServicesBc ms = new MastermindServicesBc();

bool x = true;

while (x)
{
    ms.PlayGame();

    Console.WriteLine("Would you like to play again? y / n");
    string choice = Console.ReadLine();

    if (choice == "n")
    {
        x = false;
    }
}

