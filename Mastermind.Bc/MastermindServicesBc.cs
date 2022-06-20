using System;

namespace Mastermind.Bc
{
    public class MastermindServicesBc
    {
        Random random = new Random();

        public void PlayGame()
        {
            Console.WriteLine("Welcome to Ethans Mastermind Game!");
            Console.WriteLine("Please enter a combination that consists of 4 numbers between 1 and 6.");

            string answer = GenerateAnswer();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"You have {10 - i} guesses: ");
                string userInput = Console.ReadLine();

                if (userInput != null && userInput.Length == 4)
                {
                    string combinationKey = CompareAnswer(userInput, answer);

                    if (combinationKey == "++++")
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{combinationKey} try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Your input was invalid");
                    i =- 1;
                }
            }

            Console.WriteLine($"Your answer was {answer}");
        }

        public string CompareAnswer(string userInput, string answer)
        {
            string pluses = String.Empty;
            string minuses = String.Empty;

            for (int i = 0; i < 4; i++)
            {
                if (userInput[i] == answer[i])
                {
                    pluses += "+";
                }
                else if (answer.Contains(userInput[i]))
                {
                    minuses += "-";
                }
            }
            return pluses + minuses;
        }

        private string GenerateAnswer()
        {
            string answer = String.Empty;

            for (int i = 0; i < 4; i++)
            {
                answer += random.Next(1, 6).ToString();
            }
            return answer;
        }
    }
}
