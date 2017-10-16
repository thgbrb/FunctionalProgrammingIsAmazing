using System;

namespace OutrosTestesFP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Email.Create("teste@teste.com.br"));

            Console.Read();
        }
    }

    public struct Email
    {
        public readonly string Address;

        private Email(string address)
        {
            Address = address;
        }

        public static Func<string, Email> Create = (x) => new Email(x);

        public static implicit operator Email(string email) => Create(email);

        public static implicit operator string(Email email) => email.Address;
    }
}