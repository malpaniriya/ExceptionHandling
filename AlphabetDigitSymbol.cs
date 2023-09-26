using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class AlphabetDigitSymbol
    {
        
        //WAP to check String content only alphabets if an digit or symbol is present then throw custom exception
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter string: ");
                string str = Console.ReadLine();


                char[] ch = str.ToCharArray();



                for (int i = 0; i < ch.Length; i++)
                {


                    if (ch[i] >= 'A' && ch[i] <= 'Z' || ch[i] >= 'a' && ch[i] <= 'z')
                    {
                        continue;
                    }
                    else
                    {
                        throw new NameException2("string contains number and digits: ");
                    }
                }




            }
            catch (NameException2 e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    

    public class NameException2 : Exception
    {
        public NameException2(string error) : base(error)
        {

        }
    }
    public class CheckString
    {
        string str;
        public CheckString(string str)
        {


        }

    }
}

