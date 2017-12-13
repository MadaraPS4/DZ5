using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_5
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Method();

            Console.ReadLine();

        }

        static void Method()
        {
            double? a = null, b = 0;
            try
            {
                if (a == null ||b == null)
                {
                    throw new ArgumentNullException();
                    
                }
                else if (b == 0)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("Результат равен = " + a / b);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
;
        }

        
    }

}
