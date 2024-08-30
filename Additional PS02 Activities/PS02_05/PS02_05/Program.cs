using System; 

namespace PSO2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will output the frequency of each string.");
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int[] count = new int[256];
            char[] chars = input.ToCharArray();


            foreach (char c in chars)
            
            {
                if (input.Contains(c))
                {
                    count[c]++;
                }
            }
            foreach (char c in chars)
            {
                if (count[c] != 0)
                {
                    Console.WriteLine($"{c} : {count[c]}");
                    count[c] = 0; //nireset ko po sya maam into 0 para after maprint yung character na yun di na po sya maprint ulit
                }


                
                

            }


        }
    }

}
