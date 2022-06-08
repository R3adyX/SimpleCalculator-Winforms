using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    
    public partial class Main : Form
    {
        private decimal _Buffer = 0m;
        private char _Operation = ' ';
        public Main()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (CalculatorScreen.Text == "0")
            {
                CalculatorScreen.Text = button.Text;
            }
            else
            {
                CalculatorScreen.Text += button.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ( _Operation == ' ')
            {
                _Operation = '+';
                _Buffer = decimal.Parse(CalculatorScreen.Text);
                CalculatorScreen.Text = "0";
            } 
            else
            {
                decimal currentValue = decimal.Parse(CalculatorScreen.Text);

                switch (_Operation)
                {
                    case '+': CalculatorScreen.Text = (_Buffer + currentValue).ToString(); break;
                    case '-': CalculatorScreen.Text = (_Buffer - currentValue).ToString(); break;
                    case 'x': CalculatorScreen.Text = (_Buffer * currentValue).ToString(); break;
                    case '/': CalculatorScreen.Text = (_Buffer / currentValue).ToString(); break;
                    default: ("0").ToString(); break;
                }
                
                _Buffer = 0;
                _Operation = ' ';
            }

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (_Operation == ' ')
            {
                _Operation = 'x';
                _Buffer = decimal.Parse(CalculatorScreen.Text);
                CalculatorScreen.Text = "0";
            }
            else
            {
                decimal currentValue = decimal.Parse(CalculatorScreen.Text);

                switch (_Operation)
                {
                    case '+': CalculatorScreen.Text = (_Buffer + currentValue).ToString(); break;
                    case '-': CalculatorScreen.Text = (_Buffer - currentValue).ToString(); break;
                    case 'x': CalculatorScreen.Text = (_Buffer * currentValue).ToString(); break;
                    case '/': CalculatorScreen.Text = (_Buffer / currentValue).ToString(); break;
                    default: ("0").ToString(); break;
                }

                _Buffer = 0;
                _Operation = ' ';
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (_Operation == ' ')
            {
                _Operation = '/';
                _Buffer = decimal.Parse(CalculatorScreen.Text);
                CalculatorScreen.Text = "0";
            }
            else
            {
                decimal currentValue = decimal.Parse(CalculatorScreen.Text);

                switch (_Operation)
                {
                    case '+': CalculatorScreen.Text = (_Buffer + currentValue).ToString(); break;
                    case '-': CalculatorScreen.Text = (_Buffer - currentValue).ToString(); break;
                    case 'x': CalculatorScreen.Text = (_Buffer * currentValue).ToString(); break;
                    case '/': CalculatorScreen.Text = (_Buffer / currentValue).ToString(); break;
                    default: ("0").ToString(); break;
                }

                _Buffer = 0;
                _Operation = ' ';
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (_Operation == ' ')
            {
                _Operation = '-';
                _Buffer = decimal.Parse(CalculatorScreen.Text);
                CalculatorScreen.Text = "0";
            }
            else
            {
                decimal currentValue = decimal.Parse(CalculatorScreen.Text);

                switch (_Operation)
                {
                    case '+': CalculatorScreen.Text = (_Buffer + currentValue).ToString(); break;
                    case '-': CalculatorScreen.Text = (_Buffer - currentValue).ToString(); break;
                    case 'x': CalculatorScreen.Text = (_Buffer * currentValue).ToString(); break;
                    case '/': CalculatorScreen.Text = (_Buffer / currentValue).ToString(); break;
                    default: ("0").ToString(); break;
                }

                _Buffer = 0;
                _Operation = ' ';
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (_Operation == ' ')
            {
                CalculatorScreen.Text = "0";
            }
            else
            {
                decimal currentValue = decimal.Parse(CalculatorScreen.Text);

                switch (_Operation)
                {
                    case '+': CalculatorScreen.Text = (_Buffer + currentValue).ToString(); break;
                    case '-': CalculatorScreen.Text = (_Buffer - currentValue).ToString(); break;
                    case 'x': CalculatorScreen.Text = (_Buffer * currentValue).ToString(); break;
                    case '/': CalculatorScreen.Text = (_Buffer / currentValue).ToString(); break;
                    default: ("0").ToString(); break;
                }

                _Buffer = 0;
                _Operation = ' ';
            }
        }
    }
}
