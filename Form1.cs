using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculatorOutput_Click(object sender, EventArgs e)
        {

        }

        public static string firstNumber;
        public static string secondNumber;
        public static string resultNumber;
        public static string operation = "";
        public static bool beganInputtingNumber = false;
        public static bool beganInputtingDecimal = false;
                                
        void addNumberToInput(string number)
        {
            if (!beganInputtingNumber)
            {
                beganInputtingNumber = true;
                beganInputtingDecimal = false;

                CalculatorOutput.Text = number;
            }
            else
            {
                CalculatorOutput.Text += number;
            }
        }

        void doOperation()
        {
            double n1 = double.Parse(firstNumber);
            double n2 = double.Parse(secondNumber);
            double result = 0;

            if (operation == "plus")
            {
                result = n1 + n2;
            }
            if (operation == "minus")
            {
                result = n1 - n2;
            }
            if (operation == "multiply")
            {
                result = n1 * n2;
            }
            if (operation == "divide")
            {
                result = n1 / n2;
            }

            resultNumber = result.ToString();
            firstNumber = resultNumber;
            secondNumber = null;
        }

        void selectOperation(string selectedOperation)
        {
            // Set up input numbers
            if (beganInputtingNumber == true)
            {
                beganInputtingNumber = false;
                if (firstNumber == null)
                {
                    firstNumber = CalculatorOutput.Text;
                    CalculatorOutput.Text = "0";
                }
                else if (secondNumber == null)
                {
                    secondNumber = CalculatorOutput.Text;
                    CalculatorOutput.Text = "0";
                }
            } else
            {
                return;
            }
           

            // If both numbers and operator are not null, then do the calculation
            // And display it
            // Then set firstNumber to resultNumber
            // And set secondNumber to null
            if (firstNumber != null && secondNumber != null && operation != null)
            {
                doOperation();
                CalculatorOutput.Text = resultNumber;
            } else
            {
                CalculatorOutput.Text = "0";
            }

            // Then set the operation
            operation = selectedOperation;
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            addNumberToInput("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            addNumberToInput("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            addNumberToInput("3");

        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            addNumberToInput("4");

        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            addNumberToInput("5");

        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            addNumberToInput("6");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            addNumberToInput("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            addNumberToInput("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            addNumberToInput("9");
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            selectOperation("plus");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            selectOperation("minus");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            selectOperation("multiply");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            selectOperation("divide");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            beganInputtingNumber = false;
            beganInputtingDecimal = false;

            secondNumber = null;
            resultNumber = null;
            firstNumber = null;
            operation = null;
            CalculatorOutput.Text = "0";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            selectOperation(operation);
            beganInputtingNumber = true;
            beganInputtingDecimal = false;

            secondNumber = null;
            resultNumber = null;
            firstNumber = null;
            operation = null;
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (beganInputtingDecimal == false)
            {
                beganInputtingDecimal = true;
                CalculatorOutput.Text += ".";
            } else
            {
                return;
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (beganInputtingDecimal || CalculatorOutput.Text != "0")
            {
                addNumberToInput("0");
            }
        }
    }
}
