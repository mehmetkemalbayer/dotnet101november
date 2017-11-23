using System;


namespace EmptyConsoleApplication
{
    class SimpleCalculator
    {
        int a;
        int b;

        public SimpleCalculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Sum()
        {
            return a + b;
        }

        public int Substract()
        {
            return a - b;
        }

        public int Multiple()
        {
            return a * b;
        }

        public int Divide()
        {
            return a / b;
        }
    }
}
