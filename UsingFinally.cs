using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class UsingFinally
    {
      

        static void Main(string[] args)
        {
            int n = 77;
            int n1 = 0;
            try
            {
                int c = n / n1;
                Console.WriteLine("divsion is" + c);


            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally block executed:");
            }
        }
    }
}

