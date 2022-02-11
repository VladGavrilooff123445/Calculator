using Calculator.Logic;
using System;

namespace Calculator.ConsoleApplication
{
    public class ConsoleApp
    {
        private const string FirstMessage = "Enter comma separated numbers";
        private const string SecondMessage = "you can enter other numbers (enter to exit)?";
        private bool PressESC = false;
        private bool IsFirstMessage = true;
        private StringCalculator calculate;
        private ConsoleService service;


        public ConsoleApp(ConsoleService consoleService, StringCalculator calculator)
        {
            service = consoleService;
            calculate = calculator;
        }

        public void UsingUI()
        {
            while (true)
            {
                if (IsFirstMessage)
                {
                    service.WriteLine(FirstMessage);
                    IsFirstMessage = false;
                }

                var result = calculate.Add(service.ReadLine());
                service.WriteLine($"Result is: {result}");

                service.WriteLine(SecondMessage);

                PressESC = service.IsESCPressed();

                if (PressESC)
                {
                    break;
                }


            }
        }
         
    }
}

