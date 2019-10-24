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
    public partial class Calculator : Form
    {
        String userInput = string.Empty;
        String firstOperand = string.Empty;
        String secondOperand = string.Empty;
        char operation;
        double result = 0.00;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "0";
            resultBox.Text = userInput;
        }

        private void One_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "1";
            resultBox.Text = userInput;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "2";
            resultBox.Text = userInput;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "3";
            resultBox.Text = userInput;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "4";
            resultBox.Text = userInput;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "5";
            resultBox.Text = userInput;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "6";
            resultBox.Text = userInput;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "7";
            resultBox.Text = userInput;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "8";
            resultBox.Text = userInput;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "9";
            resultBox.Text = userInput;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '*';
            userInput = string.Empty;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '/';
            userInput = string.Empty;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '+';
            userInput = string.Empty;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '-';
            userInput = string.Empty;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput = string.Empty;
            firstOperand = string.Empty;
            secondOperand = string.Empty;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            secondOperand = userInput;

            double num1, num2;

            double.TryParse(firstOperand, out num1);
            double.TryParse(secondOperand, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                resultBox.Text = result.ToString();
            }

            else if (operation == '-')
            {
                result = num1 - num2;
                resultBox.Text = result.ToString();
            }

            else if (operation == '*')
            {
                result = num1 * num2;
                resultBox.Text = result.ToString();
            }

            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    resultBox.Text = result.ToString();
                }
                else
                {
                    resultBox.Text = "Division By Zero is Not Allowed.";
                }
            }

            userInput = resultBox.Text;
        }

        private void Period_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += ".";
            resultBox.Text = userInput;
        }
    }
}
