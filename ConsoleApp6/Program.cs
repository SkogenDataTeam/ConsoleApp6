﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //  byte[] bytes = strings.Select(byte.Parse).ToArray();
            //  strings = bytes.Select(byteValue => byteValue.ToString()).ToArray();

            string inn = "alle fugler små. de er";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(inn);
            Console.ResetColor();
            Console.WriteLine("-", 10);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Splitter stringen etter tegnet '.'");


            int i = inn.IndexOf(".");
            string nyinn = inn.Substring(0, i);
            Console.WriteLine(nyinn);
            Console.ResetColor();
            Console.WriteLine("-", 10);

            if (nyinn == "alle fugler små")
            { Console.WriteLine("yes"); }
            else
            { Console.WriteLine("no"); }

            Console.WriteLine("stringen inneholder '{0}'", nyinn);
            Console.WriteLine("Press ENTER to exit the sample application.");

            WaitOrProceed();
        }
        private static void WaitOrProceed()
        {

            var stop = DateTime.Now.Second;

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                var now = DateTime.Now.Second;
                if (now >= stop) { break; }
            }
        }
    }
}
