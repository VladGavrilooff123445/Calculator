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

            else
            {
                var numbersString = ValidationString(numbers);
                int[] numbersArray = IntArray(numbersString);

                return Result(numbersArray);
            }

        }

        private string[] NumbersWithCustomDelimiters(string numbers)
        {
            int numbersIndex = 1;
            int customDelimitersPosition = 0;

            string[] splitedInput = numbers
                .Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] delimiters = splitedInput[customDelimitersPosition]
                .Split(new char[] { '[', ']', '\\', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string[] listOfNumbers = splitedInput[numbersIndex].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);


            return listOfNumbers;
        }

        private int Result(int[] numbers)
        {
            int result = 0;
            CheckNegatives(numbers);

            result = numbers.Select(a => a)
                .Where(a => a < 1000)
                .Sum();

            return result;
        }

        private void CheckNegatives(int[] numbers)
        {
            var negatives = numbers.Select(a => a)
                .Where(_ => _ < 0);
            var negativesString = string.Join(' ', negatives);

            if (negatives.Any())
            {
                throw new Exception($"negatives not allowed: {negativesString}");
            }
        }

        private string[] ValidationString(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                string[] numbersWithOutDelimeters = NumbersWithCustomDelimiters(numbers);

                return numbersWithOutDelimeters;
            }
            else
            {
                char delimiters = ',';
                string[] listOfNumbers = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                return listOfNumbers;
            }
        }

        private int[] IntArray(string[] numbers)
        {
            int[] result = numbers.Select(a => Convert.ToInt32(a)).ToArray();

            return result;
        }
    }
}
