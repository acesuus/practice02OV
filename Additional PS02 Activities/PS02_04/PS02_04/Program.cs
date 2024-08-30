using System;
using System.Security.Cryptography;

namespace PS02_04
{
    class Programs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string user_input = Console.ReadLine().ToLower();
            char[] chars = user_input.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);




            if (user_input == reversed)
            {
                Console.WriteLine("This is Palindrome.");
            }   
            else
            {
                Console.WriteLine("This is not Palindrome");
            }


            
        }
    }
}