using Calculator.Logic;

namespace Calculator.ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calculator = new StringCalculator();
            var service = new ConsoleService();
            var app = new ConsoleApp(service, calculator);
            
            app.UsingUI();
        }
    }
}

