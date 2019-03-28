using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculatorView
    {
        void OnNumberEdited(string newChar);
        void OnOperationEdited(Operation operation);
        void OnResultRequested();
        void OnClear();
        void OnSignChange();
        void CalculationInfoChanged(string newLabel);
        void CurrentEditingNumberChanged(string newValue);
    }
}
