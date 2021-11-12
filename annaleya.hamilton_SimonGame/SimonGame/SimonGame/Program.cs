using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simon Game! Press any key to continue");
            Console.ReadKey();

            bool gameOver = false;
            int score = 0;

            //clear screen
            Console.Clear();

            //Add the number to a list
            List<int> numberList = new List<int>();

            //present the sequence of randomly generated numbers from the list to the console
            while (gameOver == false)
            {
                //Create a randomly generated number
                Random random = new Random();
                int secretNumber;
                secretNumber = random.Next(1, 10);
                numberList.Add(secretNumber);
                score++;
                for (int i = 0; i < numberList.Count; i++)
                {
                    //leave each number for 1 second
                    Console.WriteLine($"***{numberList[i]}***");
                    Task.Delay(1000).Wait();
                    Console.Clear();
                }
                for (int i = 0; i <numberList.Count; i++)
                {
                    //Loop b start
                    //ask user what each number in the sequence displayed was
                    Console.WriteLine($"What was number {i+1}");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    //did the user get all the number right?
                    //Yes - go back to start and continue
                    
                    if (guess == numberList[i])
                    {
                        Console.WriteLine("Nice! You got it right!");
                        Task.Delay(500).Wait();
                        Console.Clear();
                    }
                    //end game if guess incorrect
                    else if (guess != secretNumber)
                    {
                        gameOver = true;
                        Console.WriteLine($"The correct number was {secretNumber}! Better luck next time!");
                        Console.WriteLine($"Your score was: {score}");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
