namespace LoggerLibrary.Interfaces
{
    public interface ILogger
    {
        public void Info(string date, string message);
        public void Error(string date, string message);
    }
}
