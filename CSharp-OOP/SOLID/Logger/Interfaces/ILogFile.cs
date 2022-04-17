
namespace LoggerLibrary.Interfaces
{
    public interface ILogFile
    {
        public void Write(string message);

        public int Size { get; }
    }
}
