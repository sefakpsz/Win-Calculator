using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calculator
{
    public partial class Form1 : Form
    {
        private Double _value = 0;
        private string _operation = "";
        private bool _operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || _operationPressed)
            {
                result.Clear();
                _operationPressed = false;
            }
            Button b = (Button)sender;

            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    result.Text += b.Text;
                }
            }
            else
            {
                result.Text += b.Text;
            }
        }


        // Object is the Base class of the all kind of class in .Net but we want to use .Text method via Button class for that we have to downcasting because in here Object is the base class Button button = (Button)sender    in here sender is the object of Object 
        private void DeleteAllStatement(object sender, EventArgs e)
        {
            result.Text = "0";
            _value = 0;
            lblEquation.Text = "";
        }

        private void OperationClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Text == "sqrt")
            {
                result.Text = (Math.Sqrt(Double.Parse(result.Text))).ToString();
                _operation = "";
                lblEquation.Text = "";
                _operationPressed = true;
            }
            else
            {
                if (_value != 0)
                {
                    Calculation();
                    _operationPressed = true;
                    _operation = b.Text;
                    lblEquation.Text = _value + " " + _operation;
                }
                else
                {
                    _operation = b.Text;
                    _value = Double.Parse(result.Text);
                    _operationPressed = true;
                    lblEquation.Text = _value + " " + _operation;
                }
            }
        }

        private void Calculate(object sender, EventArgs e)
        {
            Calculation();
        }

        private void ButtonClear(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Calculation()
        {
            lblEquation.Text = "";
            switch (_operation)
            {
                case "+":
                    {
                        result.Text = (Operators.Add(_value , Double.Parse(result.Text))).ToString();
                        break;
                    }
                case "-":
                    {
                        result.Text = (_value - Double.Parse(result.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        result.Text = (_value * Double.Parse(result.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        result.Text = (_value / Double.Parse(result.Text)).ToString();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            _value = Double.Parse(result.Text);
            _operation = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar.ToString();

            switch (key)
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "*":
                    multi.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case ".":
                    dec.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}