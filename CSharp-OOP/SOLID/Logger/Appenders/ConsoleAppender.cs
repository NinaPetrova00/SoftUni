using LoggerLibrary.Enumerations;
using LoggerLibrary.Interfaces;
using System;

namespace LoggerLibrary.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private ILayout layout;
        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public void Append(string date, ReportLevelEnum reportLevel, string message)
        {
            string content = string.Format(this.layout.Template, date, reportLevel, message);
            Console.WriteLine(content);
        }
    }
}
