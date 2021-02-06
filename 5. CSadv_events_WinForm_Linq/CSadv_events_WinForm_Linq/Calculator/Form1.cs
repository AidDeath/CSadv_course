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
    public partial class MainForm : Form
    {
        private Calc calc;
        private void OperationButtonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "+" :
                    calc.Operation = Operation.Plus;
                    break;
                case "-" :
                    calc.Operation = Operation.Minus;
                    break;
                case "*" :
                    calc.Operation = Operation.Multiply;
                    break;
                case "/":
                    calc.Operation = Operation.Divide;
                    break;
            }
            
            screen.Text += ((Button)sender).Text;
        }
        //Нажата кнопка с цифрой
        private void NumericButtonClick(object sender, EventArgs e)
        {
            if (screen.Text.Contains('=') || screen.Text.Contains("ERROR")) screen.Text = "";
            screen.Text += ((Button)sender).Text;
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(screen.Text.Substring(0, screen.Text.IndexOfAny(new[] { '+', '-', '*', '/' })));
                double b = double.Parse(screen.Text.Substring(screen.Text.IndexOfAny(new[] { '+', '-', '*', '/' }) + 1));

                calc.FirstValue = a;
                calc.SecondValue = b;
                screen.Text += $"={calc.DoCalc()}";
            }
            catch
            {
                screen.Text = "ERROR";
            }
            finally
            {
                calc = new Calc();
            }
        }
        public MainForm()
        {
            InitializeComponent();
            calc = new Calc();
        }



    }
}
