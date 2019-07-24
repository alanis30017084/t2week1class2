using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 2
            int[] nums = new int[100];
            nums = Populate(nums);
            Console.WriteLine("Aray Contents...");
            for(int i = 0; i< nums.Length; i++)
            {
                Console.Write($" {nums[i]}");
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine($"The sum of all numbers in this array is... {Sum(nums)}");
            Console.ReadLine();
        }
        static int[] Populate(int[] nums)
        {
            Random rand = new Random();
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100);
            }
            return nums;
        }
        static int Sum(int[] nums)
        {
            int total = 0;
            foreach (int x in nums)
                total += x;
            return total;
        }
    }
}
