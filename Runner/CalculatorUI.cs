using System;
using CalculatorLogic;

namespace Runner
{
    class CalculatorUI
    {
        private int itterator = 0;
        private Calculator calculate;

        public CalculatorUI()
        {
            calculate = new Calculator();
        }

        public void UsingUI()
        {
            while (itterator >= 0)
            {
                if (itterator == 0)
                {
                    Console.WriteLine("Enter comma separated numbers");
                }

                int result = calculate.Add(Console.ReadLine());

                Console.WriteLine($"Result is: {result}");

                Console.WriteLine("you can enter other numbers (enter to exit)?");
                if (Convert.ToChar(Console.Read()) == (char)13)
                {
                    break;
                }
                else
                {
                    itterator++;
                }
            }
        }
    }
}
