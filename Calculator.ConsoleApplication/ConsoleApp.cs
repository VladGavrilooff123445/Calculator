using Calculator.Logic;

namespace Calculator.ConsoleApplication
{
    public class ConsoleApp
    {
        private const string FirstMessage = "Enter comma separated numbers";
        private const string ChoiceMessage = "Press esc to exit or enter to continue";        
        private StringCalculator _calculate;
        private ConsoleService _serviceConsole;


        public ConsoleApp(ConsoleService consoleService, StringCalculator calculator)
        {
            _serviceConsole = consoleService;
            _calculate = calculator;
        }

        public void UsingUI()
        {
            while (true)
            {
                string numbers;
                int result = 0;
                bool pressESC = false;
                _serviceConsole.WriteLine(FirstMessage);
             
                numbers = _serviceConsole.ReadLine();
                result = _calculate.Add(numbers);

                _serviceConsole.WriteLine($"Result is: {result}");
                _serviceConsole.WriteLine(ChoiceMessage);

               pressESC = _serviceConsole.IsESCPressed();

                if (pressESC)
                {
                    break;
                }
            }
        }
    }
}

