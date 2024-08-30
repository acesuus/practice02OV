using System;

namespace PS02_03
{
    class Program
    {
        static void Main(string[] args) //code ni Jon Richmond
        {
            while (true)
            {
                
               
                Console.Write("Enter an Alphabet character: ");
                string user_input = Console.ReadLine().ToLower();


                {

                    if (user_input == "a" || user_input == "e" || user_input == "i" || user_input == "o" || user_input == "u")
                    {
                        Console.WriteLine($"{user_input} is a vowel.");
                    }
                    else
                    {

                        Console.WriteLine($"{user_input} is consonant.");
                    }
                }
            }


        }
    }
}