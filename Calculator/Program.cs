using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Calculator calculator = new Calculator();
            Presenter presenter = new Presenter(calculator);
            Form1 view = new Form1();
            view.Presenter = presenter;
            presenter.CalculatorView = view;
            Application.Run(view);
        }
    }
}
