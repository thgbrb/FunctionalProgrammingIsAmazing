using System;
using System.Collections.Generic;

namespace CommandPatternFP
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new List<Command>
            {
                Commands.ShowMessage1("Mensagem 1"),
                Commands.ShowMessage2("Mensagem 2"),
                Commands.ShowMessage3("Mensagem 3")
            };
            
            commands.ForEach(x => x());
        
            Console.Read();
        }
    }

    public delegate void Command();
    
    public static class Commands
    {
        public static Command ShowMessage1(string message) => () => Console.WriteLine(message);

        public static Command ShowMessage2(string message) => () => Console.WriteLine(message);

        public static Command ShowMessage3(string message) => () => Console.WriteLine(message);
    }
}
