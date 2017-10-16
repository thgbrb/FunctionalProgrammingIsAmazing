using System;
using System.Collections.Generic;
using System.Linq;
using static System.Linq.ParallelEnumerable;

namespace FPGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = MultiplicationFormatter.Format(Enumerable.Range(1, 10).ToList());

            list.ForEach(Console.WriteLine);

            Console.Read();
        }
    }

    public static class Extensions
    {
        public static int MultiplyBy2(this int value)
        {
            return value * 2;
        }
    }

    public static class MultiplicationFormatter
    {
        // static int counter;

        // static string Counter(int val) => $"{++counter} X 2 = {val}";

        public static List<string> Format(List<int> list) =>
            list.AsParallel()
            .Select(Extensions.MultiplyBy2)
            .Zip(Range(1, list.Count), (val, counter) => $"{counter} X 2 = {val}")
            .ToList();
    }

    /*
        public static class MultiplicationFormatter
        {
            static int counter;

            static string Counter(int val) => $"{++counter} X 2 = {val}";

            public static List<string> Format(List<int> list) =>
                list.AsParallel()
                .Select(Extensions.MultiplyBy2)
                .Select(Counter)
                .ToList();
        }
        */
}