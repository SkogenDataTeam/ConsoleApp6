using System;
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

            int i = inn.IndexOf(".");
            string nyinn = inn.Substring(0, i);
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
