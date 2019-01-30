using System;
using MessagePrinter;

namespace SimpleDependency
{
    class Program
    {
        static void Main(string[] args)
        {
           var service = new MessagePrintingService();

           service.printMessage();
           Console.WriteLine("Press any key to continue...");
           Console.ReadKey();

            //Console.WriteLine("Hello World!");
        }
    }
}
