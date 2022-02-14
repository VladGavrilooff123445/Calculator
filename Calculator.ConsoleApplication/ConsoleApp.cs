using Calculator.Logic;

namespace Calculator.ConsoleApplication
{
    public class ConsoleApp
    {
        private const string FirstMessage = "Enter comma separated numbers";
        private const string ChoiceMessage = "Press esc to exit or enter to continue";        
        private StringCalculator calculate;
        private ConsoleService serviceConsole;


        public ConsoleApp(ConsoleService consoleService, StringCalculator calculator)
        {
            serviceConsole = consoleService;
            calculate = calculator;
        }

        public void UsingUI()
        {
            string numbers;
            int result = 0;
            bool pressESC = false;

            while (true)
            {
                serviceConsole.WriteLine(FirstMessage);
             
                numbers = serviceConsole.ReadLine();
                result = calculate.Add(numbers);

                serviceConsole.WriteLine($"Result is: {result}");
                serviceConsole.WriteLine(ChoiceMessage);

               pressESC = serviceConsole.IsESCPressed();

                if (pressESC)
                {
                    break;
                }
            }
        }
    }
}

