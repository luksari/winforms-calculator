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
        private string result;
        private string operation = "";
        private string operandFirst = string.Empty, operandSecond = string.Empty;
        private bool isCalculating = false;

        public Kalkulator()
        {
            InitializeComponent();
        }

        public string Result
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

        public string Operation
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

        public string OperandFirst
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

        public string OperandSecond
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
            try
            {
                Button btn = sender as Button;

                if (btn.Text == ".")
                {
                    if (!textBoxValue.Text.Contains("."))
                        textBoxValue.Text = textBoxValue.Text + btn.Text;
                }
                else
                {
                    textBoxValue.Text = textBoxValue.Text + btn.Text;

                }
                if (textBoxValue.Text.Length >= 14)
                    textBoxValue.Text = textBoxValue.Text.Remove(textBoxValue.Text.Length - 1);
 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastąpił niespodziewany błąd, szczegóły" +
                    ex.Message);
            }
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                double res;
                double.TryParse(Result, out res);

                if (res != 0)
                {
                    Operation = btn.Text;
                    OperandFirst = textBoxValue.Text;
                    labelCurrentOperation.Text = OperandFirst + " " + Operation;
                    IsCalculating = true;
                }
                else
                {
                    Operation = btn.Text;
                    OperandFirst = textBoxValue.Text;
                    labelCurrentOperation.Text = OperandFirst + " " + Operation;
                    IsCalculating = true;
                }

       
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nastąpił niespodziewany błąd, szczegóły" +
                    ex.Message);
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            OperandSecond = textBoxValue.Text;
            double opr1, opr2;
          

            double.TryParse(OperandFirst, out opr1);
            double.TryParse(OperandSecond, out opr2);

            switch (Operation)
            {
                case "+":
                    Result = (opr1+opr2).ToString();
                    break;
                case "-":
                    Result = (opr1-opr2).ToString();
                    break;
                case "*":
                    Result = (opr1 * opr2).ToString();
                    break;
                case "/":
                    if(opr2 == 0)
                    {
                        MessageBox.Show("Dzielenie przez 0 jest niewykonalne!");
                    }
                    else
                    {
                        Result = (opr1 / opr2).ToString();
                    }
                    break;
                default:
                    break;
            }
            textBoxValue.Text = Result;
            OperandFirst = Result;
            Operation = "";
            labelCurrentOperation.Text = OperandFirst;
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

            if (textBoxValue.Text.Length <= 0 || textBoxValue.Text == "0")
                return;
            if (textBoxValue.Text[0] == '-')
                textBoxValue.Text = textBoxValue.Text.Remove(0, 1);
            else
                textBoxValue.Text = textBoxValue.Text.Insert(0, "-");
        }

        private void textBoxValue_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = "0";
            Result = string.Empty;
            OperandFirst = string.Empty;
            labelCurrentOperation.Text = OperandFirst;
        }
    }
}

