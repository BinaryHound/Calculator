using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAttempt {
    //ALL METHODS ARE PUBLIC FOR UNIT TESTING CURRENTLY!

        /*
         * Current Erros:
         * Logic: if you have a two digit number I believe it still treats it as a single digit input.
         *        StringBuilder issue with displaying the correct output for equations larger than one value.
         *        
         */

        //to stop infinitely adding logical operators could we simply see if the length of the operands stack has changed since the last addition?

    public partial class Form1 : Form {

        //Operators: The logical manipulations of data such as: +, -, *, /.
        public Stack<char> operatorsStack;

        private StringBuilder sb;

        //Operands: The actual data, such as: 1, 2, 3, 4, 5, 6, 7, 8, 9, 0.
        public Stack<float> operandsStack;

        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public Form1() {
            InitializeComponent();
            operatorsStack = new Stack<char>();
            //has to be a float because otherwise we lose precision.
            operandsStack = new Stack<float>();
            sb = new StringBuilder();
        }

        /// <summary>
        /// Checks to see if the values entered are in the correct order. Helps minimize wrongful operations to parsing.
        /// </summary>
        /// <returns></returns>
        public bool TokenChecker(Stack<float> Operand, Stack<char> Operator)
        {
            //TODO: Check to see if the next addition is valid.
            if( Operand.Count > 0 && Operator.Count < Operand.Count )
            {
                return true;
            }
            return false;
        }

        public void EvaluateExpression(Stack<float> Operand, Stack<char> Operator)
        {
            //TODO: Evaluate the expression by 'popping' off of the Stacks and replacing with a push to the Operands Stack.
            float result = 0;
            while (( Operand.Count  > 0 ) && ( Operator.Count > 0 )) 
            {
                float num1 = Operand.Pop();
                float num2 = Operand.Pop();
                char evaluater = Operator.Pop();
                switch(evaluater)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    case '.':
                        Console.WriteLine("Currently not implemented...");
                        break;
                }
                operandsStack.Push(result);
                Console.WriteLine(sb.Length); 
                sb.Remove(0, sb.Length);
                sb.Append(result.ToString());
                Output.Text = sb.ToString();
            }
        }
        
        //TODO: Look into using only one delegate for a button press and possibly using a switch to find the right values.

        public void One_Click(object sender, EventArgs e)
        {
            //I want to call a method that checks that an operator is next to the number so we aren't adding 1 2 + unless of course.
            //the number is 12.
            operandsStack.Push(1);
            sb.Append("1");
            Output.Text = sb.ToString();
        }

        public void Two_Click(object sender, EventArgs e)
        {
            sb.Append("2");
            operandsStack.Push(2);
            Output.Text = sb.ToString();
        }


        public void Three_Click(object sender, EventArgs e)
        {
            sb.Append("3");
            operandsStack.Push(3);
            Output.Text = sb.ToString();
        }

        public void Four_Click(object sender, EventArgs e)
        {
            sb.Append("4");
            operandsStack.Push(4);
            Output.Text = sb.ToString();
        }

        public void Five_Click(object sender, EventArgs e)
        {
            sb.Append("5");
            operandsStack.Push(5);
            Output.Text = sb.ToString();
        }

        public void Six_Click(object sender, EventArgs e)
        {
            sb.Append("6");
            operandsStack.Push(6);
            Output.Text = sb.ToString();
        }

        public void Seven_Click(object sender, EventArgs e)
        {
            sb.Append("7");
            operandsStack.Push(7);
            Output.Text = sb.ToString();
        }

        public void Eight_Click(object sender, EventArgs e)
        {
            sb.Append("8");
            operandsStack.Push(8);
            Output.Text = sb.ToString();
        }

        public void Nine_Click(object sender, EventArgs e)
        {
            sb.Append("9");
            operandsStack.Push(9);
            Output.Text = sb.ToString();
        }

        public void Zero_Click(object sender, EventArgs e)
        {
            sb.Append("0");
            operandsStack.Push(0);
            Output.Text = sb.ToString();
        }

        public void Subtract_Click(object sender, EventArgs e)
        {
            //Make sure that if the - button is pressed that there is even anything to subtract in the first place.
            if(TokenChecker(operandsStack, operatorsStack))
            {
                operatorsStack.Push('-');
                sb.Append(" - ");
                Output.Text = sb.ToString();
            }
        }

        public void Add_Click(object sender, EventArgs e)
        {
            if (TokenChecker(operandsStack, operatorsStack))
            {
                operatorsStack.Push('+');
                sb.Append(" + ");
                Output.Text = sb.ToString();
            }
        }

        public void Equals_Click(object sender, EventArgs e)
        {
            EvaluateExpression(operandsStack, operatorsStack);
        }

        public void Decimal_Click(object sender, EventArgs e)
        {
            TokenChecker(operandsStack, operatorsStack);
            operatorsStack.Push('.');
        }

        public void Multiply_Click(object sender, EventArgs e)
        {
            if (TokenChecker(operandsStack, operatorsStack))
            {
                operatorsStack.Push('*');
                sb.Append(" * ");
                Output.Text = sb.ToString();
            }
        }

        public void Division_Click(object sender, EventArgs e)
        {
            if (TokenChecker(operandsStack, operatorsStack))
            {
                operatorsStack.Push('/');
                sb.Append(" / ");
                Output.Text = sb.ToString();
            }
        }
    }
}
