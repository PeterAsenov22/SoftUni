namespace Logger.Models
{
    using Interfaces;
    using Enums;

    public class Logger : ILogger
    {
        private readonly IAppender[] appenders;

        public Logger(params IAppender[] appender)
        {
            this.appenders = appender;
        }

        public void Warning(params string[] info)
        {
            foreach (var appender in appenders)
            {
                appender.AppendLine(ReportLevel.Warning, info);
            }      
        }

        public void Error(params string[] info)
        {
            foreach (var appender in appenders)
            {
                appender.AppendLine(ReportLevel.Error, info);
            }
        }

        public void Info(params string[] info)
        {
            foreach (var appender in appenders)
            {
                appender.AppendLine(ReportLevel.Info, info);
            }
        }

        public void Fatal(params string[] info)
        {
            foreach (var appender in appenders)
            {
                appender.AppendLine(ReportLevel.Fatal, info);
            }
        }

        public void Critical(params string[] info)
        {
            foreach (var appender in appenders)
            {
                appender.AppendLine(ReportLevel.Critical, info);
            }
        }
    }
}
