using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа");
            string firstNumString = Console.ReadLine();
            string secondNumString = Console.ReadLine();


            try
            {
                float firstNum = float.Parse(firstNumString);
                float secondNum = float.Parse(secondNumString);


                if (firstNum == secondNum)
                    Console.WriteLine($"{firstNum} = {secondNum}");
                else if (firstNum > secondNum)
                    Console.WriteLine($"{firstNum} > {secondNum}");
                else
                    Console.WriteLine($"{secondNum} > {firstNum}");

               
            }
            catch (FormatException e)
            { 
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }

    }
}
