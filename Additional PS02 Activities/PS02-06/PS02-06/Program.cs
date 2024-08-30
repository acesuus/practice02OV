using System;

namespace PSO2_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            int total = 0;
            foreach (char n in num)
            {
                int N = n - '0';
                total += N;
                
            }
            Console.WriteLine(total);
        }
    }
}