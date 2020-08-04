using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PrimeNumbers
{
    public class PrimeNum
    {
        public static bool isPrime(int num)
        {
            bool primeNum = true;
            

            //for (int i = 2; i <num; i++)  takes 3mins
            for (int i = 2; i <=Math.Sqrt(num); i++) //100000 takes 414 ms 
            {
                if (num % i == 0)
                { 
                    primeNum = false;
                    break;
                }
            }
            if (primeNum == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int GetPrime(int userInput)
        {
           int counter = 0;
           int number = 1;
            while (counter != userInput)
            {
                number++;
                if (isPrime(number))
                 {
                    counter++;
                }

            }          
            return number;
        }

    }
}

