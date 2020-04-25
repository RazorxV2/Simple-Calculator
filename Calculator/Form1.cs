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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String leftSide = "";
        String rightSide = "";
        String operand = "";
        double result = 0;


        private void Seven_Click(object sender, EventArgs e)
        {
                resultBox.AppendText(seven.Text);
        
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(eight.Text);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(nine.Text);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(five.Text);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(six.Text);
        }

        private void One_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(one.Text);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(two.Text);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(three.Text);
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(zero.Text);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(four.Text);
        }

        private void DecimalPoint_Click(object sender, EventArgs e)
        {
            resultBox.AppendText(decimalPoint.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            rightSide = "";
            leftSide = "";
            operand = "";
            resultBox.Text = "";
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            leftSide = resultBox.Text;
            operand = "+";
            resultBox.Text = "";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            leftSide = resultBox.Text;
            operand = "-";
            resultBox.Text = "";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            leftSide = resultBox.Text;
            operand = "*";
            resultBox.Text = "";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            leftSide = resultBox.Text;
            operand = "/";
            resultBox.Text = "";
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.StartsWith("-"))
                resultBox.Text = resultBox.Text.Remove(0, 1);
            else
                resultBox.Text = "-" + resultBox.Text;
        }

        private void Modulo_Click(object sender, EventArgs e)
        {
            leftSide = resultBox.Text;
            operand = "%";
            resultBox.Text = "";
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            rightSide = resultBox.Text;
            double.TryParse(leftSide, out double lSide);
            double.TryParse(rightSide, out double rSide);
            switch (operand)
            {
                case "+":
                    result = lSide + rSide;
                    break;
                case "-":
                    result = lSide - rSide;
                    break;
                case "*":
                    result = lSide * rSide;
                    break;
                case "/":
                    result = lSide / rSide;
                    break;
                case "%":
                    result = lSide % rSide;
                    break;
                default:
                    resultBox.Text = result.ToString();
                    break;
            }
            resultBox.Text = result.ToString();

        }


    }
}
