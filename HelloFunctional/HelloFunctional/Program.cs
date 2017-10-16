using System;
using System.Threading;

namespace HelloFunctional
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread t = new Thread(() =>
                {
                    Console.WriteLine(Calc(10, NonZeroInt.New((2))));
                });
                t.Start();
            }

            Console.Read();
        }

        public static int Calc(int numerator, NonZeroInt value)
        {
            return numerator / value.Value;
        }

    }

    public class NonZeroInt
    {
        private int _value;

        public int Value { get => _value; }

        public NonZeroInt(int value)
        {
            _value = value;
        }

        public static NonZeroInt New(int value) =>
            new NonZeroInt(value);
    }
}