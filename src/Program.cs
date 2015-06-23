namespace Nancy.Demo.Hosting.Docker
{
    using Microsoft.Owin.Hosting;
    using System;

    class Program
    {
        static void Main()
        {
            var port = 8080;

            using (WebApp.Start<Startup>(string.Format("http://*:{0}", port)))
            {
                Console.WriteLine("Nancy now listening on http://*:" + port);

                var line = Console.ReadLine();
                while (line != "quit")
                {
                    line = Console.ReadLine();
                }
            }
        }
    }
}
