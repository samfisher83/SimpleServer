# SimpleServer

Fork of this super simple server file:

// MIT License - Copyright (c) 2016 Can Güney Aksakalli
// https://aksakalli.github.io/2014/02/24/simple-http-server-with-csparp.html


Added simple routes:
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
    
  If you type localhost:{port}/hello
  
  The browser display hello world.
