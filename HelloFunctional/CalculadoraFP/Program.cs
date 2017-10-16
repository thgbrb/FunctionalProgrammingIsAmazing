using System;
using static CalculadoraFP.Calculator;

namespace CalculadoraFP
{
    public delegate double Calc(int v1, int v2);

    class Program
    {
        static void Main(string[] args)
        {
            // Calc calc = (v1, v2) => Sum(v1, v2);

            Operation operation = Operation.Sum;

            new Switch()
                .Case(() => v1 == Operation.Sum, () => Sum(v2, v3))
                .Case(() => v1 == Operation.Sub, () => Sub(v2, v3))
                .Case(() => v1 == Operation.Mul, () => Mul(v2, v3))
                .Case(() => v1 == Operation.Div, () => Div(v2, v3));
            
            Console.Read();
        }
    }

    public static class Calculator
    {
        public static Func<int, int, double> Sum => (v1, v2) => v1 + v2;
        public static Func<int, int, double> Sub => (v1, v2) => v1 - v2;
        public static Func<int, int, double> Mul => (v1, v2) => v1 * v2;
        public static Func<int, int, double> Div => (v1, v2) => v1 / v2;
    }

    public enum Operation
    {
        Sum,
        Sub,
        Mul,
        Div
    }
}