namespace ZbW.DesignPatterns.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using ZbW.DesignPatterns.Singleton.Threads;

    public class Program
    {
        public static void Main(string[] args)
        {
            ThreadingPrintSpooler.GetInstance().Start();
            
            using var numberPrinter = new NumberPrinter();
            using var textPrinter = new TextPrinter();
            
            Console.ReadLine();
            ThreadingPrintSpooler.GetInstance().Stop();
            Console.ReadLine();
        }
    }
}
