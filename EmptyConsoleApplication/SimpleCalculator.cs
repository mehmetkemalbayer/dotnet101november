﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{
    class SimpleCalculator
    {
        public int Sum(int a, int b) {
            return a + b;
        }
        public int Substract(int a,int b)
        {
            return a - b;
        }
        public int Multiply(int a,int b)
        {
            return a * b;
        }
        public int Divide(int a, int b) {
            return (int)(a / b);
        }
    }
}
