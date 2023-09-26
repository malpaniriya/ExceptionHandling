using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{

    public class NegativeNumber
    {
        //If number is negative then throw negative number exception.
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a number :");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    throw new Exception("it is negative number:");
                }
                else
                {
                    Console.WriteLine("number is: " + n);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}



