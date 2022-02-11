using System;
using System.Linq;

namespace Calculator.Logic
{
    public class StringCalculator
    {
        public virtual int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }

            if (numbers.StartsWith("//"))
            {
                string[] numbersWithOutDelimeters = NumbersWithCustomDelimiters(numbers);

                return Result(numbersWithOutDelimeters);
            }
            else
            {
                char[] delimiters = { ',' };
                string[] listOfNumbers = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                return Result(listOfNumbers);
            }
        }

        private string[] NumbersWithCustomDelimiters(string numbers)
        {
            int numbersIndex = 1;
            int customDelimitersPosition = 0;

            string[] splitedInput = numbers
                .Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] delimiters = splitedInput[customDelimitersPosition]
                .Split(new char[] { '[', ']', '/' }, StringSplitOptions.RemoveEmptyEntries);

            string[] listOfNumbers = splitedInput[numbersIndex].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);


            return listOfNumbers;
        }

        private int Result(string[] numbers)
        {
            int result = 0;
            CheckNegatives(numbers);

            result = numbers.Select(a => Convert.ToInt32(a))
                .Where(a => a < 1000)
                .Sum();

            return result;
        }

        private void CheckNegatives(string[] numbers)
        {
            var negatives = numbers.Select(int.Parse)
                .Where(_ => _ < 0);
            var negativesString = string.Join(' ', negatives);

            if (negatives.Any())
            {
                throw new Exception($"negatives not allowed: {negativesString}");
            }
        }
    }
}
