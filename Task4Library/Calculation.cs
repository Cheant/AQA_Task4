using System;
using System.Text.RegularExpressions;

namespace Task4Library
{
    public class Calculation
    {
        private string _outputString;

        public void PrintIsStringPalindrom()
        {
            if (!ValidationStringIsPalindrom())
            {
                Console.WriteLine($"{Environment.NewLine}Entered string is not a palindrom.");
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Entered string is a palindrom.");
            }
        }

        private string GetStringOnlyLettersDigits()
        {
            Console.WriteLine($"Please enter any text:");
            var inputString = Console.ReadLine().ToLower();

            while (String.IsNullOrWhiteSpace(inputString))
            {
                Console.Clear();
                Console.WriteLine($"Entered value is null or empty. Please enter any text:");
                inputString = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsLetter(inputString, i) || char.IsDigit(inputString[i]))
                {
                    _outputString += inputString[i];
                }
            }

            /*for (int i = 0; i < inputString.Length; i++)
            {
                if (Regex.IsMatch(Convert.ToString(inputString[i]), @"[0-9A-Za-z]"))
                {
                    _outputString += inputString[i];
                }
            }*/

            return _outputString;
        }

        private bool ValidationStringIsPalindrom()
        {
            _outputString = GetStringOnlyLettersDigits();

            for (int i = 0; i < _outputString.Length / 2; i++)
            {
                if (_outputString[i] != _outputString[_outputString.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
