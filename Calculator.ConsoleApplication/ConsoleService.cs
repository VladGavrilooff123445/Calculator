using System;

namespace Calculator.ConsoleApplication
{
    public class ConsoleService
    {
        public virtual void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public virtual bool IsESCPressed()
        {
            return Console.ReadKey().Key == ConsoleKey.Escape;
        }

        public virtual string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
