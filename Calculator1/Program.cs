using System;


namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "2+1";
            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(str));

        }
    }
}
