using System;
using CalculatorLogic;

namespace Runner
{
    public class CalculatorUI
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
                    Console.WriteLine(ProduceFirstMessage());
                }

                int result = calculate.Add(Console.ReadLine());

                Console.WriteLine(PrintResult(result));

                Console.WriteLine(ProduceSecondMessage());
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

        public string ProduceFirstMessage()
        {
            return "Enter comma separated numbers";
        }

        public string ProduceSecondMessage()
        {
            return "you can enter other numbers (enter to exit)?";
        }

        public string PrintResult(int result)
        {
            return $"Result is: {result}";
        }
    }
}
