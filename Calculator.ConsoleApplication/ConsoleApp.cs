using Calculator.Logic;

namespace Calculator.ConsoleApplication
{
    public class ConsoleApp
    {
        private readonly string FirstMessage;
        private readonly string ChoiceMessage;        
        private StringCalculator _calculate;
        private ConsoleService _serviceConsole;


        public ConsoleApp(ConsoleService consoleService, StringCalculator calculator)
        {
            FirstMessage = "Enter comma separated numbers";
            ChoiceMessage = "Press esc to exit or enter to continue";
            _serviceConsole = consoleService;
            _calculate = calculator;
        }

        public void UsingUI()
        {
            while (true)
            {
                string numbers;
                
                _serviceConsole.WriteLine(FirstMessage);
             
                numbers = _serviceConsole.ReadLine();
                var result = _calculate.Add(numbers);

                _serviceConsole.WriteLine($"Result is: {result}");
                _serviceConsole.WriteLine(ChoiceMessage);

                var pressESC = _serviceConsole.IsESCPressed();

                if (pressESC)
                {
                    break;
                }
            }
        }
    }
}

