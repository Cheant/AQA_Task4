using System;

namespace Task4Library
{
    public class Calculation
    {
        private string _inputString;
        private string _outputString;

        private string GetStringOnlyLettersDigits()
        {
            Console.WriteLine($"Please enter any text:");
            _inputString = Console.ReadLine().ToLower();

            for (int i = 0; i < _inputString.Length; i++)
            {
                if (char.IsLetter(_inputString, i) || char.IsDigit(_inputString[i]))
                {
                    _outputString += _inputString[i];
                }
            }
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

        public void PrintIsStringPalindrom()
        {
            if (!ValidationStringIsPalindrom())
            {
                Console.WriteLine($"\nEntered string is not a palindrom.");
            }
            else
            {
                Console.WriteLine($"\nEntered string is a palindrom.");
            }
        }
    }
}
