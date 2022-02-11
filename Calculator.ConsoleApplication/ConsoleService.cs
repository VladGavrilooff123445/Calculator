using System;

namespace Calculator.ConsoleApplication
{
    public class ConsoleService
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public bool IsESCPressed()
        {
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
