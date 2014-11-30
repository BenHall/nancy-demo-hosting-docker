namespace Nancy.Demo.Hosting.Docker
{
    public class TestModule : NancyModule
    {
        public TestModule()
        {
            Get["/"] = parameters => {
                System.Console.WriteLine("Visit / on " + System.Environment.MachineName);
                return View["staticview", Request.Url];
            };

            Get["/machine"] = parameters =>
            {
                System.Console.WriteLine("Visit /machine on " + System.Environment.MachineName);
                return System.Environment.MachineName;
            };
        }
    }
}
