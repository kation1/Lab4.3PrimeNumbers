using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's locate some primes!\n");
            string running = "y";
            do
            {
                Console.WriteLine("Which prime are you looking for?");
                int userInput = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nThe number {userInput} prime is {PrimeNum.GetPrime(userInput)}.");

                Console.WriteLine($"\nDo you wantto find another prime? (y/n)");
                running = Console.ReadLine();
            } while (running != "n");
        }
    }
}
