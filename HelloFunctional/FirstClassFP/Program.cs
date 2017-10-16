using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstClassFP
{
    class Program
    {
        static void Main(string[] args)
        {
            FPFirstClassFunction.Run();

            FPHighOrderFunction.Run();
        }
    }

    public static class FPFirstClassFunction
    {
        public static void Run()
        {
            Console.WriteLine("FirstClass Function : ");
            
            Func<int, bool> isMod2 = x => x % 2 == 0;
            Func<int, bool> isMod2v2 = delegate (int x) { return (x % 2 == 0); };

            var list = Enumerable.Range(1, 10);
            var evenNumbers = list.Where(isMod2v2);

            evenNumbers.ToList().ForEach(Console.WriteLine);

            Console.Read();
        }
    }

    public static class FPHighOrderFunction
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> ts, Func<T, bool> predicate)
        {
            foreach (T t in ts)
                if (predicate(t))
                    yield return t;
        }
        
        public static void Run()
        {
            Console.WriteLine("High Order Function : ");

            var range = Enumerable.Range(1, 10);

            var list = range.MyWhere(x => x % 2 == 0);

            list.ToList().ForEach(Console.WriteLine);

            Console.Read();
        }
    }
}
