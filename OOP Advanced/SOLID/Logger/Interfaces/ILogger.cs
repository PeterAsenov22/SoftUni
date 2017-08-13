namespace Logger.Interfaces
{
    public interface ILogger
    {
        void Warning(params string[] info);

        void Error(params string[] info);

        void Info(params string[] info);

        void Fatal(params string[] info);

        void Critical(params string[] info);
    }
}
