using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

public enum Operation
{
    ADD, SUBTRACT, MULTIPLY, DIVIDE, NOT_SET
}

namespace Calculator
{
    public class Calculator
    {  
        public decimal calc(decimal first, Operation operation, decimal second)
        {
            switch (operation)
            {
                case Operation.ADD: return first + second;
                case Operation.SUBTRACT: return first - second;
                case Operation.MULTIPLY: return first * second;
                case Operation.DIVIDE: return first / second;
                default: return decimal.MinValue;
            }
        }
    }
}
