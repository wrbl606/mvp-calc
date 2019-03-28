using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form, ICalculatorView
    {
        public Form1() => InitializeComponent();
        public Presenter Presenter { get; set; }

        public void CalculationInfoChanged(string newLabel)
        {
            calculationInfo.Text = newLabel;
        }

        public void CurrentEditingNumberChanged(string newValue)
        {
            currentEditingNumber.Text = newValue;
        }

        public void OnNumberEdited(string newChar)
        {
            Presenter.OnNumberEdited(newChar);
        }

        public void OnOperationEdited(Operation operation)
        {
            Presenter.Operation = operation;
        }

        public void OnResultRequested()
        {
            Presenter.OnResultRequested();
        }

        public void OnClear()
        {
            Presenter.Clear();
        }

        public void OnSignChange() => Presenter.ChangeEditingNumberSign();
        

        private void NumButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                OnNumberEdited(button.Text);
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                OnOperationEdited(TextToOperation(button.Text));
            }
        }

        private void ResultButtonButton_Click(object sender, EventArgs e) => OnResultRequested();

        private void ClearButton_Click(object sender, EventArgs e) => OnClear();
        

        private Operation TextToOperation(string character)
        {
            switch (character)
            {
                case "+": return Operation.ADD;
                case "-": return Operation.SUBTRACT;
                case "*": return Operation.MULTIPLY;
                case "/": return Operation.DIVIDE;
                default: return Operation.NOT_SET;
            }
        }

        private void SignButton_Click(object sender, EventArgs e) => OnSignChange();
    }
}
