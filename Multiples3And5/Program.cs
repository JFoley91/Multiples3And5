using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {       
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                var isMultipleOf3 = i % 3 == 0;
                var isMultipleOf5 = i % 5 == 0;

                
                if (isMultipleOf3 || isMultipleOf5)
                {
                    
                    sum += i;
                }
            }
            Console.WriteLine("The sum of all the multiples of 3 and 5 below 1000 is " + sum);
        }
    }
}
