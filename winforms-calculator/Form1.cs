using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace winforms_calculator
{
    public partial class Kalkulator : Form
    {
        private Double result = 0;
        private String operation = "";
        private Double operandFirst = 0, operandSecond = 0;
        private bool isCalculating = false;

        public Kalkulator()
        {
            InitializeComponent();
        }

        public Double Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public String Operation
        {
            get
            {
                return operation;
            }

            set
            {
                operation = value;
            }
        }

        public bool IsCalculating
        {
            get
            {
                return isCalculating;
            }

            set
            {
                isCalculating = value;
            }
        }

        public double OperandFirst
        {
            get
            {
                return operandFirst;
            }

            set
            {
                operandFirst = value;
            }
        }

        public double OperandSecond
        {
            get
            {
                return operandSecond;
            }

            set
            {
                operandSecond = value;
            }
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if ((textBoxValue.Text == "0") || (IsCalculating))
                textBoxValue.Text = "";

            IsCalculating = false;

            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!textBoxValue.Text.Contains("."))
                    textBoxValue.Text = textBoxValue.Text + btn.Text;
            }
            else
                textBoxValue.Text = textBoxValue.Text + btn.Text;

        
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (Result != 0)
            {
                buttonEquals.PerformClick();
                Operation = btn.Text;
                labelCurrentOperation.Text = operandFirst + " " + Operation;
                IsCalculating = true;
            }
            else
            {
                Operation = btn.Text;
                OperandFirst = Double.Parse(textBoxValue.Text);
                labelCurrentOperation.Text = OperandFirst + " " + Operation;
                IsCalculating = true;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operandSecond = Double.Parse(textBoxValue.Text);
            switch (Operation)
            {
                case "+":
                    Result = operandFirst + operandSecond;
                    break;
                case "-":
                    Result = operandFirst - operandSecond;
                    break;
                case "*":
                    Result = operandFirst * operandSecond;
                    break;
                case "/":
                    if(operandSecond == 0)
                    {
                        MessageBox.Show("Dzielenie przez 0 jest niewykonalne!");
                    }
                    else
                    {
                        Result = operandFirst / operandSecond;
                    }
                    break;
                default:
                    break;
            }
            textBoxValue.Text = Result.ToString();
            OperandFirst = Result;
            Operation = "";
            labelCurrentOperation.Text = OperandFirst.ToString();
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = textBoxValue.Text.Remove(textBoxValue.Text.Length - 1);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = "0";
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = (Result * -1).ToString();
        }

        private void textBoxValue_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = "0";
            Result = 0;
            OperandFirst = 0;
            labelCurrentOperation.Text = OperandFirst.ToString();
        }
    }
}

