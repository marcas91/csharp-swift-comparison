using System;

namespace ConsoleApplication1
{
    interface Protocol
    {
        void Func1();
    }

    static class Extension
    {
        public static void Func2(this Protocol p)
        {
            Console.WriteLine("Func2 called from Extension");
        }
    }

    class Implementor : Protocol
    {
        public void Func1()
        {
            Console.WriteLine("Func1 called from Implementor");
        }

        public void Func2()
        {
            Console.WriteLine("Func2 called from Implementor");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var a = new Implementor();
            a.Func1(); // calls Implementor method
            a.Func2(); // calls Implementor method

            Protocol b = new Implementor(); // or "var b = (Protocol)a;"
            b.Func1(); // calls Implementor method; no way in C# for Protocol to provide default implementation
            b.Func2(); // calls Extension method

            Console.ReadKey();
        }
    }
}
