using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLab4.Interfaces;

namespace TestLab4
{
    public partial class CalculatorForm : Form, ICalculatorView
    {
        private ICalculator calculator;
        private ICalculatorPresenter calculatorPresenter;
        public CalculatorForm()
        {
            InitializeComponent();
            tbMessage.Enabled = false;
            calculator = new Calculator();
            calculatorPresenter = new CalculatorPresenter(this, calculator);
        }
        public void OnMultiplyClicked(object sender, EventArgs e)
        {
            calculatorPresenter.OnMultiplyClicked();
        }

        public void OnDivideClicked(object sender, EventArgs e)
        {
            calculatorPresenter.OnDivideClicked();
        }

        public void OnMinusClicked(object sender, EventArgs e)
        {
            calculatorPresenter.OnMinusClicked();
        }

        public void OnPlusClicked(object sender, EventArgs e)
        {
            calculatorPresenter.OnPlusClicked();
        }

        public void PrintResult(double result)
        {
            tbMessage.Text = result.ToString();
        }

        public void DisplayError(string message)
        {
            tbMessage.Text = message;
        }

        public string GetFirstArgumentAsString()
        {
            return tbA.Text;
        }

        public string GetSecondArgumentAsString()
        {
            return tbB.Text;
        }
    }
}
