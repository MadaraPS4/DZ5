using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];

            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = i;
            }

            try
            {
              Console.WriteLine(numbers[6]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Завершение обработки массива");
            }

            Console.ReadKey();
        }
    }
}
