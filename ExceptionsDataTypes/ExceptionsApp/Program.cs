using System;
using System.IO;
using System.Collections.Generic;

namespace ExceptionsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = 5.50 / 5;
            var myInt = 5;
            double myNum = 5;
            //int anInt = 3; //Explicitly typed
            //var vInt = 3; //Implicity typed
            //var v2Int = vInt; // Implicitly typed 

            //var name = "Cathy";
            //var isClean = true;
            //var letter = 'P';
            //var uLongNum = 52uL;

            //List<decimal> prices = new List<decimal>();

            short n1 = -65;
            ushort n2 = 65;
            int n3 = -100_100;
            uint n4 = 100_000;
            var max = Int32.MaxValue;
            uint n5 = 4_000_000_000;
            long n6 = -5_000_000_000;
            ulong n7 = 5_000_000_000;

            float sum = 0; 
            for(int i = 0; i < 100_000; i++)
            {
                sum += 2 / 5.0f;
            }
            Console.WriteLine("2/5 added 100,000 times " + sum);
            Console.WriteLine("2/5 mulitiplied 100,100 times " + 2/5.0f * 100_000);

            string text;
            string filename = "";
            try
            {
                Console.WriteLine("Anil's mark is 82: " + Grade(82));
                //Console.WriteLine("Cathy's mark is -65: " + Grade(-65));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Invalid date please try again");
                Console.WriteLine(e.Message);
            }
            try
            {
                text = File.ReadAllText(filename);
                Console.WriteLine(text);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Sorry I can't find: " +  filename);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("You gave me an empty file name!" + e.Message);
            }
            finally
            {
                Console.WriteLine("We made it here!");
            }
        }
        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100)
                throw new ArgumentOutOfRangeException("Mark: " + mark + " Allowed range is 0-100");
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}
