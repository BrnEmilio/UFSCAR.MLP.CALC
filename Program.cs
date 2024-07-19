using System;

namespace UFSCAR.MLP.CALC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            new Operacao(true);

            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...\r");
            Console.ReadKey();
        }
    }
}