using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StackCalculate
{
    public partial class Calculater : Form
    {
        public Calculater()
        {
            InitializeComponent();
        }
        private void Calculater_Load(object sender, EventArgs e)
        {
            tbxResult.ReadOnly = true;
        }

        //记录用户输入状态
        bool isUserTypingANumber = false;

        //存放数字的栈
        Stack<double> operandStack = new Stack<double>();

        //运算委托 分别代表单目运算符和双目运算符
        public delegate double BinaryCalculate(double a, double b);
        public delegate double Calculate(double a);

        //计算属性 关联文本框
        public double DisplayValue
        {
            get
            {
                return Convert.ToDouble(tbxResult.Text);
            }
            set
            {
                tbxResult.Text = value.ToString();
            }
        }

        //将用户点击的数字追加到文本框
        private void AppendDigit(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (isUserTypingANumber)
            {
                tbxResult.Text += btn.Text;
            }
            else
            {
                tbxResult.Text = btn.Text;
                isUserTypingANumber = true;
            }
        }

        //运算符点击事件
        private void PerformOperate(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (isUserTypingANumber)
            {
                btnEnter.PerformClick();
            }
            switch (btn.Text)
            {
                //将匿名函数作为参数传递进计算方法
                case "+": CalculateBrain((a, b) => a + b); break;
                case "-": CalculateBrain((a, b) => b - a); break;
                case "*": CalculateBrain((a, b) => a * b); break;
                case "/": CalculateBrain((a, b) => b / a); break;
                case "Sqrt": CalculateBrain(a => Math.Sqrt(a)); break;
                default: break;
            }
        }

        //双目运算符的计算方法
        public void CalculateBrain(BinaryCalculate c)
        {
            if (operandStack.Count >= 2)
            {
                DisplayValue = c.Invoke(operandStack.Pop(), operandStack.Pop());
                btnEnter.PerformClick();
            }
        }

        //单目运算符的计算方法
        public void CalculateBrain(Calculate c)
        {
            if (operandStack.Count >= 1)
            {
                DisplayValue = c.Invoke(operandStack.Pop());
                btnEnter.PerformClick();
            }
        }

        //压栈
        private void EnterClick(object sender, EventArgs e)
        {
            isUserTypingANumber = false;
            operandStack.Push(DisplayValue);
            PrintStack();
        }

        //单清
        private void btnC_Click(object sender, EventArgs e)
        {
            if (tbxResult.Text.Length == 1)
            {
                DisplayValue = 0;
                isUserTypingANumber = false;
            }
            else
            {
                tbxResult.Text = tbxResult.Text.Substring(0, tbxResult.Text.Length - 1);
            }
        }

        //全清
        private void btnAC_Click(object sender, EventArgs e)
        {
            DisplayValue = 0;
            isUserTypingANumber = false;
            operandStack.Clear();
            PrintStack();
        }

        //打印栈内容
        private void PrintStack()
        {
            rtbxStackStatus.Text = "";
            foreach (var item in operandStack)
            {
                rtbxStackStatus.Text += item.ToString() + "\n";
            }
        }
    }
}
