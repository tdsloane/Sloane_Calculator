using System;
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
    public partial class tdsCalc : Form
    {

        // Note to self, maybe adding user input into a list and then using the operator on the 
        // items within that list would enable users to quickly calculate like 1+2+3+4+5?
        // For now it is easier to allow the user two inputs for basic math.

        string input = string.Empty;        // Store user input
        string operand1 = string.Empty;     // First entered number
        string operand2 = string.Empty;     // Second entered number
        char operation;                     // for concatination of the math
        double result = 0.0;                // calculated result
        double longMem = 0.0;               // Long term memory

        public tdsCalc()
        {
            InitializeComponent();
        }

        // Zero Button
        private void numZero_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "0";
            this.resultTextBox.Text += input;
        }

        // Number One Button
        private void numOne_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "1";
            this.resultTextBox.Text += input;
        }

        // Number Four Button
        private void numTwo_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "2";
            this.resultTextBox.Text += input;
        }

        // Number Three Button
        private void numThree_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "3";
            this.resultTextBox.Text += input;
        }

        // Number Four Button
        private void numFour_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "4";
            this.resultTextBox.Text += input;
        }

        // Five Button
        private void numFive_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "5";
            this.resultTextBox.Text += input;
        }

        // Number Six Button
        private void numSix_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "6";
            this.resultTextBox.Text += input;
        }

        // Number Seven Button
        private void numSeven_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "7";
            this.resultTextBox.Text += input;
        }

        // Number Eight Button
        private void numEight_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "8";
            this.resultTextBox.Text += input;
        }

        // Number Nine Button
        private void numNine_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += "9";
            this.resultTextBox.Text += input;
        }
        // Decimal Button
        private void deci_btn_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            input += ".";
            this.resultTextBox.Text += input;
        }

        // Equal Sign Button (Execute & Display Button)
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                resultTextBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                resultTextBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                resultTextBox.Text = result.ToString();
            }
            
            else if (operation == '/')
            {
                if (num2 != 0 && num1 != 0)
                {
                    result = num1 / num2;
                    resultTextBox.Text = result.ToString();
                }
                // No dividing by zero!
                else
                {
                    resultTextBox.Text = "Cannot Divide by Zero!";
                }
            }
            result = 0.0;

        }

        // Addition Button
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        // Minus Button
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        // Multiplication Button
        private void buttonMulti_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        // Division Button
        private void buttonDivis_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        // Add to Memory Button
        private void butttonMemAdd_Click(object sender, EventArgs e)
        {
            if (result != 0.0)
            {
                longMem += result;
            }
            else
            {
                longMem += Convert.ToDouble(input);
            }
            resultTextBox.Clear();
        }

        // Clear Memory Button
        private void buttonMemClear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            longMem = 0.0;
            resultTextBox.Clear();
        }

        // Recall Memory Button
        private void buttonMemRecall_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = longMem.ToString();
            input = longMem.ToString();
        }
    }
}
