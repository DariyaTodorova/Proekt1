using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chisla: ");
            int[] nums = new int[5];
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    sum += nums[i];
                }
                else
                {
                    counter++;
                }
            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int swap = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = swap;

                    }
                }
            }
            Console.WriteLine($"Min={nums[0]} - poziciq = 0, Max={nums[nums.Length - 1]} - poziciq {nums.Length - 1}");
            Console.WriteLine($"{sum} and {counter}");
        }
    }
}
    

