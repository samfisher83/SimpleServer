using System;

namespace SimpleServer
{
    class Program
    {
        class ExampleAction : SimpleHTTPServer.IAction
        {
            public string DoAction()
            {
                return "Hello World";
            }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Port");
            var port = Console.ReadLine();
            ExampleAction action = new ExampleAction();


            SimpleHTTPServer server = new SimpleHTTPServer(".", int.Parse(port));
            server.AddRoute("hello", action);
            
        }
    }
}
