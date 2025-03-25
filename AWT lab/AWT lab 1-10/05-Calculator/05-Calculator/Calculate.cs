using System;

namespace _05_Calculator
{
    public class Calculate
    {
        private string currentValue = "0";
        private string previousValue = "";
        private char currentOperator = '\0';
        private bool isNewEntry = true;

        public string CurrentValue => currentValue;

        public void Clear()
        {
            currentValue = "0";
            previousValue = "";
            currentOperator = '\0';
            isNewEntry = true;
        }

        public void Backspace()
        {
            if (currentValue.Length > 1)
                currentValue = currentValue.Substring(0, currentValue.Length - 1);
            else
                currentValue = "0";
        }

        public void AppendDigit(char digit)
        {
            if (isNewEntry)
            {
                currentValue = digit.ToString();
                isNewEntry = false;
            }
            else
            {
                currentValue += digit;
            }
        }

        public void AddDecimal()
        {
            if (!currentValue.Contains("."))
                currentValue += ".";
        }

        public void ToggleSign()
        {
            if (currentValue.StartsWith("-"))
                currentValue = currentValue.Substring(1);
            else if (currentValue != "0")
                currentValue = "-" + currentValue;
        }

        public void SetOperator(char op)
        {
            if (!string.IsNullOrEmpty(previousValue))
                CalculateResult();

            previousValue = currentValue;
            currentOperator = op;
            isNewEntry = true;
        }

        public void CalculateResult()
        {
            if (string.IsNullOrEmpty(previousValue) || currentOperator == '\0')
                return;

            double num1 = Convert.ToDouble(previousValue);
            double num2 = Convert.ToDouble(currentValue);
            double result = 0;

            switch (currentOperator)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/': result = num2 != 0 ? num1 / num2 : 0; break;
                case '%': result = (num1 * num2) / 100; break;
            }

            currentValue = result.ToString();
            previousValue = "";
            currentOperator = '\0';
            isNewEntry = true;
        }
    }
}
