using System;
using System.Threading;

namespace ContinuousWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("WebJob is running...");
                Thread.Sleep(5000); // Wait for 5 seconds
            }
        }
    }
}
