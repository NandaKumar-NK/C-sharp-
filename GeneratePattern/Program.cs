using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the no. of rows: ");
                int rowCount = int.Parse(Console.ReadLine());

                int startNum = 1;

                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(startNum + " ");
                        startNum++;
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input. Please enter a valid number of rows.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
