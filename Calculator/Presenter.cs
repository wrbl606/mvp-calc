using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Presenter
    {
        public Presenter(Calculator calculator)
        {
            this.calculator = calculator;
        }

        private Decimal first;
        private Decimal second;
        private Calculator calculator;
        private bool waitingForNumberAfterComma = false;
        private Operation operation = Operation.NOT_SET;
        public Operation Operation { get { return operation; } set { operation = value; UpdateCalculationInfo(); } }
        public ICalculatorView CalculatorView { get; set; }

        public void OnNumberEdited (String newChar)
        {
            decimal currentValue;

            if (this.Operation == Operation.NOT_SET)
            {
                currentValue = first;
            } else
            {
                currentValue = second;
            }

            String currentValueString = currentValue.ToString();
            // check if number is not too long
            if (currentValueString.Count() > 12) return;
            // check if decimal already have floating point
            if ((newChar.Equals(",") && currentValueString.Contains(',')) || (newChar.Equals(",") && waitingForNumberAfterComma)) return;
            else if (newChar.Equals(",") && !waitingForNumberAfterComma)
            {
                waitingForNumberAfterComma = true;
                UpdateCurrentEditingNumber();
                return;
            }
            

            if (Operation == Operation.NOT_SET)
            {
                if (waitingForNumberAfterComma)
                {
                    first = decimal.Parse($"{currentValueString},{newChar}");
                    waitingForNumberAfterComma = false;
                }
                else
                {
                    first = decimal.Parse($"{currentValueString}{newChar}");
                }
            }
            else
            {
                if (waitingForNumberAfterComma)
                {
                    second = decimal.Parse($"{currentValueString},{newChar}");
                    waitingForNumberAfterComma = false;
                }
                else
                {
                    second = decimal.Parse($"{currentValueString}{newChar}");
                }
            }

            UpdateCalculationInfo();
            UpdateCurrentEditingNumber();
        }

        private void UpdateCalculationInfo()
        {
            if (this.Operation == Operation.NOT_SET)
            {
                CalculatorView.CalculationInfoChanged("");
            } 
            else
            {
                CalculatorView.CalculationInfoChanged($"{first} {OperationToString(Operation)}");   
            }
        }

        private void UpdateCurrentEditingNumber()
        {
            if (operation == Operation.NOT_SET)
            {
                if (!waitingForNumberAfterComma)
                {
                    CalculatorView.CurrentEditingNumberChanged($"{first}");
                } else
                {
                    CalculatorView.CurrentEditingNumberChanged($"{first},");
                }
            }
            else
            {
                if (!waitingForNumberAfterComma)
                {
                    CalculatorView.CurrentEditingNumberChanged($"{second}");
                }
                else
                {
                    CalculatorView.CurrentEditingNumberChanged($"{second},");
                }
            }
        }

        public void Clear()
        {
            first = 0;
            second = 0;
            waitingForNumberAfterComma = false;
            Operation = Operation.NOT_SET;
            UpdateCalculationInfo();
            UpdateCurrentEditingNumber();
        }

        public void OnResultRequested()
        {
            if (operation == Operation.NOT_SET || waitingForNumberAfterComma) return;

            decimal result = 0;
            try
            {
                result = calculator.calc(first, Operation, second);
            } catch (Exception e)
            {
                Clear();
                PrintError(e.Message);
                UpdateCurrentEditingNumber();
                return;
            }
            Clear();
            first = result;
            UpdateCalculationInfo();
            UpdateCurrentEditingNumber();
        }

        public void ChangeEditingNumberSign()
        {
            if (operation == Operation.NOT_SET) first *= -1;
            else second *= -1;
            UpdateCurrentEditingNumber();
        }

        private void PrintError(string error)
        {
            CalculatorView.CalculationInfoChanged(error);
        }

        private string OperationToString(Operation operation)
        {
            switch (operation)
            {
                case Operation.ADD: return "+";
                case Operation.SUBTRACT: return "-";
                case Operation.MULTIPLY: return "*";
                case Operation.DIVIDE: return "/";
                default: return "";
            }
        }
    }
}
