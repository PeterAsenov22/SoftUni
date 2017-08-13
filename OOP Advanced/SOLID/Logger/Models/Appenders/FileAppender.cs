namespace Logger.Models.Appenders
{
    using System;
    using System.IO;
    using Interfaces;
    using Enums;

    public class FileAppender : IAppender
    {
        private ILayout layout;
        private int messagesAppended;

        public FileAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public ILayout Layout => this.layout;

        public int MessagesAppended => messagesAppended;

        public ReportLevel ReportLevel { get; set; }

        public void AppendLine(Enum reportLevel, params string[] info)
        {
            var parsedReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel.ToString());
            if (parsedReportLevel >= ReportLevel)
            {
                File.AppendAllText("log.txt", layout.Format(reportLevel, info) + Environment.NewLine);
                messagesAppended++;
            }
        }
    }
}
