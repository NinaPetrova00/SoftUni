namespace LoggerLibrary
{
    using Appenders;
    using Interfaces;
    using Layouts;
    using Loggers;
    public class StartUp
    {
        static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout(); // string template with place holders
            IAppender consoleAppender = new ConsoleAppender(simpleLayout); 
            ILogger logger = new Logger(consoleAppender);

            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

            //string template = "{0} - {1} - {2}";
            //Console.WriteLine(string.Format(template, "01.01.01", "Error", "Error message"));
        }
    }
}
