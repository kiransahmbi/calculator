using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIAdvancedCalculator
{
    public partial class Form1 : Form
    {
        string calculatorFirst = "";
        string calculatorSecond = "";
        string operatorPressed = "";
        string calculatorResult = "";
        string memory = "";
        string equalAgainStorage = "";
        
        Boolean isOperationPressed = false;
        Boolean isCalculationComplete = false;
        Boolean isEqualedAgain = true;

        public Form1()
        {
            InitializeComponent();
        }

        public void adjustVar(string increment)
        {
            if (isCalculationComplete)
            {
                //If number pressed after calculation
                if (!isOperationPressed)
                {
                    calculatorFirst = increment;
                    textBox1.Text = calculatorFirst;
                    calculatorSecond = "";
                    isCalculationComplete = false;
                }
            } 
            else
            {
                //If operand pressed, interpret as second number
                if (isOperationPressed)
                {
                    calculatorSecond += increment;
                    textBox1.Text = calculatorSecond;
                    isEqualedAgain = false;
                }
                //If operand not pressed, interpret as first number
                else
                {
                    calculatorFirst += increment;
                    textBox1.Text = calculatorFirst;
                }
            }
        }

        private void numberOne_Click(object sender, EventArgs e)
        {
            adjustVar("1");
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            adjustVar("2");
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            adjustVar("3");
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            adjustVar("4");
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            adjustVar("5");
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            adjustVar("6");
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            adjustVar("7");
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            adjustVar("8");
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            adjustVar("9");
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            adjustVar("0");
        }

        private void flipOperator_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                if (calculatorSecond.Substring(0, 1) == "-")
                {
                    calculatorSecond = calculatorSecond.Substring(1);
                }
                else
                {
                    calculatorSecond = $"-{calculatorSecond}";
                }
                textBox1.Text = calculatorSecond;
            } 
            else
            {
                if (calculatorFirst.Substring(0, 1) == "-")
                {
                    calculatorFirst = calculatorFirst.Substring(1);
                }
                else
                {
                    calculatorFirst = $"-{calculatorFirst}";
                }
                textBox1.Text = calculatorFirst;
            }
        }
        private void decimalPoint_Click(object sender, EventArgs e)
        {
            adjustVar(".");
        }

        //Operators
        private void divideOperator_Click(object sender, EventArgs e)
        {
            isOperationPressed = true;
            operatorPressed = "divide";
            if (isCalculationComplete)
            {
                isOperationPressed = true;
                isCalculationComplete = false;
                calculatorFirst = calculatorResult;
            }
        }

        private void mutiplyOperator_Click(object sender, EventArgs e)
        {
            isOperationPressed = true;
            operatorPressed = "multiply";
            if (isCalculationComplete)
            {
                isOperationPressed = true;
                isCalculationComplete = false;
                calculatorFirst = calculatorResult;
            }
        }

        private void minusOperator_Click(object sender, EventArgs e)
        {
            isOperationPressed = true;
            operatorPressed = "minus";
            if (isCalculationComplete)
            {
                isOperationPressed = true;
                isCalculationComplete = false;
                calculatorFirst = calculatorResult;
            }
        }

        private void plusOperator_Click(object sender, EventArgs e)
        {
            isOperationPressed = true;
            operatorPressed = "plus";
            if (isCalculationComplete)
            {
                isOperationPressed = true;
                isCalculationComplete = false;
                calculatorFirst = calculatorResult;
            }
        }

        private void equalOperator_Click(object sender, EventArgs e)
        {
            if (isEqualedAgain)
            {
                switch (this.operatorPressed)
                {
                    case "divide":
                        if (this.equalAgainStorage == "0")
                        {
                            textBox1.Text = "Cannot divide by Zero";
                            break;
                        }
                        this.calculatorResult = $"{Convert.ToDouble(this.calculatorResult) / Convert.ToDouble(this.equalAgainStorage)}";
                        break;
                    case "multiply":
                        this.calculatorResult = $"{Convert.ToDouble(this.calculatorResult) * Convert.ToDouble(this.equalAgainStorage)}";
                        break;
                    case "minus":
                        this.calculatorResult = $"{Convert.ToDouble(this.calculatorResult) - Convert.ToDouble(this.equalAgainStorage)}";
                        break;
                    case "plus":
                        this.calculatorResult = $"{Convert.ToDouble(this.calculatorResult) + Convert.ToDouble(this.equalAgainStorage)}";
                        break;
                }
            }
            else
            {
                switch (this.operatorPressed)
                {
                    case "divide":
                        if (this.equalAgainStorage == "0")
                        {
                            textBox1.Text = "Cannot divide by Zero";
                            break;
                        }
                        this.calculatorResult = $"{Convert.ToDouble(this.calculatorFirst) / Convert.ToDouble(this.calculatorSecond)}";
                        break;
                    case "multiply":
                        this.calculatorResult = $"{Convert.ToDouble(this.calculatorFirst) * Convert.ToDouble(this.calculatorSecond)}";
                        break;
                    case "minus":
                        this.calculatorResult = $"{Convert.ToDouble(this.calculatorFirst) - Convert.ToDouble(this.calculatorSecond)}";
                        break;
                    case "plus":
                        this.calculatorResult = $"{Convert.ToDouble(this.calculatorFirst) + Convert.ToDouble(this.calculatorSecond)}";
                        break;
                }
            }
 
            textBox1.Text = this.calculatorResult;
            if (!(this.calculatorSecond == "")) 
            {
                this.equalAgainStorage = this.calculatorSecond;
            }
            this.calculatorFirst = "";
            this.calculatorSecond = "";
            this.isOperationPressed = false;
            this.isCalculationComplete = true;
            this.isEqualedAgain = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.calculatorFirst = "";
            this.calculatorSecond = "";
            this.operatorPressed = "";
            this.isOperationPressed = false;
            this.isCalculationComplete = false;
            textBox1.Text = "0";
        }

        //MEMORY KEYS
        private void memoryClear_Click(object sender, EventArgs e)
        {
            memory = "";
            textBox1.Text = "0";
        }

        private void memoryAdd_Click(object sender, EventArgs e)
        {
            memory = $"{Convert.ToDouble(memory) + Convert.ToDouble(textBox1.Text)}";
            textBox1.Text = memory;
            calculatorFirst = "";
            calculatorSecond = "";
        }

        private void memoryMinus_Click(object sender, EventArgs e)
        {
            memory = $"{Convert.ToDouble(memory) - Convert.ToDouble(textBox1.Text)}";
            textBox1.Text = memory;
            calculatorFirst = "";
            calculatorSecond = "";
        }

        private void memoryRecall_Click(object sender, EventArgs e)
        {
            memory = textBox1.Text;
            calculatorFirst = "";
            calculatorSecond = "";
            textBox1.Text = "0";
        }

        //KEY PRESSES
        private void form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.D0:
                    adjustVar("1");
                    this.numberZero_Click(sender, new EventArgs());
                    break;
                case (char)Keys.D1:
                    adjustVar("2");
                    this.numberOne_Click(sender, new EventArgs());
                    Console.WriteLine("SDSAKLJD");
                    break;
            }
            if (e.KeyChar == (char)Keys.D0)
            {
                this.numberZero_Click(sender, new EventArgs());
            }
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter key pressed");
            }
        }

    }
}
