namespace Nancy.Demo.Hosting.Docker
{
    using System;
    using System.Diagnostics;

    using Nancy.Hosting.Self;

    class Program
    {
        static void Main()
        {
            var port = 8081;
            var nancyHost = new NancyHost(new Uri("http://0.0.0.0:" + port));
            nancyHost.Start();

            Console.WriteLine("Nancy now listening on http://0.0.0.0:" + port);

            var line = Console.ReadLine();
            while(line != "quit") {
              line = Console.ReadLine();
            }
        }
    }
}
