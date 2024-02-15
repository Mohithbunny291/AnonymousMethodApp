using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodApp
{
    internal class Program
    {
        delegate void PrintDelegate(string param);
        static void Main(string[] args)
        {
            //PrintDelegate del = PrintInformation;
            //LogAndPrintInformation(del);

            // Syntax: delegate (params) { }

            LogAndPrintInformation(delegate (string parameter)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PrintInformation with parameter: {parameter} ");
                Console.ForegroundColor = ConsoleColor.White;
            });
            
        }   


        static void LogAndPrintInformation(PrintDelegate print)
            {
                print("This is Anonymous Method demo app");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Logging to console window.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            static void PrintInformation(string parameter)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PrintInformation with parameter: {parameter} ");
                Console.ForegroundColor = ConsoleColor.White;
            }


    }
}
