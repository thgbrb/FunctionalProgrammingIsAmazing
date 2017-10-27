using System;

namespace Composition
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = func1("10");

            var f = func1.Compose(func2)(10);
            var g = func3.Compose(func1).Compose(func2)(10);
            var s = soma.Compose(multiplicacao)(10);

            Console.WriteLine($@"f == 10 : {f == 10}");
            Console.WriteLine($@"g == 20 : {g == 20}");
            Console.WriteLine($@"s == 200 : {s == 200}");

            Console.Read();
        }

        public static Func<string, string> func4 = x => x;

        public static Func<string, int> func1 = _ => 10;
        public static Func<int, string> func2 = x => x.ToString();
        public static Func<int, int> func3 = x => x * 2;

        public static Func<int, int> soma = x => x + x;
        public static Func<int, int> multiplicacao = y => y * y;

        public static Func<int, bool> action1 = x => x == 0;
        public static Func<int, bool> action2 = x => x == 1;
    }

    public static class TDDExtensions
    {
        public static Func<T, V> Compose<T, U, V>(this Func<U, V> f, Func<T, U> g) => x => f(g(x));
    }
}
