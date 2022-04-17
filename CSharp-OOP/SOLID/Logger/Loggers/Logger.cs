using LoggerLibrary.Enumerations;
using LoggerLibrary.Interfaces;

namespace LoggerLibrary.Loggers
{
    public class Logger : ILogger
    {
        private IAppender appender;
        public Logger(IAppender appender)
        {
            this.appender = appender;
        }

        public void Error(string date, string message)
        {
            this.appender.Append(date, ReportLevelEnum.Error, message);
        }

        public void Info(string date, string message)
        {
            this.appender.Append(date, ReportLevelEnum.Info, message);
        }


    }
}
