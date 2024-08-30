using System;
namespace PS02_07
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter a size of an array: ");
            int size = int.Parse(Console.ReadLine());
            int[] nums = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                int input = int.Parse(Console.ReadLine());

                nums[i] = input;

            }
            int total = 0;
            foreach (int i in nums)
            {
                
                total += i;

            }
            Console.WriteLine($"The sum is {total}.");
        }
    }
}