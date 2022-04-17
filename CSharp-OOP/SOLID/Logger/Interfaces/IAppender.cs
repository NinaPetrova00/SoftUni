using LoggerLibrary.Enumerations;

namespace LoggerLibrary.Interfaces
{
   public interface IAppender
    {
        public void Append(string date,ReportLevelEnum reportLevel,string message);
    }
}
