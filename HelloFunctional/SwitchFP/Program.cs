using System; using System.Linq;
using static System.Console; using static SwitchFP.ConditinalPrint; using static SwitchFP.MathHelpers;  namespace SwitchFP {     class Program     {         static void Main(string[] args)         {             for (int i = 1; i < 100; i++)             {
                PrintWhen(i, x => x % 2 == 0)($@"{i} | x % 2 == 0 |");
                PrintWhen(i, x => isEvenNumber(x))($@"{i} | isEvenNumber(x) |");                 PrintWhen(i, x => isOddNumber(x))($@"{i} | isOddNumber(x) |");
            }

            Read();         }     }      public static class ConditinalPrint     {         public static Func<int, Predicate<int>, Action<string>> PrintWhen =
            (x, y) => (y(x)) ? WriteLine : NoneAction;

        public static Action<string> NoneAction =
            (o) => { };     }

    public static class MathHelpers     {         public static Func<int, bool> isEvenNumber = (x) => x % 2 == 0;

        public static Func<int, bool> isOddNumber = (x) => x % 2 > 0;     }

    public static class Helpers     {

        public static bool p(bool type, bool teste2)
        {
            return teste2;
        }     } }

/*
using System;
using static SwitchFP.Switchv1;

namespace SwitchFP
{
    class Program
    {
        static void Main(string[] args)
        {
            Run1(10, () => Console.WriteLine);

            Run(10, x => x == 10, x => Console.WriteLine);

            Run2(10, x => x > 5)("Putz Grila!!!!!");


            Run3(10, x => x > 5)("Putz Grila!!!!!");


            Console.Read();
        }
    }

    public static class Switchv1
    {
        public static Func<int, Predicate<int>, Action<string>> Run2 = delegate (int x, Predicate<int> y)
        {
            if (y(x))
                return Console.WriteLine;

            return Console.WriteLine;
        };

        public static Func<int, Predicate<int>, Action<string>> Run3 = delegate (int x, Predicate<int> y)
        {
            return (y(x)) ? Console.WriteLine : NoneAction;
        };
        
        public static Action<string> NoneAction = (obj) => {};

        public static bool Case(int value, Func<int, bool> c) => c(value);

        public static void Run(int value, Func<int, bool> b, Func<bool, Action> a)
        {
            a(b(value));
        }

        public static void Run1(int value, Func<Action> a)
        {
            if (value > 0)
            {
                a.Invoke();
            }

        }
    }

    public class Maybe<T> where T : class
    {
        private readonly T _value;

        public Maybe(T value)
        {
            _value = value;
        }

        private Maybe() { }

        public Maybe<T0> Bind<T0>(Func<T, Maybe<T0>> func) where T0 : class
        {
            return _value != null ? func(_value) : Maybe<T0>.None();
        }

        public static Maybe<T> None() => new Maybe<T>();
    }

    public static class MaybeExtensions
    {
        public static Maybe<T> Return<T>(this T value) where T : class
        {
            return value != null ? new Maybe<T>(value) : Maybe<T>.None();
        }
    }
}
*/
