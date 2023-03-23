using System;
using System.Numerics;
namespace ModuleSixteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            try
            {
                Console.WriteLine(calc.Division(int.MinValue, -1));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
