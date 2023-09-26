using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Lessthan10morethan10
    {
        
        //WAP to take mobile number  in String from user 
        //if it is content number of digit less than 10 or more than 10 then throw Exception.
        static void Main(string[] args)
        {
            try
            {
                int cnt = 0;
                Console.WriteLine("enter number:");
                string num = Console.ReadLine();
                User1 us = new User1(num);
                char[] ch = num.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    cnt++;
                }
                if (cnt > 10)
                {
                    throw new NumberException("invalid :number is greater than 10: ");
                }
                else if (cnt < 10)
                {
                    throw new NumberException("invalid: less than 10 ");
                }

            }
            catch (NumberException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public class NumberException : Exception
    {
        public NumberException(string error) : base(error)
        {

        }
    }
    public class User1
    {
        public string num;
        public User1(string num)
        {

        }

    }
}

