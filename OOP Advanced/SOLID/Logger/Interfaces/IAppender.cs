namespace Logger.Interfaces
{
    using System;
    using Enums;

    public interface IAppender
    {
        ILayout Layout { get; }

        int MessagesAppended { get; }

        ReportLevel ReportLevel { get; set; }

        void AppendLine(Enum reportLevel, params string[] info);
    }
}
