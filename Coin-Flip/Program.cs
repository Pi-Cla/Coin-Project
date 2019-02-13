using System;

namespace Coin_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rng = new Random();

            //Query the user
            Console.Write("Enter you geuss, Heads or Tails (H or T)");
            userGuess = Console.ReadLine();

            //get a random number for the coin flip
            coin = rng.Next(0,2);

            if (coin == 0 && userGuess == "T"){
                Console.WriteLine("The coin flip was Tails, you win!");
            } else if (coin == 1 && userGuess == "H"){
                Console.WriteLine("The coinf lip was Heads, you win!");
            } else {
                if (coin == 0){
                    Console.WriteLine("The coin flip was Tails, you lose!");
                } else {
                    Console.WriteLine("The coin flip was Heads, you lose!");
                }
            }
        }
    }
}
