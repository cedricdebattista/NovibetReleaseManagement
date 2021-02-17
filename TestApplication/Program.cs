using System;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new TestService();

            Console.WriteLine(ts.DoSomething("Hi", "Hi"));


            
        }
    }
}
