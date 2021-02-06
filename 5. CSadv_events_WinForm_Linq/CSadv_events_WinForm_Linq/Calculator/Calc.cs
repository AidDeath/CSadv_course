using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    enum Operation{
        Plus,
        Minus,
        Divide,
        Multiply
    }
    class Calc
    {
        public double FirstValue { get; set; }
        public double SecondValue { get; set; }
        public bool FirstFilled { get; set; }
        public Operation Operation { get; set; }

        public Calc()
        {
            FirstFilled = false;
        }

        public double DoCalc()
        {
            switch (Operation)
            {
                case Operation.Plus:
                    return FirstValue + SecondValue;
                case Operation.Minus:
                    return FirstValue - SecondValue;
                case Operation.Multiply:
                    return FirstValue * SecondValue;
                case Operation.Divide:
                    return  FirstValue / SecondValue;
                default: throw new Exception("Unknown error occured");
            }
        }
    }
}
