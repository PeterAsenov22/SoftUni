namespace Logger.Models.Appenders
{
    using System;
    using Interfaces;
    using Enums;

    public class ConsoleAppender : IAppender
    {
        private ILayout layout;
        private int messagesAppended;

        public ConsoleAppender(ILayout layout)
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
                Console.WriteLine(layout.Format(reportLevel, info));
                messagesAppended++;
            }
        }
    }
}
