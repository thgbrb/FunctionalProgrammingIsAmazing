using System;
using System.Linq;

namespace ConsoleTesting
{
    class Program
    {
        public delegate T IO<out T>();


        static void Main(string[] args)
        {
            var result = Monads.Execute();

            Console.WriteLine(result.Invoke());

            Console.ReadLine();
        }
    }

    public static class Monads
    {
        public delegate T IO<out T>();

        public static IO<R> SelectMany<S, C, R>(this IO<S> A, Func<S, IO<C>> foo, Func<S, C, R> bar)
        {
            var a = A();
            var B = foo(a);
            var b = B();
            var c = bar(a, b);
            return () => c;
        }

        public static IO<T> Combine<T>(IO<T> a, Action b)
        {
            return new Func<IO<T>, IO<T>>(x => { b(); return x; })(a);
        }

        public static IO<T> Where<T>(this IO<T> t, Func<T, bool> foo)
        {
            return () => (foo(t()) ? t : Combine(t, () => { Console.WriteLine("We screwed up!"); }))();
        }

        public static IO<R> Select<S, R>(this IO<S> s, Func<S, R> foo)
        {
            return () => new Func<IO<S>, R>(x => foo(x()))(s);
        }

        public static IO<int> Execute()
        {
            var A = new IO<int>(() => { Console.WriteLine("A"); return 6; });
            var B = new IO<int>(() => { Console.WriteLine("B"); return 7; });
            var C = new IO<int>(() => { Console.WriteLine("C"); return 10; });

            var sum =
                from a in A
                from b in B
                from c in C
                let x = 10
                where a > b
                select a + b + c + x;

            return sum;
        }
    }
}
